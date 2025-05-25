using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nmap_UI
{
    public partial class ProfileEditorFormDelete : Form
    {
        public string ProfileNameValue { get; private set; }
        public string ProfileDescriptionValue { get; private set; }
        public string ProfileCommandValue { get; private set; }
        public bool IsDeleted { get; private set; }

        public ProfileEditorFormDelete(string name, string desc, string cmd)
        {
            InitializeComponent();

            // Start‐up: doldur
            profileCmd_textBox.Text = cmd;
            profileName_textBox.Text = name;
            profileDesc_textBox.Text = desc;

            // Okuma durumu:
            profileCmd_textBox.ReadOnly = false;
            profileName_textBox.ReadOnly = false;
            profileDesc_textBox.ReadOnly = false;

            // Buton event'leri:
            profileSave_button.Click += ProfileSave_button_Click;
            profileCancel_button.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            profileDelete_button.Click += ProfileDelete_button_Click;
        }

        private void ProfileEditorFormDelete_Load(object sender, EventArgs e)
        {

        }

        private void ProfileSave_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(profileName_textBox.Text))
            {
                MessageBox.Show("Please enter a profile name.", "Validation",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProfileNameValue = profileName_textBox.Text.Trim();
            ProfileDescriptionValue = profileDesc_textBox.Text.Trim();
            ProfileCommandValue = profileCmd_textBox.Text.Trim();
            IsDeleted = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProfileDelete_button_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                $"Are you sure you want to delete profile “{profileName_textBox.Text}”?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                IsDeleted = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
