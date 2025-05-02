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

namespace Nmap_UI
{
    public partial class Form1: Form
    {
        private Process currentProcess = null;
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
            target_textBox.Text = " "; // programı başlatınca nmap yazısı gelmesi için.
            profile_comboBox.SelectedIndex = 0; // ilk seçenek seçilmesi için.

        }

        private void target_textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandDisplay();
        }
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
            // Profile seçimine göre Nmap komut parçası döndürür.
            switch (profile)
            {
                case "Intense scan":
                    return "-T4 -A -v";
                case "Quick scan":
                    return "-T4 -F";
                default:
                    return "";
            }
        }

        // Nmap komutunu cmd üzerinden çalıştırır ve çıktıyı gösterir.
        // async çünkü anlık olarak çıktının değişmesini istiyoruz.
        private async void RunNmapScan()
        {
            UpdateCommandDisplay();
            string command = command_textBox.Text;
            string collectedOutput = "";  // tüm çıktıyı burada saklayacağız

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

                await Task.Run(() => process.WaitForExit());

                // Burada, tarama bitti; şimdi Hosts paneline ekleyelim:
                string ip = target_textBox.Text.Trim();
                char osInitial = GetOsInitialFromOutput(collectedOutput);
                AddOsHostLink(osInitial, ip);
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
                MessageBox.Show($"Cancel hatası: {ex.Message}");
            }
            finally
            {
                // Process referansını sıfırla
                currentProcess = null;
                // Tüm alanları temizle
                // target_textBox.Clear();
                output_richbox.Clear();
                profile_comboBox.SelectedIndex = 0;
            }
        }
        private void UpdateOutput(string output)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateOutput), new object[] { output });
                return;
            }
            output_richbox.Text = output;  // output_richbox, Nmap çıktısını gösteren TextBox.
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

        // Bu helper, basitçe nmap çıktısında "Windows" veya "Linux" kelimelerini arayıp
        // uygun baş harfi döndürür. Bunu ihtiyacınıza göre geliştirebilirsiniz.
        private char GetOsInitialFromOutput(string nmapOutput)
        {
            if (nmapOutput.IndexOf("Windows", StringComparison.InvariantCultureIgnoreCase) >= 0)
                return 'W';
            if (nmapOutput.IndexOf("Linux", StringComparison.InvariantCultureIgnoreCase) >= 0)
                return 'L';
            // Başka OS’ler için ekleme yapabilirsiniz...
            return '?';
        }

        // FlowLayoutPanel içine bir LinkLabel daha ekler
        private void AddOsHostLink(char osInitial, string ip)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<char, string>(AddOsHostLink), osInitial, ip);
                return;
            }

            string labelText = $"{osInitial}    {ip}";

            // Aynı metinli bir LinkLabel zaten varsa, yeniden ekleme
            bool exists = os_host_flowLayoutPanel.Controls
                .OfType<LinkLabel>()
                .Any(ll => ll.Text == labelText);
            if (exists)
                return;

            // Yeni LinkLabel oluştur ve ekle
            var link = new LinkLabel
            {
                Text = labelText,
                AutoSize = true,
                Margin = new Padding(3),
            };
            link.LinkClicked += (s, e) =>
            {
                MessageBox.Show($"Host tıklandı: {ip}", "Host Seçildi",
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
