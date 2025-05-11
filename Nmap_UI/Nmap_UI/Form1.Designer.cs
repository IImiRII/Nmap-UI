namespace Nmap_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.output_TabControl = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.output_richbox = new System.Windows.Forms.RichTextBox();
            this.portsHosts_tabPage = new System.Windows.Forms.TabPage();
            this.portsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hostDetails_tabPage = new System.Windows.Forms.TabPage();
            this.hostDetails_treeView = new System.Windows.Forms.TreeView();
            this.scan_TabPage = new System.Windows.Forms.TabPage();
            this.btnCancelScan = new System.Windows.Forms.Button();
            this.btnRemoveScan = new System.Windows.Forms.Button();
            this.btnAppendScan = new System.Windows.Forms.Button();
            this.scans_DataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.os_host_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.target_panel = new System.Windows.Forms.Panel();
            this.profile_comboBox = new System.Windows.Forms.ComboBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.scan_button = new System.Windows.Forms.Button();
            this.target_textBox = new System.Windows.Forms.TextBox();
            this.command_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScanInThisWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllScansToDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchScanResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileOrCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel.SuspendLayout();
            this.output_TabControl.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.portsHosts_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portsDataGridView)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.hostDetails_tabPage.SuspendLayout();
            this.scan_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scans_DataGridView)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.target_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.output_TabControl);
            this.main_panel.Controls.Add(this.tabControl2);
            this.main_panel.Controls.Add(this.target_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 28);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(982, 525);
            this.main_panel.TabIndex = 6;
            // 
            // output_TabControl
            // 
            this.output_TabControl.Controls.Add(this.tabPage7);
            this.output_TabControl.Controls.Add(this.portsHosts_tabPage);
            this.output_TabControl.Controls.Add(this.tabPage9);
            this.output_TabControl.Controls.Add(this.hostDetails_tabPage);
            this.output_TabControl.Controls.Add(this.scan_TabPage);
            this.output_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_TabControl.Location = new System.Drawing.Point(200, 80);
            this.output_TabControl.Name = "output_TabControl";
            this.output_TabControl.SelectedIndex = 0;
            this.output_TabControl.Size = new System.Drawing.Size(782, 445);
            this.output_TabControl.TabIndex = 6;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textBox3);
            this.tabPage7.Controls.Add(this.output_richbox);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(774, 416);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Nmap Output";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(774, 22);
            this.textBox3.TabIndex = 7;
            // 
            // output_richbox
            // 
            this.output_richbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_richbox.Location = new System.Drawing.Point(0, 0);
            this.output_richbox.Name = "output_richbox";
            this.output_richbox.ReadOnly = true;
            this.output_richbox.Size = new System.Drawing.Size(774, 416);
            this.output_richbox.TabIndex = 0;
            this.output_richbox.Text = "";
            // 
            // portsHosts_tabPage
            // 
            this.portsHosts_tabPage.Controls.Add(this.portsDataGridView);
            this.portsHosts_tabPage.Controls.Add(this.label13);
            this.portsHosts_tabPage.Controls.Add(this.label12);
            this.portsHosts_tabPage.Controls.Add(this.label11);
            this.portsHosts_tabPage.Controls.Add(this.label10);
            this.portsHosts_tabPage.Controls.Add(this.label9);
            this.portsHosts_tabPage.Controls.Add(this.label8);
            this.portsHosts_tabPage.Controls.Add(this.label7);
            this.portsHosts_tabPage.Location = new System.Drawing.Point(4, 25);
            this.portsHosts_tabPage.Name = "portsHosts_tabPage";
            this.portsHosts_tabPage.Size = new System.Drawing.Size(774, 414);
            this.portsHosts_tabPage.TabIndex = 0;
            this.portsHosts_tabPage.Text = "Ports/Hosts";
            this.portsHosts_tabPage.UseVisualStyleBackColor = true;
            // 
            // portsDataGridView
            // 
            this.portsDataGridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.portsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.portsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.portsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.portsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.portsDataGridView.Name = "portsDataGridView";
            this.portsDataGridView.RowHeadersWidth = 51;
            this.portsDataGridView.RowTemplate.Height = 24;
            this.portsDataGridView.Size = new System.Drawing.Size(774, 414);
            this.portsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Host";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "O/C";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Port";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 105;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Protocol";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "State";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 105;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Service";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Version";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 105;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(382, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 26);
            this.label13.TabIndex = 9;
            this.label13.Text = "Version";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(317, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 26);
            this.label12.TabIndex = 8;
            this.label12.Text = "Service";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(252, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "State";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(174, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "Protocol";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(117, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Port";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(60, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "----";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Host";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button6);
            this.tabPage9.Controls.Add(this.button5);
            this.tabPage9.Controls.Add(this.button4);
            this.tabPage9.Controls.Add(this.button3);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(774, 414);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Topology";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(563, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 36);
            this.button6.TabIndex = 4;
            this.button6.Text = "Legend";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(621, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 36);
            this.button5.TabIndex = 3;
            this.button5.Text = "Save Graphic";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "Controls";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "Fish Eye";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Host Viewer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hostDetails_tabPage
            // 
            this.hostDetails_tabPage.Controls.Add(this.hostDetails_treeView);
            this.hostDetails_tabPage.Location = new System.Drawing.Point(4, 25);
            this.hostDetails_tabPage.Name = "hostDetails_tabPage";
            this.hostDetails_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hostDetails_tabPage.Size = new System.Drawing.Size(774, 414);
            this.hostDetails_tabPage.TabIndex = 2;
            this.hostDetails_tabPage.Text = "Host Details";
            this.hostDetails_tabPage.UseVisualStyleBackColor = true;
            // 
            // hostDetails_treeView
            // 
            this.hostDetails_treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostDetails_treeView.Location = new System.Drawing.Point(3, 3);
            this.hostDetails_treeView.Name = "hostDetails_treeView";
            this.hostDetails_treeView.Size = new System.Drawing.Size(768, 408);
            this.hostDetails_treeView.TabIndex = 0;
            // 
            // scan_TabPage
            // 
            this.scan_TabPage.Controls.Add(this.btnCancelScan);
            this.scan_TabPage.Controls.Add(this.btnRemoveScan);
            this.scan_TabPage.Controls.Add(this.btnAppendScan);
            this.scan_TabPage.Controls.Add(this.scans_DataGridView);
            this.scan_TabPage.Location = new System.Drawing.Point(4, 25);
            this.scan_TabPage.Name = "scan_TabPage";
            this.scan_TabPage.Size = new System.Drawing.Size(774, 414);
            this.scan_TabPage.TabIndex = 3;
            this.scan_TabPage.Text = "Scan";
            this.scan_TabPage.UseVisualStyleBackColor = true;
            // 
            // btnCancelScan
            // 
            this.btnCancelScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelScan.Location = new System.Drawing.Point(219, 372);
            this.btnCancelScan.Name = "btnCancelScan";
            this.btnCancelScan.Size = new System.Drawing.Size(102, 36);
            this.btnCancelScan.TabIndex = 11;
            this.btnCancelScan.Text = "Cancel Scan";
            this.btnCancelScan.UseVisualStyleBackColor = true;
            // 
            // btnRemoveScan
            // 
            this.btnRemoveScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveScan.Location = new System.Drawing.Point(111, 372);
            this.btnRemoveScan.Name = "btnRemoveScan";
            this.btnRemoveScan.Size = new System.Drawing.Size(102, 36);
            this.btnRemoveScan.TabIndex = 10;
            this.btnRemoveScan.Text = "Remove Scan";
            this.btnRemoveScan.UseVisualStyleBackColor = true;
            // 
            // btnAppendScan
            // 
            this.btnAppendScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAppendScan.Location = new System.Drawing.Point(3, 372);
            this.btnAppendScan.Name = "btnAppendScan";
            this.btnAppendScan.Size = new System.Drawing.Size(102, 36);
            this.btnAppendScan.TabIndex = 6;
            this.btnAppendScan.Text = "Append Scan";
            this.btnAppendScan.UseVisualStyleBackColor = true;
            // 
            // scans_DataGridView
            // 
            this.scans_DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scans_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scans_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scans_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.scans_DataGridView.Name = "scans_DataGridView";
            this.scans_DataGridView.RowHeadersWidth = 51;
            this.scans_DataGridView.RowTemplate.Height = 24;
            this.scans_DataGridView.Size = new System.Drawing.Size(774, 414);
            this.scans_DataGridView.TabIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(0, 80);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 445);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.os_host_flowLayoutPanel);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 416);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Hosts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // os_host_flowLayoutPanel
            // 
            this.os_host_flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.os_host_flowLayoutPanel.Location = new System.Drawing.Point(3, 38);
            this.os_host_flowLayoutPanel.Name = "os_host_flowLayoutPanel";
            this.os_host_flowLayoutPanel.Size = new System.Drawing.Size(186, 375);
            this.os_host_flowLayoutPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(66, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Host";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "OS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBox2);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(192, 414);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Services";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 41);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(180, 343);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Service";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // target_panel
            // 
            this.target_panel.Controls.Add(this.profile_comboBox);
            this.target_panel.Controls.Add(this.cancel_button);
            this.target_panel.Controls.Add(this.scan_button);
            this.target_panel.Controls.Add(this.target_textBox);
            this.target_panel.Controls.Add(this.command_textBox);
            this.target_panel.Controls.Add(this.label3);
            this.target_panel.Controls.Add(this.label2);
            this.target_panel.Controls.Add(this.label1);
            this.target_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.target_panel.Location = new System.Drawing.Point(0, 0);
            this.target_panel.Name = "target_panel";
            this.target_panel.Size = new System.Drawing.Size(982, 80);
            this.target_panel.TabIndex = 7;
            // 
            // profile_comboBox
            // 
            this.profile_comboBox.FormattingEnabled = true;
            this.profile_comboBox.Items.AddRange(new object[] {
            "Intense scan",
            "Intense scan plus UDP",
            "Intense scan, all TCP ports",
            "Intense scan, no ping",
            "Ping scan",
            "Quick scan",
            "Quick scan plus",
            "Quick traceroute",
            "Reguler scan",
            "Slow comprehensive scan",
            "Manual scan"});
            this.profile_comboBox.Location = new System.Drawing.Point(468, 14);
            this.profile_comboBox.Name = "profile_comboBox";
            this.profile_comboBox.Size = new System.Drawing.Size(319, 24);
            this.profile_comboBox.TabIndex = 7;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(857, 12);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(65, 27);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // scan_button
            // 
            this.scan_button.Location = new System.Drawing.Point(796, 12);
            this.scan_button.Name = "scan_button";
            this.scan_button.Size = new System.Drawing.Size(55, 27);
            this.scan_button.TabIndex = 3;
            this.scan_button.Text = "Scan";
            this.scan_button.UseVisualStyleBackColor = true;
            this.scan_button.Click += new System.EventHandler(this.scan_button_Click);
            // 
            // target_textBox
            // 
            this.target_textBox.Location = new System.Drawing.Point(89, 14);
            this.target_textBox.Name = "target_textBox";
            this.target_textBox.Size = new System.Drawing.Size(319, 22);
            this.target_textBox.TabIndex = 3;
            // 
            // command_textBox
            // 
            this.command_textBox.Location = new System.Drawing.Point(111, 43);
            this.command_textBox.Name = "command_textBox";
            this.command_textBox.Size = new System.Drawing.Size(811, 22);
            this.command_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.openScanToolStripMenuItem,
            this.openScanInThisWindowToolStripMenuItem,
            this.saveScanToolStripMenuItem,
            this.saveAllScansToDirectoryToolStripMenuItem,
            this.printToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.scanToolStripMenuItem.Text = "Scan";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.newWindowToolStripMenuItem.Text = "New Window";
            // 
            // openScanToolStripMenuItem
            // 
            this.openScanToolStripMenuItem.Name = "openScanToolStripMenuItem";
            this.openScanToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.openScanToolStripMenuItem.Text = "Open Scan";
            // 
            // openScanInThisWindowToolStripMenuItem
            // 
            this.openScanInThisWindowToolStripMenuItem.Name = "openScanInThisWindowToolStripMenuItem";
            this.openScanInThisWindowToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.openScanInThisWindowToolStripMenuItem.Text = "Open Scan in This Window";
            // 
            // saveScanToolStripMenuItem
            // 
            this.saveScanToolStripMenuItem.Name = "saveScanToolStripMenuItem";
            this.saveScanToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.saveScanToolStripMenuItem.Text = "Save Scan";
            // 
            // saveAllScansToDirectoryToolStripMenuItem
            // 
            this.saveAllScansToDirectoryToolStripMenuItem.Name = "saveAllScansToDirectoryToolStripMenuItem";
            this.saveAllScansToDirectoryToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.saveAllScansToDirectoryToolStripMenuItem.Text = "Save All Scans to Directory";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareResultsToolStripMenuItem,
            this.searchScanResultsToolStripMenuItem,
            this.filterHostsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // compareResultsToolStripMenuItem
            // 
            this.compareResultsToolStripMenuItem.Name = "compareResultsToolStripMenuItem";
            this.compareResultsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.compareResultsToolStripMenuItem.Text = "Compare Results";
            // 
            // searchScanResultsToolStripMenuItem
            // 
            this.searchScanResultsToolStripMenuItem.Name = "searchScanResultsToolStripMenuItem";
            this.searchScanResultsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.searchScanResultsToolStripMenuItem.Text = "Search Scan Results";
            // 
            // filterHostsToolStripMenuItem
            // 
            this.filterHostsToolStripMenuItem.Name = "filterHostsToolStripMenuItem";
            this.filterHostsToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.filterHostsToolStripMenuItem.Text = "Filter Hosts";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileOrCommandToolStripMenuItem,
            this.editSelectedProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // newProfileOrCommandToolStripMenuItem
            // 
            this.newProfileOrCommandToolStripMenuItem.Name = "newProfileOrCommandToolStripMenuItem";
            this.newProfileOrCommandToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.newProfileOrCommandToolStripMenuItem.Text = "New Profile or Command";
            // 
            // editSelectedProfileToolStripMenuItem
            // 
            this.editSelectedProfileToolStripMenuItem.Name = "editSelectedProfileToolStripMenuItem";
            this.editSelectedProfileToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.editSelectedProfileToolStripMenuItem.Text = "Edit Selected Profile";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.reportABugToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.reportABugToolStripMenuItem.Text = "Report a Bug";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.output_TabControl.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.portsHosts_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portsDataGridView)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.hostDetails_tabPage.ResumeLayout(false);
            this.scan_TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scans_DataGridView)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.target_panel.ResumeLayout(false);
            this.target_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.TabControl output_TabControl;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox output_richbox;
        private System.Windows.Forms.TabPage portsHosts_tabPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage hostDetails_tabPage;
        private System.Windows.Forms.TabPage scan_TabPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel target_panel;
        private System.Windows.Forms.ComboBox profile_comboBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button scan_button;
        private System.Windows.Forms.TextBox target_textBox;
        private System.Windows.Forms.TextBox command_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScanInThisWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllScansToDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchScanResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileOrCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAppendScan;
        private System.Windows.Forms.FlowLayoutPanel os_host_flowLayoutPanel;
        private System.Windows.Forms.DataGridView portsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TreeView hostDetails_treeView;
        private System.Windows.Forms.Button btnCancelScan;
        private System.Windows.Forms.Button btnRemoveScan;
        private System.Windows.Forms.DataGridView scans_DataGridView;
    }
}

