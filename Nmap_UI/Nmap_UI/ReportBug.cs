using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nmap_UI
{
    public partial class ReportBug : Form
    {
        public ReportBug()
        {
            InitializeComponent();
        }

        private void ReportBug_Load(object sender, EventArgs e)
        {
            // formu buyutup kucultmesin
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            helpRichTextBox.Clear();
            helpRichTextBox.ReadOnly = true;
            helpRichTextBox.DetectUrls = true;

            // Başlık
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            helpRichTextBox.AppendText("How to report a bug\n\n");

            // Paragraf 1 - normal metin + link
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.AppendText("Like their author, Nmap and Zenmap aren't perfect. But you can help make it better by sending bug reports or even writing patches. If Nmap doesn't behave the way you expect, first upgrade to the latest version available from ");

            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.AppendText("https://nmap.org.\n");

            // Paragraf 2
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("If the problem persists, do some research to determine whether it has already been discovered and addressed. Try Googling the error message or browsing the nmap-dev archives at ");

            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.AppendText("https://seclists.org.\n");

            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("Read the full manual page as well. If nothing comes of this, open a bug report at ");

            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.AppendText("https://issues.nmap.org.\n\n");

            // Paragraf 3
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("Please include everything you have learned about the problem, as well as what version of Nmap you are running and what operating system version it is running on.\n\n");

            // Paragraf 4 - link içerir
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("Code patches to fix bugs are even better than bug reports. Basic instructions for creating patch files with your changes are available at ");

            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.AppendText("https://nmap.org/data/HACKING");
        }
    }
}
