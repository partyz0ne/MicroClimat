using System;
using System.Windows.Forms;

namespace MicroClimat.Forms
{
    public partial class AddMemberForm : Form
    {
        String _strMember = String.Empty;
        public String Member    { get { return _strMember; } }
        public String ButtonText { set { btnOK.Text = value; } }

        public AddMemberForm(String strName)
        {
            InitializeComponent();
            if (strName != String.Empty)
                txtMember.Text = strName;
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            if (txtMember.Text != String.Empty)
            {
                _strMember = txtMember.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
