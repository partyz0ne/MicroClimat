using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MicroClimat.Classes;
using MicroClimat.Properties;

namespace MicroClimat.Forms
{
    /// <summary>
    /// Класс главного окна программы.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Свойства
        /// <summary>
        /// Рабочая область проекта.
        /// </summary>
        CWorkspace _workspace;
        
        /// <summary>
        /// Статус состояния изменения проекта.
        /// </summary>
        bool _bPrChanged;
        
        /// <summary>
        /// Текущая структура с данными наблюдения.
        /// </summary>
        ClimatData _stCurData;

        /// <summary>
        /// Имя открытого проекта.
        /// </summary>
        readonly String _strProjectName = String.Empty;

        /// <summary>
        /// Показываемые столбцы в таблице рабочей области.
        /// </summary>
        private readonly bool[] _bColShow = new bool[7];

        /// <summary>
        /// Элемент для печати наблюдений.
        /// </summary>
        DataGridViewPrinter _myDataGridViewPrinter;

        /// <summary>
        /// Текущий проект.
        /// </summary>
        public CWorkspace Workspace
        {
            get { return _workspace; }
            set { _workspace = value; }
        }

        /// <summary>
        /// Текущие данные наблюдения.
        /// </summary>
        public ClimatData CurData
        {
            get { return _stCurData; }
            set { _stCurData = value; }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор главного окна.
        /// </summary>
        /// <param name="strFile">Путь к файлу проекта.</param>
        public MainForm(String strFile)
        {
            CLogger.AddInfo("Запуск приложения.");
            InitializeComponent();
            InitializeConfig();
            MyPrintDocument.PrintPage += MyPrintDocumentPrintPage;
            _strProjectName = strFile;
            if (string.IsNullOrEmpty(_strProjectName))
                _strProjectName = Settings.Default.LastProject;
            if (!string.IsNullOrEmpty(_strProjectName))
                OpenProject(_strProjectName);
        }
        #endregion

        #region Методы
        /// <summary>
        /// Инициализация настроект программы и соответствующих элементов управления.
        /// </summary>
        private void InitializeConfig()
        {
            _bColShow[0] = Settings.Default.show_tempdry;
            _bColShow[1] = Settings.Default.show_tempwet;
            _bColShow[2] = Settings.Default.show_pres;
            _bColShow[3] = Settings.Default.show_wind;
            _bColShow[4] = Settings.Default.show_hum;
            _bColShow[5] = Settings.Default.show_sat;
            _bColShow[6] = Settings.Default.show_duty;

            ToolStripItemCollection itemCol = showViewMenuItem.DropDownItems;
            ToolStripItemCollection contCol = HeaderContextMenu.Items;
            for (int i = 1; i < WorkSpace.Columns.Count - 1; i++)
            {
                ((ToolStripMenuItem)itemCol[i - 1]).Checked = _bColShow[i - 1];
                ((ToolStripMenuItem)contCol[i - 1]).Checked = _bColShow[i - 1];
                WorkSpace.Columns[i].Visible = _bColShow[i - 1];
            }
            ChangeButtonsStyle(false);
        }

        /// <summary>
        /// Открывает проект с указанным именем.
        /// </summary>
        /// <param name="strProjectName">Путь к файлу.</param>
        /// <returns>Возвращает true в случае удачного открытия файла и false - в случае неудачного.</returns>
        private void OpenProject(string strProjectName)
        {
            _workspace = new CWorkspace(strProjectName);
            if (_workspace.Open())
            {
                CLogger.AddInfo("Проект " + strProjectName + " успешно открыт.");
                ReloadData();
                RefreshWorkspace();

                Text += (@" - " + Path.GetFileName(_workspace.Name));
                lblManager.Text = _workspace.Manager;
                OpenStatusChange(true);
                RefreshProjectInfo();
                Settings.Default.LastProject = _workspace.Name;
            }
            else
            {
                _workspace = null;
                MessageBox.Show(@"Произошла ошибка открытия проекта " + strProjectName, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CLogger.AddError("Ошибка открытия проекта " + strProjectName);
            }
        }

        /// <summary>
        /// Закрывает открытый проект.
        /// </summary>
        private bool CloseProject()
        {
            if (_bPrOpened)
            {
                if (_bPrChanged)
                {
                    switch (MessageBox.Show(@"Сохранить текущий проект перед закрытием?", @"Внимание", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:
                            return false;
                        case DialogResult.No:
                            SaveStatusChange(false);
                            break;
                        default:
                            _workspace.Save();
                            SaveStatusChange(false);
                            break;
                    }
                }
                var strProjectName = _workspace.Name;
                _workspace.Close();
                _workspace = null;
                OpenStatusChange(false);
                Text = Utils.GetPropValue("PROGRAM_NAME");
                RefreshProjectInfo();
                lblManager.Text = String.Empty;
                WorkSpace.Rows.Clear();
                CLogger.AddInfo("Проект " + strProjectName + " закрыт.");
            }
            return true;
        }

        /// <summary>
        /// Изменяет состояние элементов управления на форме в зависимости от статуса проекта (открыт/закрыт).
        /// </summary>
        /// <param name="bStatus">Статус проекта.</param>
        private void OpenStatusChange(bool bStatus)
        {
            _bPrOpened = bStatus;
            saveAsFileMenuItem.Enabled =
                closeFileMenuItem.Enabled =
                closeToolbarButton.Enabled =
                btnPrint.Enabled =
                DataMenuItem.Visible =
                addDataToolbarButton.Enabled =
                selectAllViewMenuItem.Enabled = bStatus;
        }

        /// <summary>
        /// Изменяет состояние элементов управления на форме в зависимости от статуса проекта (изменен/не изменен).
        /// </summary>
        /// <param name="bStatus">Статус проекта</param>
        private void SaveStatusChange(bool bStatus)
        {
            _bPrChanged = bStatus;
            saveFileMenuItem.Enabled =
                saveToolbarButton.Enabled = bStatus;
        }

        /// <summary>
        /// Редактировать данные наблюдений.
        /// </summary>
        private void EditItem()
        {
            int nIndex = int.Parse(WorkSpace.SelectedRows[0].Cells["colIndex"].Value.ToString());
            _stCurData = _workspace.GetDatabyIndex(nIndex);
            var formAdd = new AddItemForm(this, true);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                _workspace.EditData(_stCurData);
                ReloadData();
                SaveStatusChange(true);
                RefreshWorkspace();
            }
        }

        /// <summary>
        /// Перезагрузка данных и проекта.
        /// </summary>
        private void ReloadData()
        {
            if (_bPrOpened)
                WorkSpace.Rows.Clear();
            for (int i = 0; i < _workspace.Length; i++)
            {
                ClimatData tmpStData = _workspace[i];
                String strWindDirect = Utils.GetWindDirect(tmpStData.WindDirect);
                WorkSpace.Rows.Add(tmpStData.Date.ToString(),
                    tmpStData.TempDry, tmpStData.TempWet,
                    tmpStData.Pressure, strWindDirect + ", " + tmpStData.WindSpeed,
                    tmpStData.Humidity, tmpStData.Saturation, tmpStData.Duty, tmpStData.Index);
            }
        }

        /// <summary>
        /// Обновляет рабочую область программы.
        /// </summary>
        private void RefreshWorkspace()
        {
            for (int i = 1; i < WorkSpace.ColumnCount - 1; i++)
                WorkSpace.Columns[i].Visible = _bColShow[i - 1];
            WorkSpace.Refresh();
        }

        /// <summary>
        /// Обновить или очистить информацию по проекту.
        /// </summary>
        private void RefreshProjectInfo()
        {
            if (_bPrOpened)
            {
                int nCnt = _workspace.Length;
                txtInfoItemsCount.Text = nCnt.ToString();
                if (nCnt > 0)
                {
                    txtInfoDateFirst.Text = _workspace[0].Date.ToString();
                    txtInfoDateLast.Text = _workspace[nCnt - 1].Date.ToString();
                }
            }
            else
            {
                txtInfoItemsCount.Clear();
                txtInfoDateFirst.Clear();
                txtInfoDateLast.Clear();
            }
        }

        /// <summary>
        /// Изменить стиль отображения кнопок панели инструментов.
        /// </summary>
        /// <param name="bChange"></param>
        private void ChangeButtonsStyle(bool bChange)
        {
            if (bChange)
                Settings.Default.show_texts = !Settings.Default.show_texts;
            for (int i = 0; i < ToolBar.Items.Count; i++)
            {
                if (ToolBar.Items[i].Name != "toolStripSeparator" && ToolBar.Items[i].Name != "toolStripSeparator2")
                {
                    var btn = (ToolStripButton)ToolBar.Items[i];
                    btn.DisplayStyle = Settings.Default.show_texts ? ToolStripItemDisplayStyle.ImageAndText : ToolStripItemDisplayStyle.Image;
                }
            }
            textsViewMenuItem.Checked = Settings.Default.show_texts;
            Settings.Default.Save();
        }
        #endregion

        #region Обработчики событий
        private void OnFileNewProject(object sender, EventArgs e)
        {
            var cpw = new CreateProjectWizard(this);
            if (cpw.ShowDialog() == DialogResult.OK)
            {
                CloseProject();
                OpenStatusChange(true);
                Text += (@" - " + Path.GetFileName(_workspace.Name));
                lblManager.Text = _workspace.Manager;
                RefreshProjectInfo();
            }
        }

        private void OnFileOpenProject(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog {Filter = Utils.GetPropValue("PROJECT_FILE_FILTER")};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CloseProject();
                OpenProject(ofd.FileName);
            }
        }

        private void OnFileSaveProject(object sender, EventArgs e)
        {
            _workspace.Save();
            SaveStatusChange(false);
        }

        private void OnFileSaveAsProject(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog {Filter = Utils.GetPropValue("PROJECT_FILE_FILTER")};
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (_bPrChanged)
                {
                    switch (MessageBox.Show(@"Сохранить текущий проект перед закрытием?", @"Внимание", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.No:
                            SaveStatusChange(false);
                            break;
                        default:
                            _workspace.Save();
                            break;
                    }
                }
                _workspace.SaveAs(sfd.FileName);
                Text = Utils.GetPropValue("PROGRA_NAME");
                Text += (@" - " + Path.GetFileName(_workspace.Name));
                OpenStatusChange(true);
            }
        }

        private void OnDataAdd(object sender, EventArgs e)
        {
            var addForm = new AddItemForm(this, false);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                _workspace.AddData(_stCurData);
                ReloadData();
                RefreshWorkspace();
                SaveStatusChange(true);
                RefreshProjectInfo();
            }
        }

        private void OnFileCloseProject(object sender, EventArgs e)
        {
            CloseProject();
            RefreshProjectInfo();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            CloseProject();
            Application.Exit();
        }

        private void OnDataDelete(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection indexes = WorkSpace.SelectedRows;
            if (MessageBox.Show(@"Удалить выделенные элементы?", @"Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < indexes.Count; i++)
                {
                    _workspace.DeleteData(int.Parse(indexes[i].Cells["colIndex"].Value.ToString()));
                    WorkSpace.Rows.RemoveAt(indexes[i].Index);
                }
                RefreshWorkspace();
                SaveStatusChange(true);
            }
        }

        private void DataMenuIteClick(object sender, EventArgs e)
        {
            deleteDataMenuItem.Enabled = false;
            editDataMenuItem.Enabled = false;
            int nCount = WorkSpace.SelectedRows.Count;
            if (nCount > 0)
            {
                deleteDataMenuItem.Enabled = true;
                if (nCount == 1)
                    editDataMenuItem.Enabled = true;
            }
        }

        private void OnMainFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            if (!CloseProject())
                e.Cancel = true;
        }

        private void OnDataEdit(object sender, EventArgs e)
        {
            EditItem();
        }

        private void ChangeCheckedItems(int nPos)
        {
            switch (nPos)
            {
                case 0:
                    Settings.Default.show_tempdry = _bColShow[nPos]; break;
                case 1:
                    Settings.Default.show_tempwet = _bColShow[nPos]; break;
                case 2:
                    Settings.Default.show_pres = _bColShow[nPos]; break;
                case 3:
                    Settings.Default.show_wind = _bColShow[nPos]; break;
                case 4:
                    Settings.Default.show_hum = _bColShow[nPos]; break;
                case 5:
                    Settings.Default.show_sat = _bColShow[nPos]; break;
                case 6:
                    Settings.Default.show_duty = _bColShow[nPos]; break;
            }
            Settings.Default.Save();
            RefreshWorkspace();
        }

        private void OnViewShowItems(object sender, EventArgs e)
        {
            var miCur = (ToolStripMenuItem)sender;
            ToolStripMenuItem newCur;
            int nPos;
            ToolStrip parent = miCur.GetCurrentParent();
            if (parent.Name == "HeaderContextMenu")
            {
                nPos = HeaderContextMenu.Items.IndexOf(miCur);
                newCur = (ToolStripMenuItem)showViewMenuItem.DropDownItems[nPos];
            }
            else
            {
                nPos = showViewMenuItem.DropDownItems.IndexOf(miCur);
                newCur = (ToolStripMenuItem)HeaderContextMenu.Items[nPos];
            }
            newCur.Checked = !newCur.Checked;
            miCur.Checked = !miCur.Checked;
            _bColShow[nPos] = miCur.Checked;
            ChangeCheckedItems(nPos);
        }

        private void WorkSpaceSelectionChanged(object sender, EventArgs e)
        {
            switch (WorkSpace.SelectedRows.Count)
            {
                case 0:
                    editDataToolbarButton.Enabled = false;
                    deleteDataToolbarButton.Enabled = false;
                    btnShowChart.Enabled = false;
                    break;
                case 1:
                    editDataToolbarButton.Enabled = true;
                    deleteDataToolbarButton.Enabled = true;
                    btnShowChart.Enabled = false;
                    break;
                default:
                    editDataToolbarButton.Enabled = false;
                    deleteDataToolbarButton.Enabled = true;
                    btnShowChart.Enabled = true;
                    if (_bColShow[0] || _bColShow[1] || _bColShow[2] || _bColShow[4])
                        btnShowChart.Enabled = true;
                    else
                        btnShowChart.Enabled = false;
                    break;
            }
        }

        private void OnViewSelectAll(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = WorkSpace.SelectedRows;
            for (int i = 0; i < rows.Count; i++)
                rows[i].Selected = false;
            for (int i = 0; i < WorkSpace.Rows.Count; i++)
                WorkSpace.Rows[i].Selected = true;
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            var formAbout = new AboutForm();
            formAbout.ShowDialog();
        }

        private void WorkSpaceKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
                return;
            if (_bPrOpened && WorkSpace.SelectedRows.Count == 1)
                EditItem();

            e.SuppressKeyPress = true;
        }

        private void OnDataProjectProps(object sender, EventArgs e)
        {
            try
            {
                var formMembers = new ProjectPropertiesForm(this);
                if (formMembers.ShowDialog() == DialogResult.OK)
                    Workspace.Save();
            }
            catch (ArgumentNullException ex)
            {
                CLogger.AddException(ex);
            }
        }

        private void WorkSpaceDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                EditItem();
        }

        private void TextsViewMenuIteClick(object sender, EventArgs e)
        {
            ChangeButtonsStyle(true);
        }

        private void WorkSpaceColumnHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                HeaderContextMenu.Show(MousePosition);
        }

        private void WorkSpaceRightClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection rows = WorkSpace.SelectedRows;
                int nCnt = rows.Count;
                if (nCnt == 1)
                {
                    rows[0].Selected = false;
                    contextEditItem.Enabled = true;
                    contextDeleteItem.Enabled = true;
                    contextShowChart.Enabled = false;
                }
                else
                {
                    bool bUncheck = true;
                    for (int i = 0; i < nCnt; i++)
                        if (rows[i].Index == e.RowIndex)
                            bUncheck = false;
                    if (bUncheck)
                    {
                        for (int i = 0; i < nCnt; i++)
                            if (rows[i].Index != e.RowIndex)
                                rows[i].Selected = false;
                        contextEditItem.Enabled = true;
                        contextDeleteItem.Enabled = true;
                        contextShowChart.Enabled = false;
                    }
                    else
                    {
                        contextEditItem.Enabled = false;
                        contextDeleteItem.Enabled = true;
                        contextShowChart.Enabled = true;
                    }
                }
                WorkSpace.Rows[e.RowIndex].Selected = true;
                if (e.Button == MouseButtons.Right)
                    ContentContextMenu.Show(MousePosition);
            }
        }

        private void OnShowChartClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = WorkSpace.SelectedRows;
            var dtDates = new List<DateTime>();
            for (int i = 0; i < rows.Count; i++)
                dtDates.Add(DateTime.Parse(rows[i].Cells["colDate"].Value.ToString()));

            var chfEx = new ChartFormEx(dtDates);
            String toolName = ((ToolStripMenuItem)sender).Name;
            if (toolName == "tempChartContextMenuItem" || toolName == "contextShowTemp")
            {
                chfEx.Title = "График изменения температуры.";
                chfEx.YAxis = "Температура (°C)";

                var dblTempDry = new List<double>();
                var dblTempWet = new List<double>();
                for (int i = 0; i < rows.Count; i++)
                {
                    dblTempDry.Add(double.Parse(rows[i].Cells["colTempDry"].Value.ToString()));
                    if (_bColShow[1])
                        dblTempWet.Add(double.Parse(rows[i].Cells["colTempWet"].Value.ToString()));
                }
                if (rows[0].Index > rows[1].Index)
                {
                    dtDates.Reverse();
                    dblTempDry.Reverse();
                    dblTempWet.Reverse();
                }

                if (_bColShow[1])
                    chfEx.MakeChartOf2Param(dblTempDry, dblTempWet);
                else
                    chfEx.MakeChartOf1Param(dblTempDry);
            }
            else
            {
                var dblParam = new List<double>();
                for (int i = 0; i < rows.Count; i++)
                {
                    if (toolName == "presChartContextMenuItem" || toolName == "contextShowPres")
                    {
                        chfEx.Title = "График изменения давления.";
                        chfEx.ParName = "Давление.";
                        chfEx.YAxis = "Давление (мм рт.ст.)";
                        if (_bColShow[2])
                            dblParam.Add(double.Parse(rows[i].Cells["colPressure"].Value.ToString()));
                    }
                    else
                    {
                        chfEx.Title = "График изменения влажности.";
                        chfEx.ParName = "Влажность.";
                        chfEx.YAxis = "Влажность (%)";
                        if (_bColShow[4])
                            dblParam.Add(double.Parse(rows[i].Cells["colHumidity"].Value.ToString()));
                    }
                }
                if (rows[0].Index > rows[1].Index)
                {
                    dtDates.Reverse();
                    dblParam.Reverse();
                }
                chfEx.MakeChartOf1Param(dblParam);
            }
            chfEx.ShowDialog();
        }

        private void BtnShowChartClick1(object sender, EventArgs e)
        {
            tempChartContextMenuItem.Enabled = _bColShow[0];
            presChartContextMenuItem.Enabled = _bColShow[2];
            humChartContextMenuItem.Enabled = _bColShow[4];
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            WorkSpaceSelectionChanged(sender, e);
        }

        private void OnContextShowOpening(object sender, EventArgs e)
        {
            contextShowTemp.Enabled = _bColShow[0];
            contextShowPres.Enabled = _bColShow[2];
            contextShowHum.Enabled = _bColShow[4];
        }

        private void OnWindRoseClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = WorkSpace.SelectedRows;
            var chfEx = new ChartFormEx();
            var nValues = new List<int>();

            for (int i = 0; i < 8; i++)
                nValues.Add(0);

            for (int i = 0; i < rows.Count; i++)
            {
                int index = int.Parse(rows[i].Cells["colIndex"].Value.ToString());
                ClimatData cd = _workspace.GetDatabyIndex(index);
                if (cd.WindDirect != -1)
                    nValues[cd.WindDirect]++;
            }

            chfEx.MakeWindRose(nValues);
            chfEx.ShowDialog();
        }

        private void ExportDataMenuItemClick(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog {Filter = @"CSV (разделители - запятые) (*.csv)|*.csv|Все файлы (*.*)|*.*"};
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var myFile = new StreamWriter(sfd.FileName, false, Encoding.Default))
                {
                    String strLine = String.Empty;
                    for (int h = 0; h < WorkSpace.ColumnCount; h++)
                        strLine += WorkSpace.Columns[h].HeaderText + ";";
                    myFile.WriteLine(strLine);

                    for (int i = 0; i < WorkSpace.RowCount; i++)
                    {
                        strLine = String.Empty;
                        for (int j = 0; j < WorkSpace.Rows[i].Cells.Count - 1; j++)
                            strLine += WorkSpace.Rows[i].Cells[j].Value + ";";
                        myFile.WriteLine(strLine);
                    }
                }
                CLogger.AddInfo("Экспорт информации успешно завершен.");
                if (MessageBox.Show(@"Экспорт информации успешно завершен. Открыть файл для просмотра?", @"Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    var proc = new System.Diagnostics.Process
                                   {StartInfo = {FileName = sfd.FileName, UseShellExecute = true}};
                    proc.Start();
                }
            }
        }

        private void SettingsServiceMenuItemClick(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
        #endregion

        #region Печать
        /// <summary>
        /// Подготовка страницы к печати.
        /// </summary>
        /// <returns></returns>
        private bool SetupThePrinting()
        {
            var myPrintDialog = new PrintDialog
                                    {
                                        AllowCurrentPage = false,
                                        AllowPrintToFile = false,
                                        AllowSelection = false,
                                        AllowSomePages = false,
                                        PrintToFile = false,
                                        ShowHelp = false,
                                        ShowNetwork = false
                                    };

            if (myPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            MyPrintDocument.DocumentName = Text;
            MyPrintDocument.PrinterSettings = myPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = myPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Landscape = true;
            MyPrintDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);

            _myDataGridViewPrinter = new DataGridViewPrinter(WorkSpace,
                MyPrintDocument, true, true, Text,
                new Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point),
                Color.Black, true);

            return true;
        }

        private void MyPrintDocumentPrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = _myDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more)
                e.HasMorePages = true;
        }

        private void BtnPrintClick(object sender, EventArgs e)
        {
            if (SetupThePrinting())
                MyPrintDocument.Print();
        }
        #endregion
    }
}
