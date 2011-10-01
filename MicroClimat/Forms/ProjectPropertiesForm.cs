using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MicroClimat.Properties;

namespace MicroClimat.Forms
{
    public partial class ProjectPropertiesForm : Form
    {
        readonly MainForm _mParentForm;
        bool _bChanged;
        public ProjectPropertiesForm(MainForm parent)
        {
            if (parent == null)
                throw new ArgumentNullException("Parent");
            InitializeComponent();
            _mParentForm = parent;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            var lstMembers = new List<String>();
            for (int i = 0; i < dgvParts.RowCount; i++)
                if (dgvParts.Rows[i].Cells[0].Value != null)
                    lstMembers.Add(dgvParts.Rows[i].Cells[0].Value.ToString());
            if (lstMembers.Count != 0)
            {
                var lstGadgets = new List<bool>(4)
                                     {
                                         chbBarometr.Checked,
                                         chbPsixrometr.Checked,
                                         chbTermometr.Enabled && chbTermometr.Checked,
                                         chbAnemometr.Checked
                                     };

                bool bCont = false;
                for (int i = 0; i < 4; i++)
                    if (lstGadgets[i])
                        bCont = true;
                if (!bCont)
                {
                    MessageBox.Show(@"Выберите используемые в проекте приборы.", Resources.MsgBoxExclamation_Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControl1.SelectedTab = tabPageGadgets;
                }
                else
                {
                    _mParentForm.Workspace.Gadgets = lstGadgets;
                    _mParentForm.Workspace.Members = lstMembers;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                tabControl1.SelectedTab = tabPageMembers;
                MessageBox.Show(@"Введите участников проекта.", Resources.MsgBoxExclamation_Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MembersFormLoad(object sender, EventArgs e)
        {
            txtManager.Text = _mParentForm.Workspace.Manager;
            List<String> lstMembers = _mParentForm.Workspace.Members;
            foreach (string t in lstMembers)
                if (t != null) dgvParts.Rows.Add(t);
            List<bool> lstGadgets = _mParentForm.Workspace.Gadgets;
            if (lstGadgets.Count == 4)
            {
                chbBarometr.Checked = lstGadgets[0];
                chbPsixrometr.Checked = lstGadgets[1];
                chbTermometr.Enabled = !lstGadgets[1];
                chbTermometr.Checked = lstGadgets[2];
                chbAnemometr.Checked = lstGadgets[3];
            }
            else
            {
                chbBarometr.Enabled =
                    chbPsixrometr.Enabled =
                    chbTermometr.Enabled =
                    chbAnemometr.Enabled = false;
            }
            btnSave.Enabled = false;
        }

        private void ChbPsixrometrCheckedChanged(object sender, EventArgs e)
        {
            OnDataChanged(sender, e);
            chbTermometr.Enabled = !chbPsixrometr.Checked;
            if (chbPsixrometr.Checked)
                lblTermTip.Text = @"Внимание!\r\n" +
                                    @"Если Вы используете психрометр,\r\n" +
                                    @"значения темпаратуры воздуха будут\r\n" +
                                    @"определяться по сухому термометру психрометра.";
            else
                lblTermTip.Text = String.Empty;
        }

        private void OnDataChanged(object sender, EventArgs e)
        {
            if (!_bChanged)
                _bChanged = true;
            btnSave.Enabled = _bChanged;
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            btnDeleteMember.Enabled = (dgvParts.SelectedRows.Count > 0);
            btnEditMember.Enabled = (dgvParts.SelectedRows.Count == 1);
        }

        private void BtnAddMemberClick(object sender, EventArgs e)
        {
            AddMemberForm amf = new AddMemberForm(String.Empty);
            if (amf.ShowDialog() == DialogResult.OK)
                dgvParts.Rows.Add(amf.Member);
        }

        private void BtnDeleteMemberClick(object sender, EventArgs e)
        {
            if (_mParentForm.Workspace.IsMemberActive(dgvParts.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show(@"Пользователь " + dgvParts.SelectedRows[0].Cells[0].Value + @" является активным пользователем проекта. Его удаление невозможно.", Resources.MsgBoxExclamation_Warning, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(@"Удалить выбранных участников из проекта?", Resources.MsgBoxExclamation_Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvParts.SelectedRows.Count; i++)
                    dgvParts.Rows.Remove(dgvParts.SelectedRows[i]);
                dgvParts.Refresh();
            }

        }

        private void BtnEditMemberClick(object sender, EventArgs e)
        {
            if (_mParentForm.Workspace.IsMemberActive(dgvParts.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show(@"Пользователь " + dgvParts.SelectedRows[0].Cells[0].Value + @" является активным пользователем проекта. Его правка невозможна.", Resources.MsgBoxExclamation_Warning, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var amf = new AddMemberForm(dgvParts.SelectedRows[0].Cells[0].Value.ToString()) {ButtonText = "&Изменить"};
            if (amf.ShowDialog() == DialogResult.OK)
                dgvParts.SelectedRows[0].Cells[0].Value = amf.Member;
        }

        private void DgvChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            OnDataChanged(sender, e);
        }

        private void DgvChanged(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            OnDataChanged(sender, e);
        }

        private void DgvChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnDataChanged(sender, e);
        }
    }
}
