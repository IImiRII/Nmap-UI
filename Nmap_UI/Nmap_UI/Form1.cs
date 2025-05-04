using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Linq; // .Any() için ekleyin
using System.Text.RegularExpressions;

namespace Nmap_UI
{
    public partial class Form1 : Form
    {
        private Process currentProcess = null;
        // o anda calisan Nmap process
        public Form1()
        {
            InitializeComponent();

            target_textBox.TextChanged += target_textBox_TextChanged;
            profile_comboBox.SelectedIndexChanged += profile_comboBox_SelectedIndexChanged;
            scan_button.Click += scan_button_Click;
            cancel_button.Click += cancel_button_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nmap";
            target_textBox.Text = " "; // programı baslatinca nmap yazisini gormek icin.
            profile_comboBox.SelectedIndex = 0; // profilde ilk secenek secilmesi icin.

        }

        // Nmap komutunu yeniler
        private void target_textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandDisplay();
        }
        // Nmap komutunu yeniler
        private void profile_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandDisplay();
        }

        private void UpdateCommandDisplay()
        {
            string target = target_textBox.Text;
            string profileCommand = GetProfileCommand(profile_comboBox.Text);
            string command = $"nmap {profileCommand} {target}";
            command_textBox.Text = command;
        }

        private string GetProfileCommand(string profile)
        {
            // Profil secimine gore nmap komutu.
            switch (profile)
            {
                case "Intense scan":
                    return "-T4 -A -v";
                case "Intense scan plus UDP":
                    return "-sS -sU -T4 -A -v";
                case "Intense scan, all TCP ports":
                    return "-p 1-65535 -T4 -A -v";
                case "Intense scan, no ping":
                    return "-T4 -A -v -Pn";
                case "Ping scan":
                    return "-sn";
                case "Quick scan":
                    return "-T4 -F";
                case "Quick scan plus":
                    return "-sV -T4 -O -F --version-light";
                case "Quick traceroute":
                    return "-sn --traceroute";
                case "Regular scan":
                    return " ";
                case "Slow comprehensive scan":
                    return "nmap -sS -sU -T4 -A -v -PE -PP -PS80,443 -PA3389 -PU40125 -PY -g 53 --script \"default or (discovery and safe)\"";
                default:
                    return "";
            }
        }

        // Nmap komutunu cmd'den calistir ve ciktiyi goster.
        // async cunku anlik olarak ciktinin degismesini istiyoruz.
        private async void RunNmapScan()
        {
            UpdateCommandDisplay();
            string command = command_textBox.Text;
            string collectedOutput = "";  // tüm output burada toplanacak

            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                var process = new Process { StartInfo = startInfo };
                currentProcess = process;  // Cancel butonu için saklıyoruz

                process.OutputDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                    {
                        collectedOutput += e.Data + "\n";
                        AppendOutput(e.Data + "\n");
                    }
                };
                process.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                    {
                        collectedOutput += e.Data + "\n";
                        AppendOutput(e.Data + "\n");
                    }
                };

                output_richbox.Clear();
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // İşlem bitene kadar bekleyelim, ama UI donmasın
                await Task.Run(() => process.WaitForExit());

                // --- İşlem tamamlandıktan sonra: ---

                string ip = target_textBox.Text.Trim();
                char osInitial = GetOsInitialFromOutput(collectedOutput);

                // 1) Hosts paneline ekle
                AddOsHostLink(osInitial, ip);

                // 2) Ports/Hosts tablosunu doldur
                PopulatePortsGrid(ip, collectedOutput);

                // İşlem referansını temizleyelim
                currentProcess = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running Nmap: {ex.Message}");
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProcess != null && !currentProcess.HasExited)
                {
                    currentProcess.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cancel error!: {ex.Message}");
            }
            finally
            {
                // Process referansini sifirla
                currentProcess = null;
                // target_textBox.Clear();
                output_richbox.Clear();
                profile_comboBox.SelectedIndex = 0;
            }
        }

        private void PopulatePortsGrid(string ip, string collectedOutput)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, string>(PopulatePortsGrid), ip, collectedOutput);
                return;
            }

            // 1) Önceki satırları temizleyelim:
            portsDataGridView.Rows.Clear();

            // 2) Her satırı ayrı işleyelim
            var lines = collectedOutput
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Regex: port/protocol  state  service  [version...]
            var regex = new Regex(@"^(\d+)\/(tcp|udp)\s+(\S+)\s+(\S+)(?:\s+(.+))?$",
                                  RegexOptions.IgnoreCase);

            foreach (var line in lines)
            {
                var m = regex.Match(line);
                if (!m.Success)
                    continue;

                string port = m.Groups[1].Value;
                string protocol = m.Groups[2].Value;
                string state = m.Groups[3].Value;
                string service = m.Groups[4].Value;
                string version = m.Groups[5].Success ? m.Groups[5].Value : "";

                // Y: open, K: başka her durum
                string yk = state.Equals("open", StringComparison.OrdinalIgnoreCase)
                              ? "Y" : "K";

                portsDataGridView.Rows.Add(
                    ip,      // Host
                    yk,      // Y/K
                    port,    // Port
                    protocol,// Protocol
                    state,   // State
                    service, // Service
                    version  // Version
                );
            }
        }

        private void UpdateOutput(string output)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateOutput), new object[] { output });
                return;
            }
            output_richbox.Text = output;
        }

        private void AppendOutput(string text)
        {
            if (output_richbox.InvokeRequired)
            {
                output_richbox.Invoke(new Action(() => output_richbox.AppendText(text)));
            }
            else
            {
                output_richbox.AppendText(text);
            }
        }

        // outputta gerekli isletim sistemi stringini arar.
        private char GetOsInitialFromOutput(string nmapOutput)
        {
            if (nmapOutput.IndexOf("Windows", StringComparison.InvariantCultureIgnoreCase) >= 0)
                return 'W';
            if (nmapOutput.IndexOf("Linux", StringComparison.InvariantCultureIgnoreCase) >= 0)
                return 'L';
            // Başka OS’ler icin ekleme
            return '?';
        }

        // FlowLayoutPanel icine bir LinkLabel daha ekler
        private void AddOsHostLink(char osInitial, string ip)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<char, string>(AddOsHostLink), osInitial, ip);
                return;
            }

            string labelText = $"{osInitial}    {ip}";

            // aynisi varsa ekleme
            bool exists = os_host_flowLayoutPanel.Controls
                .OfType<LinkLabel>()
                .Any(ll => ll.Text == labelText);
            if (exists)
                return;

            // yeni linkLayer olursur ve ekle
            var link = new LinkLabel
            {
                Text = labelText,
                AutoSize = true,
                Margin = new Padding(3),
            };
            link.LinkClicked += (s, e) =>
            {
                MessageBox.Show($"Host has been clicked: {ip}", "Host has been selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            os_host_flowLayoutPanel.Controls.Add(link);
        }

        private void scan_button_Click(object sender, EventArgs e)
        {
            RunNmapScan();
        }
    }
}
