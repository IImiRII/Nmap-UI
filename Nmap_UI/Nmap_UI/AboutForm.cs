using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nmap_UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            linkNmap.LinkClicked += (s, e) => Process.Start(new ProcessStartInfo("https://nmap.org") { UseShellExecute = true });
            linkEyemap.LinkClicked += (s, e) => Process.Start(new ProcessStartInfo("https://github.com/IImiRII/Nmap-UI") { UseShellExecute = true });
            btnCloseAbout.Click += (s, e) => this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            // formu buyutup kucultmesin
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
