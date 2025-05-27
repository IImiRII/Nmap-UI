namespace Nmap_UI
{
    partial class AboutForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkNmap = new System.Windows.Forms.LinkLabel();
            this.linkEyemap = new System.Windows.Forms.LinkLabel();
            this.btnCloseAbout = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nmap";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(35, 163);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(113, 29);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Eyemap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nmap is a free and open source utility for network exploration and security audit" +
    "ing.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eyemap is a multi-platform graphical Nmap frontend and results viewer.";
            // 
            // linkNmap
            // 
            this.linkNmap.AutoSize = true;
            this.linkNmap.Location = new System.Drawing.Point(171, 90);
            this.linkNmap.Name = "linkNmap";
            this.linkNmap.Size = new System.Drawing.Size(103, 16);
            this.linkNmap.TabIndex = 4;
            this.linkNmap.TabStop = true;
            this.linkNmap.Text = "https://nmap.org";
            // 
            // linkEyemap
            // 
            this.linkEyemap.AutoSize = true;
            this.linkEyemap.Location = new System.Drawing.Point(171, 174);
            this.linkEyemap.Name = "linkEyemap";
            this.linkEyemap.Size = new System.Drawing.Size(209, 16);
            this.linkEyemap.TabIndex = 5;
            this.linkEyemap.TabStop = true;
            this.linkEyemap.Text = "https://github.com/IImiRII/Nmap-UI";
            // 
            // btnCloseAbout
            // 
            this.btnCloseAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAbout.Location = new System.Drawing.Point(575, 269);
            this.btnCloseAbout.Name = "btnCloseAbout";
            this.btnCloseAbout.Size = new System.Drawing.Size(91, 35);
            this.btnCloseAbout.TabIndex = 6;
            this.btnCloseAbout.Text = "Close";
            this.btnCloseAbout.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(298, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(159, 29);
            this.Title.TabIndex = 7;
            this.Title.Text = "Eyemap 1.0";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 324);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnCloseAbout);
            this.Controls.Add(this.linkEyemap);
            this.Controls.Add(this.linkNmap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkNmap;
        private System.Windows.Forms.LinkLabel linkEyemap;
        private System.Windows.Forms.Button btnCloseAbout;
        private System.Windows.Forms.Label Title;
    }
}