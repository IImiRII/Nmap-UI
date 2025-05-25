namespace Nmap_UI
{
    partial class ProfileEditorForm
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
            this.command_panel = new System.Windows.Forms.Panel();
            this.profileCmd_textBox = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.profileTabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.profileCancel_button = new System.Windows.Forms.Button();
            this.profileSave_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help_richTextBox = new System.Windows.Forms.RichTextBox();
            this.profileDesc_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profileName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scanTabPage = new System.Windows.Forms.TabPage();
            this.pingTabPage = new System.Windows.Forms.TabPage();
            this.scriptingTabPage = new System.Windows.Forms.TabPage();
            this.targetTabPage = new System.Windows.Forms.TabPage();
            this.sourceTabPage = new System.Windows.Forms.TabPage();
            this.otherTabPage = new System.Windows.Forms.TabPage();
            this.timingTabPage = new System.Windows.Forms.TabPage();
            this.command_panel.SuspendLayout();
            this.panel.SuspendLayout();
            this.profileTabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // command_panel
            // 
            this.command_panel.Controls.Add(this.profileCmd_textBox);
            this.command_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.command_panel.Location = new System.Drawing.Point(0, 0);
            this.command_panel.Name = "command_panel";
            this.command_panel.Size = new System.Drawing.Size(582, 30);
            this.command_panel.TabIndex = 0;
            // 
            // profileCmd_textBox
            // 
            this.profileCmd_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileCmd_textBox.Location = new System.Drawing.Point(0, 0);
            this.profileCmd_textBox.Name = "profileCmd_textBox";
            this.profileCmd_textBox.Size = new System.Drawing.Size(582, 22);
            this.profileCmd_textBox.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.profileTabControl);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(582, 423);
            this.panel.TabIndex = 1;
            // 
            // profileTabControl
            // 
            this.profileTabControl.Controls.Add(this.profileTabPage);
            this.profileTabControl.Controls.Add(this.scanTabPage);
            this.profileTabControl.Controls.Add(this.pingTabPage);
            this.profileTabControl.Controls.Add(this.scriptingTabPage);
            this.profileTabControl.Controls.Add(this.targetTabPage);
            this.profileTabControl.Controls.Add(this.sourceTabPage);
            this.profileTabControl.Controls.Add(this.otherTabPage);
            this.profileTabControl.Controls.Add(this.timingTabPage);
            this.profileTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileTabControl.Location = new System.Drawing.Point(0, 0);
            this.profileTabControl.Name = "profileTabControl";
            this.profileTabControl.SelectedIndex = 0;
            this.profileTabControl.Size = new System.Drawing.Size(582, 423);
            this.profileTabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.bottom_panel);
            this.profileTabPage.Controls.Add(this.panel1);
            this.profileTabPage.Controls.Add(this.profileDesc_textBox);
            this.profileTabPage.Controls.Add(this.label3);
            this.profileTabPage.Controls.Add(this.profileName_textBox);
            this.profileTabPage.Controls.Add(this.label2);
            this.profileTabPage.Controls.Add(this.label1);
            this.profileTabPage.Location = new System.Drawing.Point(4, 25);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(574, 394);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            this.profileTabPage.Click += new System.EventHandler(this.profileTabPage_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.Controls.Add(this.profileCancel_button);
            this.bottom_panel.Controls.Add(this.profileSave_button);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(3, 351);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(418, 40);
            this.bottom_panel.TabIndex = 6;
            // 
            // profileCancel_button
            // 
            this.profileCancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profileCancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.profileCancel_button.Location = new System.Drawing.Point(222, 12);
            this.profileCancel_button.Name = "profileCancel_button";
            this.profileCancel_button.Size = new System.Drawing.Size(75, 23);
            this.profileCancel_button.TabIndex = 1;
            this.profileCancel_button.Text = "Cancel";
            this.profileCancel_button.UseVisualStyleBackColor = true;
            // 
            // profileSave_button
            // 
            this.profileSave_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.profileSave_button.Location = new System.Drawing.Point(303, 12);
            this.profileSave_button.Name = "profileSave_button";
            this.profileSave_button.Size = new System.Drawing.Size(109, 23);
            this.profileSave_button.TabIndex = 0;
            this.profileSave_button.Text = "Save Changes";
            this.profileSave_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.help_richTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(421, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 388);
            this.panel1.TabIndex = 5;
            // 
            // help_richTextBox
            // 
            this.help_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.help_richTextBox.Location = new System.Drawing.Point(0, 0);
            this.help_richTextBox.Name = "help_richTextBox";
            this.help_richTextBox.ReadOnly = true;
            this.help_richTextBox.Size = new System.Drawing.Size(148, 386);
            this.help_richTextBox.TabIndex = 0;
            this.help_richTextBox.Text = "";
            // 
            // profileDesc_textBox
            // 
            this.profileDesc_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileDesc_textBox.Location = new System.Drawing.Point(106, 113);
            this.profileDesc_textBox.Name = "profileDesc_textBox";
            this.profileDesc_textBox.Size = new System.Drawing.Size(309, 22);
            this.profileDesc_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // profileName_textBox
            // 
            this.profileName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileName_textBox.Location = new System.Drawing.Point(106, 62);
            this.profileName_textBox.Name = "profileName_textBox";
            this.profileName_textBox.Size = new System.Drawing.Size(309, 22);
            this.profileName_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profile Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Name";
            // 
            // scanTabPage
            // 
            this.scanTabPage.Location = new System.Drawing.Point(4, 25);
            this.scanTabPage.Name = "scanTabPage";
            this.scanTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scanTabPage.Size = new System.Drawing.Size(574, 394);
            this.scanTabPage.TabIndex = 1;
            this.scanTabPage.Text = "Scan";
            this.scanTabPage.UseVisualStyleBackColor = true;
            // 
            // pingTabPage
            // 
            this.pingTabPage.Location = new System.Drawing.Point(4, 25);
            this.pingTabPage.Name = "pingTabPage";
            this.pingTabPage.Size = new System.Drawing.Size(574, 394);
            this.pingTabPage.TabIndex = 2;
            this.pingTabPage.Text = "Ping";
            this.pingTabPage.UseVisualStyleBackColor = true;
            // 
            // scriptingTabPage
            // 
            this.scriptingTabPage.Location = new System.Drawing.Point(4, 25);
            this.scriptingTabPage.Name = "scriptingTabPage";
            this.scriptingTabPage.Size = new System.Drawing.Size(574, 394);
            this.scriptingTabPage.TabIndex = 3;
            this.scriptingTabPage.Text = "Scripting";
            this.scriptingTabPage.UseVisualStyleBackColor = true;
            // 
            // targetTabPage
            // 
            this.targetTabPage.Location = new System.Drawing.Point(4, 25);
            this.targetTabPage.Name = "targetTabPage";
            this.targetTabPage.Size = new System.Drawing.Size(574, 394);
            this.targetTabPage.TabIndex = 4;
            this.targetTabPage.Text = "Target";
            this.targetTabPage.UseVisualStyleBackColor = true;
            // 
            // sourceTabPage
            // 
            this.sourceTabPage.Location = new System.Drawing.Point(4, 25);
            this.sourceTabPage.Name = "sourceTabPage";
            this.sourceTabPage.Size = new System.Drawing.Size(574, 394);
            this.sourceTabPage.TabIndex = 5;
            this.sourceTabPage.Text = "Source";
            this.sourceTabPage.UseVisualStyleBackColor = true;
            // 
            // otherTabPage
            // 
            this.otherTabPage.Location = new System.Drawing.Point(4, 25);
            this.otherTabPage.Name = "otherTabPage";
            this.otherTabPage.Size = new System.Drawing.Size(574, 394);
            this.otherTabPage.TabIndex = 6;
            this.otherTabPage.Text = "Other";
            this.otherTabPage.UseVisualStyleBackColor = true;
            // 
            // timingTabPage
            // 
            this.timingTabPage.Location = new System.Drawing.Point(4, 25);
            this.timingTabPage.Name = "timingTabPage";
            this.timingTabPage.Size = new System.Drawing.Size(574, 394);
            this.timingTabPage.TabIndex = 7;
            this.timingTabPage.Text = "Timing";
            this.timingTabPage.UseVisualStyleBackColor = true;
            // 
            // ProfileEditorForm
            // 
            this.AcceptButton = this.profileSave_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.profileCancel_button;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.command_panel);
            this.Name = "ProfileEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Editor";
            this.command_panel.ResumeLayout(false);
            this.command_panel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.profileTabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            this.bottom_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel command_panel;
        private System.Windows.Forms.TextBox profileCmd_textBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabControl profileTabControl;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.TabPage scanTabPage;
        private System.Windows.Forms.TextBox profileName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pingTabPage;
        private System.Windows.Forms.TabPage scriptingTabPage;
        private System.Windows.Forms.TabPage targetTabPage;
        private System.Windows.Forms.TabPage sourceTabPage;
        private System.Windows.Forms.TabPage otherTabPage;
        private System.Windows.Forms.TabPage timingTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox profileDesc_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox help_richTextBox;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button profileCancel_button;
        private System.Windows.Forms.Button profileSave_button;
    }
}