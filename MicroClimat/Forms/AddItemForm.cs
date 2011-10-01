using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MicroClimat.Classes;

namespace MicroClimat.Forms
{
    /// <summary>
    /// Класс окна добавления данных в проект.
    /// </summary>
    public partial class AddItemForm : Form
    {
        readonly CTables _tables = new CTables();
        bool _bPressureType;
        readonly MainForm _formParent;
        readonly bool _bEditMode;
        readonly List<bool> _bGadgets;

        /// <summary>
        /// Конструктор окна.
        /// </summary>
        /// <param name="formParent">Родительское окно.</param>
        /// <param name="bEditItem">Параметр редактирования данных.</param>
        public AddItemForm(MainForm formParent, bool bEditItem)
        {
            InitializeComponent();
            _formParent = formParent;
            _bEditMode = bEditItem;
            _bGadgets = _formParent.Workspace.Gadgets;
            foreach (string t in _formParent.Workspace.Members)
                chbListOnDuty.Items.Add(t);

            chbBarometr.Enabled = chbBarometr.Checked = _bGadgets[0];
            chbPsixrometr.Enabled = chbPsixrometr.Checked = _bGadgets[1];
            chbTermometr.Enabled = chbTermometr.Checked = _bGadgets[2];
            chbAnemometr.Enabled = chbAnemometr.Checked = _bGadgets[3];
            
            if (_bEditMode)
                InitializeData();
            else
            {
                dtDate.Value = DateTime.Now;
                dtTime.Value = DateTime.Now;
            }
        }

        private void InitializeData()
        {
            btnAdd.Text = @"Сохранить";
            ClimatData stData = _formParent.CurData;
            {
                txtPressureMM.Text = stData.Pressure.ToString();
                txtPressureBar.Text = (stData.Pressure * Utils.MMtoBar).ToString();
                nudTempDry.Value = (decimal)stData.TempDry;
                nudTempWet.Value = (decimal)stData.TempWet;
                chbIce.Checked = stData.Ice;
                txtResHum.Text = stData.Humidity.ToString();
                txtResSat.Text = stData.Saturation.ToString();
                nudTemp.Value = (decimal)stData.TempDry;
                nudWindSpeed.Value = (decimal)stData.WindSpeed;
                cmbWindDirect.SelectedIndex = stData.WindDirect;
            }

            String strOnDuty = _formParent.CurData.Duty;
            String[] strDuty = strOnDuty.Split(',');
            for (int i = 0; i < strDuty.Length; i++)
            {
                strDuty[i] = strDuty[i].Trim();
                for (int j = 0; j < chbListOnDuty.Items.Count; j++)
                {
                    if (strDuty[i] == chbListOnDuty.Items[j].ToString())
                    {
                        chbListOnDuty.SetItemChecked(j, true);
                        break;
                    }
                }
            }

            dtDate.Value = stData.Date;
            dtTime.Value = stData.Date;
        }

        private void RbTypeStationCheckedChanged(object sender, EventArgs e)
        {
            _tables.ChangePsyType(true);
        }

        private void RbTypeAspirCheckedChanged(object sender, EventArgs e)
        {
            _tables.ChangePsyType(false);
        }

        private void ChbIceCheckedChanged(object sender, EventArgs e)
        {
            _tables.Ice = chbIce.Checked;
        }

        private void PressureCheckedChanged(object sender, EventArgs e)
        {
            _bPressureType = rbBar.Checked;
            txtPressureBar.Enabled = _bPressureType;
            txtPressureMM.Enabled = !_bPressureType;
        }

        private void BtnCalcClick(object sender, EventArgs e)
        {
            var dblDry = (double)nudTempDry.Value;
            var dblWet = (double)nudTempWet.Value;
            double dblPres;
            if (!double.TryParse(txtPressureBar.Text, out dblPres))
                return;
            _tables.TempDry = dblDry;
            _tables.TempWet = dblWet;
            _tables.Pressure = dblPres;
            _tables.ChangePsyType(false);
            if (_tables.Calculate())
            {
                txtResHum.Text = _tables.Humidity.ToString();
                txtResSat.Text = _tables.Saturation.ToString();
                btnAdd.Enabled = true;
            }
        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (chbListOnDuty.CheckedItems.Count > 0)
            {
                var stData = new ClimatData();
                DateTime dtItemDate = dtDate.Value;
                DateTime dtItemTime = dtTime.Value;
                var dt = new DateTime(dtItemDate.Year, dtItemDate.Month, dtItemDate.Day, dtItemTime.Hour, dtItemTime.Minute, 0);
                stData.Date = dt;

                stData.Index = _bEditMode ? _formParent.CurData.Index : _formParent.Workspace.NewIndex();

                if (btnCalc.Enabled)
                    BtnCalcClick(sender, e);

                double dblTempOut;
                if (!Utils.SafeParseDouble(txtPressureMM.Text, out dblTempOut))
                {
                    ShowParseError(1); return;
                }
                stData.Pressure = dblTempOut;
                if (!Utils.SafeParseDouble(txtResHum.Text, out dblTempOut))
                {
                    ShowParseError(2); return;
                }
                stData.Humidity = dblTempOut;
                if (!Utils.SafeParseDouble(txtResSat.Text, out dblTempOut))
                {
                    ShowParseError(2); return;
                }
                stData.Saturation = dblTempOut;
                stData.TempDry = (double)nudTempDry.Value;
                stData.TempWet = (double)nudTempWet.Value;
                stData.Ice = chbIce.Checked;
                if (chbTermometr.Checked)
                    stData.TempDry = (double)nudTemp.Value;
                stData.WindSpeed = (double)nudWindSpeed.Value;

                if (chbAnemometr.Checked)
                    stData.WindDirect = cmbWindDirect.SelectedIndex;
                else
                    stData.WindDirect = -1;

                int i;
                for (i = 0; i < chbListOnDuty.CheckedItems.Count - 1; i++)
                    stData.Duty += chbListOnDuty.CheckedItems[i] + ", ";
                stData.Duty += chbListOnDuty.CheckedItems[i].ToString();
                _formParent.CurData = stData;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(@"Выберите дежурных, сделавших наблюдение.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RecalcPresuure(object sender, EventArgs e)
        {
            double dblPres;
            if (_bPressureType)
            {
                if (!Utils.SafeParseDouble(txtPressureBar.Text, out dblPres))
                {
                    ShowParseError(1); return;
                }
                dblPres = dblPres * Utils.BartoMm;
                txtPressureMM.Text = dblPres.ToString();
            }
            else
            {
                if (!Utils.SafeParseDouble(txtPressureMM.Text, out dblPres))
                {
                    ShowParseError(1); return;
                }
                dblPres = dblPres * Utils.MMtoBar;
                txtPressureBar.Text = dblPres.ToString();
            }
        }

        private void ChbBarometrCheckedChanged(object sender, EventArgs e)
        {
//            chbPsixrometr.Enabled = chbBarometr.Checked;
            ChbPsixrometrCheckedChanged(sender, e);
            btnAdd.Enabled = chbAnemometr.Checked || chbBarometr.Checked || chbPsixrometr.Checked || chbTermometr.Checked;
            rbMM.Enabled = chbBarometr.Checked;
            rbBar.Enabled = chbBarometr.Checked;
            if (chbBarometr.Checked)
            {
                txtPressureMM.Enabled = rbMM.Checked;
                txtPressureMM.Text = @"760";
                txtPressureBar.Enabled = rbBar.Checked;
                txtPressureBar.Text = @"1013,08";
            }
            else
            {
                txtPressureMM.Enabled = false;
                txtPressureMM.Clear();
                txtPressureBar.Enabled = false;
                txtPressureBar.Clear();
            }
        }

        private void ChbPsixrometrCheckedChanged(object sender, EventArgs e)
        {
            bool bFlag = chbPsixrometr.Checked;
            nudTempDry.Enabled = bFlag;
            nudTempWet.Enabled = bFlag;
            rbTypeAspir.Enabled = bFlag;
            rbTypeStation.Enabled = bFlag;
            chbIce.Enabled = bFlag;
            btnAdd.Enabled = chbAnemometr.Checked || chbBarometr.Checked || chbPsixrometr.Checked || chbTermometr.Checked;
            btnCalc.Enabled = bFlag && chbBarometr.Checked;
        }

        private void ChbAnemometrCheckedChanged(object sender, EventArgs e)
        {
            nudWindSpeed.Enabled = chbAnemometr.Checked;
            cmbWindDirect.Enabled = chbAnemometr.Checked;
            btnAdd.Enabled = chbAnemometr.Checked || chbBarometr.Checked || chbPsixrometr.Checked || chbTermometr.Checked;
        }

        private void BtnAddMemberClick(object sender, EventArgs e)
        {
            var amf = new AddMemberForm(String.Empty);
            if (amf.ShowDialog() == DialogResult.OK)
            {
                _formParent.Workspace.Members.Add(amf.Member);
                chbListOnDuty.Items.Add(amf.Member);
            }
        }

        private void ChbListOnDutySelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteMember.Enabled = (chbListOnDuty.CheckedItems.Count > 0);
        }

        private void BtnDeleteMemberClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Удалить выбранных участников из проекта?", @"Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (object t in chbListOnDuty.CheckedItems)
                {
                    if (_formParent.Workspace.IsMemberActive(t.ToString()))
                    {
                        MessageBox.Show(@"Пользователь " + t + @" является активным пользователем проекта. Его удаление невозможно.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _formParent.Workspace.Members.Remove(t.ToString());
                    chbListOnDuty.Items.Remove(t);
                }
                chbListOnDuty.Refresh();
            }
        }

        private void ChbTermometrCheckedChanged(object sender, EventArgs e)
        {
            nudTemp.Enabled = chbTermometr.Checked;
            btnAdd.Enabled = chbAnemometr.Checked || chbBarometr.Checked || chbPsixrometr.Checked || chbTermometr.Checked;
        }

        private void ShowParseError(int nFlag)
        {
            string strInsert = nFlag == 1 ? " \"давление\"" : " \"температура\"";
            MessageBox.Show(@"Вы ввели неверное значение параметра" + strInsert + @". Исправьте ошибку.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void NudTempWetValueChanged(object sender, EventArgs e)
        {
            chbIce.Enabled = nudTempWet.Value < 0;
        }
    }
}
