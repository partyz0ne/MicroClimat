using System;
using System.Windows.Forms;

namespace MicroClimat.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutFormLoad(object sender, EventArgs e)
        {
            lblVersion.Text += Application.ProductVersion;
        }

        private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var proc = new System.Diagnostics.Process
                               {StartInfo = {FileName = "mailto:" + linkLabel1.Text, UseShellExecute = true}};
                proc.Start();
            }
        }

        private void КопироватьАдресToolStripMenuItemClick(object sender, EventArgs e)
        {
            Clipboard.SetText(linkLabel1.Text);
        }
    }
}
