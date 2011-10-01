using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MicroClimat.Classes;
using System.IO;

namespace MicroClimat.Forms
{
    public partial class CreateProjectWizard : Form
    {
        String _strPath = String.Empty;
        String _strPrName = String.Empty;
        String _strManager = String.Empty;
        readonly List<String> _lstMembers = new List<string>();
        readonly List<bool> _lstGadgets = new List<bool>(4);
        readonly MainForm _mParent;

        public CreateProjectWizard(MainForm parent)
        {
            if (Parent == null) throw new ArgumentNullException("Parent");
            InitializeComponent();
            wizard1.BackText = "< &Назад";
            wizard1.NextText = "&Далее >";
            wizard1.CancelText = "&Отмена";
            txtPathToFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            _mParent = parent;
        }

        private void BtnBrowseClick(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                txtPathToFile.Text = fbd.SelectedPath;
        }

        private void CheckData(object sender, CristiPotlog.Controls.Wizard.BeforeSwitchPagesEventArgs e)
        {
            if (e.NewIndex > e.OldIndex)
            {
                switch (e.OldIndex)
                {
                    case 0:
                        if (txtPathToFile.Text == string.Empty)
                        {
                            MessageBox.Show(@"Выберите путь к файлу проекта.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        else
                        {
                            if (txtProjectName.Text == String.Empty)
                            {
                                MessageBox.Show(@"Укажите имя создаваемого проекта.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                e.Cancel = true;
                            }
                            else
                            {
                                _strPath = txtPathToFile.Text + Path.DirectorySeparatorChar + txtProjectName.Text + ".mcp";
                            }
                        }
                        break;
                    case 1:
                        if (txtManager.Text == string.Empty)
                        {
                            MessageBox.Show(@"Введите данные руководителя проекта.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        else
                        {
                            _strManager = txtManager.Text;
                            int nCnt = dgvParts.Rows.Count - 1;
                            for (int i = 0; i < nCnt; i++)
                                if (dgvParts.Rows[i].Cells[0].Value != null)
                                    _lstMembers.Add(dgvParts.Rows[i].Cells[0].Value.ToString());
                            if (_lstMembers.Count == 0)
                            {
                                MessageBox.Show(@"Введите хотя бы одного участника проекта.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                e.Cancel = true;
                            }
                        }
                        break;
                    case 2:
                        _lstGadgets.Add(chbBarometr.Checked);
                        _lstGadgets.Add(chbPsixrometr.Checked);
                        _lstGadgets.Add(chbTermometr.Enabled && chbTermometr.Checked);
                        _lstGadgets.Add(chbAnemometr.Checked);
                        bool bCont = false;
                        for (int i = 0; i < 4; i++)
                            if (_lstGadgets[i])
                                bCont = true;
                        if (!bCont)
                        {
                            MessageBox.Show(@"Выберите используемые в проекте приборы.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                        }
                        break;
                }
            }
        }

        private void FinishCreate(object sender, EventArgs e)
        {
            var workspace = new CWorkspace(_strPath)
                                {Manager = _strManager, Members = _lstMembers, Gadgets = _lstGadgets};
            //            Project.Place = txtPlace.Text;
            _mParent.Workspace = workspace;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TxtPathToFileTextChanged(object sender, EventArgs e)
        {
            chbChangeName.Enabled = txtPathToFile.Text != String.Empty;
        }

        private void ChbChangeNameCheckedChanged(object sender, EventArgs e)
        {
            if (chbChangeName.Checked)
            {
                _strPrName = txtProjectName.Text;
                String strDate = DateTime.Today.ToShortDateString();
                txtProjectName.Text = strDate;
            }
            else
            {
                txtProjectName.Text = _strPrName;
            }
        }

        private void ChbPsixrometrCheckedChanged(object sender, EventArgs e)
        {
            chbTermometr.Enabled = !chbPsixrometr.Checked;
            if (chbPsixrometr.Checked)
                lblTermTip.Text = @"Внимание!\r\n" +
                                    @"Если Вы используете психрометр,\r\n" +
                                    @"значения темпаратуры воздуха будут\r\n" +
                                    @"определяться по сухому термометру психрометра.";
            else
                lblTermTip.Text = String.Empty;
        }

        private void CheckButtons(object sender, CristiPotlog.Controls.Wizard.AfterSwitchPagesEventArgs e)
        {
            if (e.NewIndex == 3)
            {
                wizard1.BackEnabled = true;
                wizard1.CancelText = "&Завершить";
            }
        }
    }
}
