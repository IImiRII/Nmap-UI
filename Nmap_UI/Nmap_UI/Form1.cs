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

        // Scans kismi icin veri yapisi
        private BindingList<ScanEntry> scanList = new BindingList<ScanEntry>();
        public class ScanEntry
        {
            public string Status { get; set; }
            public string Command { get; set; }
        }

        // kullanici kendi profilini eklemek icin yapilan veri yapiları
        private Dictionary<string, string> customProfiles = new Dictionary<string, string>();
        private Dictionary<string, string> customDescriptions = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            target_textBox.TextChanged += target_textBox_TextChanged;
            profile_comboBox.SelectedIndexChanged += profile_comboBox_SelectedIndexChanged;
            scan_button.Click += scan_button_Click;
            cancel_button.Click += cancel_button_Click;

            // Profile sekmesindeki butonlar
            newProfileToolStripMenuItem.Click += NewProfileToolStripMenuItem_Click;
            editProfileToolStripMenuItem.Click += EditProfileToolStripMenuItem_Click;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nmap";
            target_textBox.Text = " "; // programı baslatinca nmap yazisini gormek icin.
            profile_comboBox.SelectedIndex = 0; // profilde ilk secenek secilmesi icin.

            // scansDataGridView ayarları:
            scans_DataGridView.AutoGenerateColumns = false;
            scans_DataGridView.Columns.Clear();

            // Status sütunu
            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                ReadOnly = true
            };
            scans_DataGridView.Columns.Add(colStatus);

            // Command sütunu
            var colCommand = new DataGridViewTextBoxColumn
            {
                Name = "Command",
                DataPropertyName = "Command",
                HeaderText = "Command",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            scans_DataGridView.Columns.Add(colCommand);

            // Binding
            scans_DataGridView.DataSource = scanList;

            // Buton olaylarını da burada bağlayabilirsiniz:
            btnRemoveScan.Click += btnRemoveScan_Click;
            btnCancelScan.Click += btnCancelScan_Click;

        }

        // Alttaki iki metot Profile sekmesi icin
        private void NewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var editor = new ProfileEditorForm())
            {
                // Show modal: arkada Form1 görünür kalır
                if (editor.ShowDialog(this) == DialogResult.OK)
                {
                    string name = editor.ProfileNameValue;
                    string cmd = editor.ProfileCommandValue;

                    // 1) Combobox'a ekle
                    profile_comboBox.Items.Add(name);

                    // 2) Dictionary'e de sakla
                    customProfiles[name] = cmd;
                    customDescriptions[name] = editor.ProfileDescriptionValue;

                    // 3) Otomatik seç
                    profile_comboBox.SelectedItem = name;
                }
            }
        }

        private void EditProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Seçili profilin adı
            if (!(profile_comboBox.SelectedItem is string oldName)) return;

            // Sözlükte kayıtlı cmd ve desc alalım
            string oldDesc = "";
            if (!customDescriptions.TryGetValue(oldName, out oldDesc))
                oldDesc = GetProfileDescription(oldName);

            customProfiles.TryGetValue(oldName, out var oldCmd);

            // Düzenleme formunu aç
            using (var editor = new ProfileEditorFormDelete(oldName, oldDesc, oldCmd))
            {
                if (editor.ShowDialog(this) != DialogResult.OK)
                    return;

                if (editor.IsDeleted)
                {
                    // Silme
                    customProfiles.Remove(oldName);
                    customDescriptions.Remove(oldName);
                    profile_comboBox.Items.Remove(oldName);
                }
                else
                {
                    // Güncelleme
                    string newName = editor.ProfileNameValue;
                    string newCmd = editor.ProfileCommandValue;
                    string newDesc = editor.ProfileDescriptionValue;

                    // Eğer isim değiştiyse ComboBox’ta da güncelle
                    if (newName != oldName)
                    {
                        int idx = profile_comboBox.Items.IndexOf(oldName);
                        profile_comboBox.Items[idx] = newName;
                        customProfiles.Remove(oldName);
                        customDescriptions.Remove(oldName);
                    }

                    // Yeni değerleri sözlüğe kaydet
                    customProfiles[newName] = newCmd;
                    customDescriptions[newName] = newDesc;
                    profile_comboBox.SelectedItem = newName;
                }
            }
        }

        // Nmap komutunu yeniler
        private void target_textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCommandDisplay();
        }
        // Nmap komutunu yeniler
        private void profile_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool manual = profile_comboBox.Text == "Manual scan";

            // Manual moddaysa kullanıcı müdahalesine izin verelim,
            // aksi halde otomatik doldursun ve salt-okunur yapsın:
            command_textBox.ReadOnly = !manual;

            // Seçim değişince komutu güncelle
            UpdateCommandDisplay();
        }

        private void UpdateCommandDisplay()
        {
            if (profile_comboBox.Text == "Manual scan")
            {
                // 'nmap ' önekiyle target'ı command'a yansıt
                command_textBox.Text = $"nmap {target_textBox.Text}";
                return;
            }

            // Önce custom Profiles sözlüğünde arayalım
            string profile = profile_comboBox.Text;
            string cmd = customProfiles.TryGetValue(profile, out var custom)
                           ? custom
                           : GetProfileCommand(profile);

            // Ardından target ekle
            command_textBox.Text = $"nmap {cmd} {target_textBox.Text}";

        }


        // 2) Seçileni kaldırmak
        private void btnRemoveScan_Click(object sender, EventArgs e)
        {
            if (scans_DataGridView.CurrentRow == null) return;
            var entry = (ScanEntry)scans_DataGridView.CurrentRow.DataBoundItem;
            scanList.Remove(entry);
        }

        // 3) Cancel Scan: 
        //    - Eğer o anda bir process çalışıyorsa durdursun.
        //    - İstersen, seçili satırın Status’ünü "Canceled" yapsın.
        private void btnCancelScan_Click(object sender, EventArgs e)
        {
            if (currentProcess != null && !currentProcess.HasExited)
            {
                currentProcess.Kill();
                currentProcess = null;
            }

            if (scans_DataGridView.CurrentRow != null)
            {
                var entry = (ScanEntry)scans_DataGridView.CurrentRow.DataBoundItem;
                entry.Status = "Canceled";
                scans_DataGridView.Refresh();
            }
        }

        private string GetProfileCommand(string profile)
        {
            // Önce custom profil var mı bak
            if (customProfiles.TryGetValue(profile, out var customCmd))
                return customCmd;

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
                case "Manual scan":
                    return "";
                default:
                    return "";
            }
        }

        private string GetProfileDescription(string profile)
        {
            switch (profile)
            {
                case "Intense scan":
                    return "Versiyon tespiti, OS tespiti, script taraması ve traceroute içeren yoğun tarama.";
                case "Intense scan plus UDP":
                    return "TCP yoğun taramaya UDP portlarını da ekler.";
                case "Intense scan, all TCP ports":
                    return "Tüm 1-65535 TCP portlarını versiyon bilgisiyle birlikte tarar.";
                case "Intense scan, no ping":
                    return "Yoğun tarama fakat host keşfi için ping atmaz (-Pn).";
                case "Ping scan":
                    return "Sadece host up/down bilgisini alır, port taramaz.";
                case "Quick scan":
                    return "İlk 100 porta hızlı tarama yapar (-F).";
                case "Quick scan plus":
                    return "Hızlı tarama + servis versiyonu ve OS tespiti.";
                case "Quick traceroute":
                    return "Ping scan + traceroute işlemi.";
                case "Regular scan":
                    return "Varsayılan 1000 porta tarama.";
                case "Slow comprehensive scan":
                    return "Uzun süreli, geniş kapsamlı script ve ping içeren tarama.";
                case "Manual scan":
                    return "Komut satırına tamamen kendi argümanlarınızı girin.";
                default:
                    return "";
            }
        }

        // Nmap komutunu cmd'den calistir ve ciktiyi goster.
        // async cunku anlik olarak ciktinin degismesini istiyoruz.
        private async void RunNmapScan()
        {
            if (profile_comboBox.Text != "Manual scan")
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
                currentProcess = process;  // Cancel butonu icin saklıyoruz

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

                // 3) Host Details tablosunu doldur
                PopulateHostDetails(ip, collectedOutput);

                var last = scanList.LastOrDefault(s => s.Command == command_textBox.Text.Trim());
                if (last != null)
                {
                    last.Status = "Done";
                    scans_DataGridView.Refresh();
                }

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
            output_richbox.Clear();
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

        private void PopulateHostDetails(string ip, string output)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, string>(PopulateHostDetails), ip, output);
                return;
            }

            // Temizle
            hostDetails_treeView.Nodes.Clear();

            // Kök düğüm: IP
            var root = new TreeNode(ip);

            // 1) Host Status
            var statusNode = new TreeNode("Host Status");

            // State
            string state = output.Contains("Host is up") ? "up" : "down";
            statusNode.Nodes.Add($"State: {state}");

            // Open, Filtered, Closed port sayıları
            var openRegex = new Regex(@"(\d+)\/(?:tcp|udp)\s+open", RegexOptions.IgnoreCase);
            var filteredRegex = new Regex(@"(\d+)\/(?:tcp|udp)\s+filtered", RegexOptions.IgnoreCase);
            var closedRegex = new Regex(@"Not shown:\s*(\d+)\s*closed ports", RegexOptions.IgnoreCase);

            int openCount = openRegex.Matches(output).Count;
            int filteredCount = filteredRegex.Matches(output).Count;
            int closedCount = 0;
            var mClosed = closedRegex.Match(output);
            if (mClosed.Success) closedCount = int.Parse(mClosed.Groups[1].Value);

            statusNode.Nodes.Add($"Open ports: {openCount}");
            statusNode.Nodes.Add($"Filtered ports: {filteredCount}");
            statusNode.Nodes.Add($"Closed ports: {closedCount}");
            statusNode.Nodes.Add($"Scanned ports: {openCount + filteredCount + closedCount}");

            // Up time & Last boot (metin çıktıda yoksa “Not available”)
            statusNode.Nodes.Add("Up time: Not available");
            statusNode.Nodes.Add("Last boot: Not available");

            root.Nodes.Add(statusNode);

            // 2) Addresses
            var addrNode = new TreeNode("Addresses");
            addrNode.Nodes.Add($"IPv4: {ip}");
            addrNode.Nodes.Add("IPv6: Not available");

            // MAC Address
            var macRegex = new Regex(@"MAC Address:\s*([0-9A-F:]+)", RegexOptions.IgnoreCase);
            var mMac = macRegex.Match(output);
            addrNode.Nodes.Add($"MAC: {(mMac.Success ? mMac.Groups[1].Value : "Not available")}");

            root.Nodes.Add(addrNode);

            // (İsteğe bağlı) Comments vb. ekleyebilirsiniz

            // Ağaca ekle ve hepsini aç
            hostDetails_treeView.Nodes.Add(root);
            hostDetails_treeView.ExpandAll();
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
            // 1) Mevcut komutu scanList'e ekle (aynı Append Scan logic'i)
            string cmd = command_textBox.Text.Trim();
            if (!string.IsNullOrEmpty(cmd))
            {
                scanList.Add(new ScanEntry
                {
                    Status = "Unsaved",
                    Command = cmd
                });
            }

            // taramayi baslat
            RunNmapScan();
        }
    }
}
