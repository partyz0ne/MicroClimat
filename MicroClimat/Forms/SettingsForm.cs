using System;
using System.Windows.Forms;
using MicroClimat.Classes;
using MicroClimat.Properties;

namespace MicroClimat.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            txtLogPath.Text = Settings.Default.LogPath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.LogPath = txtLogPath.Text;
            Settings.Default.Save();
            CLogger.Open();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtLogPath.Text = fbd.SelectedPath;
        }
    }
}
