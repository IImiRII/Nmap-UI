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

namespace Nmap_UI
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            // formu buyutup kucultmesin
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            helpRichTextBox.Clear();
            helpRichTextBox.ReadOnly = true;
            helpRichTextBox.DetectUrls = true;

            // 1. Normal metin
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("Nmap is documented extensively online. Zenmap documentation exists and is improving. You can find it all at the ");

            // 2. Link 1
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.AppendText("https://nmap.org/book/man.html");

            // 3. Devam eden metin
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.AppendText(". Further information is available from the ");

            // 4. Link 2
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.AppendText("https://github.com/IImiRII/Nmap-UI");

            // 5. Normal metin
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.AppendText(" itself.\n\n");

            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("On Unix, you can also run ");

            // 6. Kalın "man nmap"
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            helpRichTextBox.AppendText("man nmap");

            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText(" and ");

            // 7. Kalın "man zenmap"
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            helpRichTextBox.AppendText("man zenmap");

            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText(" to learn about your installed Nmap version, though the ");

            // 8. Link 3
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Underline);
            helpRichTextBox.SelectionColor = Color.Blue;
            helpRichTextBox.AppendText("https://nmap.org/docs");

            // 9. Kalan cümle
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.SelectionColor = Color.Black;
            helpRichTextBox.AppendText(" are more comprehensive and always up-to-date.\n\n");

            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            helpRichTextBox.AppendText("For quick reference to the most popular Nmap command-line arguments, run ");

            // 10. Kalın komut
            helpRichTextBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            helpRichTextBox.AppendText("nmap -h.");
        }

        private void helpRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
        }
    }
}
