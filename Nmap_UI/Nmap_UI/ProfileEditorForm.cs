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
    public partial class ProfileEditorForm : Form
    {
        public string ProfileNameValue { get; private set; }
        public string ProfileDescriptionValue { get; private set; }
        public string ProfileCommandValue { get; private set; }
        public ProfileEditorForm()
        {
            InitializeComponent();

            //profileCmd_textBox.Text = "nmap ";

            // 2) Buton event'leri
            profileSave_button.Click += ProfileSave_button_Click;
            profileCancel_button.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void ProfileSave_button_Click(object sender, EventArgs e)
        {
            // Gerekli minimum kontrol: profil adı olmalı
            if (string.IsNullOrWhiteSpace(profileName_textBox.Text))
            {
                MessageBox.Show("Please enter a profile name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcının girdilerini property'lere aktar
            ProfileNameValue = profileName_textBox.Text.Trim();
            ProfileDescriptionValue = profileDesc_textBox.Text.Trim();
            ProfileCommandValue = profileCmd_textBox.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void profileTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
