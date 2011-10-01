using MicroClimat.Controls;

namespace MicroClimat.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WorkSpace = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempDry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTempWet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaturation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOnDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempdryShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempwetShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dutyShowViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textsViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.propsDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.newToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.openToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.closeToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.addDataToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.editDataToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.deleteDataToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolbarButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowChart = new MicroClimat.Controls.SplitButton();
            this.ChartContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tempChartContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presChartContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humChartContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windRoseContextChartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManager = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfoDateLast = new System.Windows.Forms.TextBox();
            this.txtInfoDateFirst = new System.Windows.Forms.TextBox();
            this.txtInfoItemsCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeaderContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextTempDry = new System.Windows.Forms.ToolStripMenuItem();
            this.contextTempWet = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPressure = new System.Windows.Forms.ToolStripMenuItem();
            this.contextWind = new System.Windows.Forms.ToolStripMenuItem();
            this.contextHumidity = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSaturation = new System.Windows.Forms.ToolStripMenuItem();
            this.contextOnDuty = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShowChart = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShowTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShowPres = new System.Windows.Forms.ToolStripMenuItem();
            this.contextShowHum = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.WorkSpace)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ChartContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HeaderContextMenu.SuspendLayout();
            this.ContentContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkSpace
            // 
            this.WorkSpace.AllowUserToAddRows = false;
            this.WorkSpace.AllowUserToDeleteRows = false;
            this.WorkSpace.AllowUserToResizeRows = false;
            resources.ApplyResources(this.WorkSpace, "WorkSpace");
            this.WorkSpace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkSpace.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkSpace.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WorkSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkSpace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colTempDry,
            this.colTempWet,
            this.colPressure,
            this.colWind,
            this.colHumidity,
            this.colSaturation,
            this.colOnDuty,
            this.colIndex});
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.ReadOnly = true;
            this.WorkSpace.RowHeadersVisible = false;
            this.WorkSpace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkSpace.ShowEditingIcon = false;
            this.WorkSpace.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkSpaceDoubleClick);
            this.WorkSpace.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WorkSpaceRightClick);
            this.WorkSpace.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WorkSpaceColumnHeaderClick);
            this.WorkSpace.SelectionChanged += new System.EventHandler(this.WorkSpaceSelectionChanged);
            this.WorkSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkSpaceKeyPressed);
            // 
            // colDate
            // 
            resources.ApplyResources(this.colDate, "colDate");
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTempDry
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTempDry.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.colTempDry, "colTempDry");
            this.colTempDry.Name = "colTempDry";
            this.colTempDry.ReadOnly = true;
            this.colTempDry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTempWet
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTempWet.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.colTempWet, "colTempWet");
            this.colTempWet.Name = "colTempWet";
            this.colTempWet.ReadOnly = true;
            this.colTempWet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPressure
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPressure.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.colPressure, "colPressure");
            this.colPressure.Name = "colPressure";
            this.colPressure.ReadOnly = true;
            this.colPressure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWind
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colWind.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.colWind, "colWind");
            this.colWind.Name = "colWind";
            this.colWind.ReadOnly = true;
            this.colWind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHumidity
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHumidity.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.colHumidity, "colHumidity");
            this.colHumidity.Name = "colHumidity";
            this.colHumidity.ReadOnly = true;
            this.colHumidity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSaturation
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSaturation.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.colSaturation, "colSaturation");
            this.colSaturation.Name = "colSaturation";
            this.colSaturation.ReadOnly = true;
            this.colSaturation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colOnDuty
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOnDuty.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.colOnDuty, "colOnDuty");
            this.colOnDuty.Name = "colOnDuty";
            this.colOnDuty.ReadOnly = true;
            this.colOnDuty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colIndex
            // 
            resources.ApplyResources(this.colIndex, "colIndex");
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.ViewMenuItem,
            this.DataMenuItem,
            this.ServiceMenuItem,
            this.HelpMenuItem});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.saveAsFileMenuItem,
            this.closeFileMenuItem,
            this.toolStripSeparator1,
            this.exitFileMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            resources.ApplyResources(this.FileMenuItem, "FileMenuItem");
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.Name = "newFileMenuItem";
            resources.ApplyResources(this.newFileMenuItem, "newFileMenuItem");
            this.newFileMenuItem.Click += new System.EventHandler(this.OnFileNewProject);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            resources.ApplyResources(this.openFileMenuItem, "openFileMenuItem");
            this.openFileMenuItem.Click += new System.EventHandler(this.OnFileOpenProject);
            // 
            // saveFileMenuItem
            // 
            resources.ApplyResources(this.saveFileMenuItem, "saveFileMenuItem");
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Click += new System.EventHandler(this.OnFileSaveProject);
            // 
            // saveAsFileMenuItem
            // 
            resources.ApplyResources(this.saveAsFileMenuItem, "saveAsFileMenuItem");
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.OnFileSaveAsProject);
            // 
            // closeFileMenuItem
            // 
            resources.ApplyResources(this.closeFileMenuItem, "closeFileMenuItem");
            this.closeFileMenuItem.Name = "closeFileMenuItem";
            this.closeFileMenuItem.Click += new System.EventHandler(this.OnFileCloseProject);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            resources.ApplyResources(this.exitFileMenuItem, "exitFileMenuItem");
            this.exitFileMenuItem.Click += new System.EventHandler(this.OnFileExit);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showViewMenuItem,
            this.textsViewMenuItem,
            this.selectAllViewMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            resources.ApplyResources(this.ViewMenuItem, "ViewMenuItem");
            // 
            // showViewMenuItem
            // 
            this.showViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempdryShowViewMenuItem,
            this.tempwetShowViewMenuItem,
            this.presShowViewMenuItem,
            this.windShowViewMenuItem,
            this.humShowViewMenuItem,
            this.satShowViewMenuItem,
            this.dutyShowViewMenuItem});
            this.showViewMenuItem.Name = "showViewMenuItem";
            resources.ApplyResources(this.showViewMenuItem, "showViewMenuItem");
            // 
            // tempdryShowViewMenuItem
            // 
            this.tempdryShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_tempdry;
            this.tempdryShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tempdryShowViewMenuItem.Name = "tempdryShowViewMenuItem";
            resources.ApplyResources(this.tempdryShowViewMenuItem, "tempdryShowViewMenuItem");
            this.tempdryShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // tempwetShowViewMenuItem
            // 
            this.tempwetShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_tempwet;
            this.tempwetShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tempwetShowViewMenuItem.Name = "tempwetShowViewMenuItem";
            resources.ApplyResources(this.tempwetShowViewMenuItem, "tempwetShowViewMenuItem");
            this.tempwetShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // presShowViewMenuItem
            // 
            this.presShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_pres;
            this.presShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.presShowViewMenuItem.Name = "presShowViewMenuItem";
            resources.ApplyResources(this.presShowViewMenuItem, "presShowViewMenuItem");
            this.presShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // windShowViewMenuItem
            // 
            this.windShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_wind;
            this.windShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windShowViewMenuItem.Name = "windShowViewMenuItem";
            resources.ApplyResources(this.windShowViewMenuItem, "windShowViewMenuItem");
            this.windShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // humShowViewMenuItem
            // 
            this.humShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_hum;
            this.humShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.humShowViewMenuItem.Name = "humShowViewMenuItem";
            resources.ApplyResources(this.humShowViewMenuItem, "humShowViewMenuItem");
            this.humShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // satShowViewMenuItem
            // 
            this.satShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_sat;
            this.satShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.satShowViewMenuItem.Name = "satShowViewMenuItem";
            resources.ApplyResources(this.satShowViewMenuItem, "satShowViewMenuItem");
            this.satShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // dutyShowViewMenuItem
            // 
            this.dutyShowViewMenuItem.Checked = global::MicroClimat.Properties.Settings.Default.show_duty;
            this.dutyShowViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dutyShowViewMenuItem.Name = "dutyShowViewMenuItem";
            resources.ApplyResources(this.dutyShowViewMenuItem, "dutyShowViewMenuItem");
            this.dutyShowViewMenuItem.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // textsViewMenuItem
            // 
            this.textsViewMenuItem.Checked = true;
            this.textsViewMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textsViewMenuItem.Name = "textsViewMenuItem";
            resources.ApplyResources(this.textsViewMenuItem, "textsViewMenuItem");
            this.textsViewMenuItem.Click += new System.EventHandler(this.TextsViewMenuIteClick);
            // 
            // selectAllViewMenuItem
            // 
            resources.ApplyResources(this.selectAllViewMenuItem, "selectAllViewMenuItem");
            this.selectAllViewMenuItem.Name = "selectAllViewMenuItem";
            this.selectAllViewMenuItem.Click += new System.EventHandler(this.OnViewSelectAll);
            // 
            // DataMenuItem
            // 
            this.DataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataMenuItem,
            this.editDataMenuItem,
            this.deleteDataMenuItem,
            this.toolStripSeparator3,
            this.exportDataMenuItem,
            this.toolStripSeparator5,
            this.propsDataMenuItem});
            this.DataMenuItem.Name = "DataMenuItem";
            resources.ApplyResources(this.DataMenuItem, "DataMenuItem");
            this.DataMenuItem.Click += new System.EventHandler(this.DataMenuIteClick);
            // 
            // addDataMenuItem
            // 
            this.addDataMenuItem.Name = "addDataMenuItem";
            resources.ApplyResources(this.addDataMenuItem, "addDataMenuItem");
            this.addDataMenuItem.Click += new System.EventHandler(this.OnDataAdd);
            // 
            // editDataMenuItem
            // 
            this.editDataMenuItem.Name = "editDataMenuItem";
            resources.ApplyResources(this.editDataMenuItem, "editDataMenuItem");
            this.editDataMenuItem.Click += new System.EventHandler(this.OnDataEdit);
            // 
            // deleteDataMenuItem
            // 
            this.deleteDataMenuItem.Name = "deleteDataMenuItem";
            resources.ApplyResources(this.deleteDataMenuItem, "deleteDataMenuItem");
            this.deleteDataMenuItem.Click += new System.EventHandler(this.OnDataDelete);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // exportDataMenuItem
            // 
            this.exportDataMenuItem.Name = "exportDataMenuItem";
            resources.ApplyResources(this.exportDataMenuItem, "exportDataMenuItem");
            this.exportDataMenuItem.Click += new System.EventHandler(this.ExportDataMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // propsDataMenuItem
            // 
            this.propsDataMenuItem.Name = "propsDataMenuItem";
            resources.ApplyResources(this.propsDataMenuItem, "propsDataMenuItem");
            this.propsDataMenuItem.Click += new System.EventHandler(this.OnDataProjectProps);
            // 
            // ServiceMenuItem
            // 
            this.ServiceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsServiceMenuItem});
            this.ServiceMenuItem.Name = "ServiceMenuItem";
            resources.ApplyResources(this.ServiceMenuItem, "ServiceMenuItem");
            // 
            // settingsServiceMenuItem
            // 
            this.settingsServiceMenuItem.Name = "settingsServiceMenuItem";
            resources.ApplyResources(this.settingsServiceMenuItem, "settingsServiceMenuItem");
            this.settingsServiceMenuItem.Click += new System.EventHandler(this.SettingsServiceMenuItemClick);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHelpMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            resources.ApplyResources(this.HelpMenuItem, "HelpMenuItem");
            // 
            // aboutHelpMenuItem
            // 
            this.aboutHelpMenuItem.Name = "aboutHelpMenuItem";
            resources.ApplyResources(this.aboutHelpMenuItem, "aboutHelpMenuItem");
            this.aboutHelpMenuItem.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // ToolBar
            // 
            this.ToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolbarButton,
            this.openToolbarButton,
            this.saveToolbarButton,
            this.closeToolbarButton,
            this.toolStripSeparator,
            this.addDataToolbarButton,
            this.editDataToolbarButton,
            this.deleteDataToolbarButton,
            this.toolStripSeparator2,
            this.aboutToolbarButton});
            resources.ApplyResources(this.ToolBar, "ToolBar");
            this.ToolBar.Name = "ToolBar";
            // 
            // newToolbarButton
            // 
            this.newToolbarButton.Image = global::MicroClimat.Properties.Resources.project_new;
            resources.ApplyResources(this.newToolbarButton, "newToolbarButton");
            this.newToolbarButton.Name = "newToolbarButton";
            this.newToolbarButton.Click += new System.EventHandler(this.OnFileNewProject);
            // 
            // openToolbarButton
            // 
            this.openToolbarButton.Image = global::MicroClimat.Properties.Resources.project_open;
            resources.ApplyResources(this.openToolbarButton, "openToolbarButton");
            this.openToolbarButton.Name = "openToolbarButton";
            this.openToolbarButton.Click += new System.EventHandler(this.OnFileOpenProject);
            // 
            // saveToolbarButton
            // 
            resources.ApplyResources(this.saveToolbarButton, "saveToolbarButton");
            this.saveToolbarButton.Image = global::MicroClimat.Properties.Resources.project_save;
            this.saveToolbarButton.Name = "saveToolbarButton";
            this.saveToolbarButton.Click += new System.EventHandler(this.OnFileSaveProject);
            // 
            // closeToolbarButton
            // 
            resources.ApplyResources(this.closeToolbarButton, "closeToolbarButton");
            this.closeToolbarButton.Image = global::MicroClimat.Properties.Resources.project_close;
            this.closeToolbarButton.Name = "closeToolbarButton";
            this.closeToolbarButton.Click += new System.EventHandler(this.OnFileCloseProject);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // addDataToolbarButton
            // 
            resources.ApplyResources(this.addDataToolbarButton, "addDataToolbarButton");
            this.addDataToolbarButton.Image = global::MicroClimat.Properties.Resources.item_add;
            this.addDataToolbarButton.Name = "addDataToolbarButton";
            this.addDataToolbarButton.Click += new System.EventHandler(this.OnDataAdd);
            // 
            // editDataToolbarButton
            // 
            resources.ApplyResources(this.editDataToolbarButton, "editDataToolbarButton");
            this.editDataToolbarButton.Image = global::MicroClimat.Properties.Resources.item_edit;
            this.editDataToolbarButton.Name = "editDataToolbarButton";
            this.editDataToolbarButton.Click += new System.EventHandler(this.OnDataEdit);
            // 
            // deleteDataToolbarButton
            // 
            resources.ApplyResources(this.deleteDataToolbarButton, "deleteDataToolbarButton");
            this.deleteDataToolbarButton.Image = global::MicroClimat.Properties.Resources.item_delete;
            this.deleteDataToolbarButton.Name = "deleteDataToolbarButton";
            this.deleteDataToolbarButton.Click += new System.EventHandler(this.OnDataDelete);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // aboutToolbarButton
            // 
            this.aboutToolbarButton.Image = global::MicroClimat.Properties.Resources.help;
            resources.ApplyResources(this.aboutToolbarButton, "aboutToolbarButton");
            this.aboutToolbarButton.Name = "aboutToolbarButton";
            this.aboutToolbarButton.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnShowChart);
            this.groupBox1.Controls.Add(this.lblManager);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInfoDateLast);
            this.groupBox1.Controls.Add(this.txtInfoDateFirst);
            this.groupBox1.Controls.Add(this.txtInfoItemsCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrintClick);
            // 
            // btnShowChart
            // 
            this.btnShowChart.AlwaysDropDown = true;
            resources.ApplyResources(this.btnShowChart, "btnShowChart");
            this.btnShowChart.ContextMenuStrip = this.ChartContextMenu;
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.BtnShowChartClick1);
            // 
            // ChartContextMenu
            // 
            this.ChartContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tempChartContextMenuItem,
            this.presChartContextMenuItem,
            this.humChartContextMenuItem,
            this.windRoseContextChartMenuItem});
            this.ChartContextMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.ChartContextMenu, "ChartContextMenu");
            // 
            // tempChartContextMenuItem
            // 
            this.tempChartContextMenuItem.Name = "tempChartContextMenuItem";
            resources.ApplyResources(this.tempChartContextMenuItem, "tempChartContextMenuItem");
            this.tempChartContextMenuItem.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // presChartContextMenuItem
            // 
            this.presChartContextMenuItem.Name = "presChartContextMenuItem";
            resources.ApplyResources(this.presChartContextMenuItem, "presChartContextMenuItem");
            this.presChartContextMenuItem.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // humChartContextMenuItem
            // 
            this.humChartContextMenuItem.Name = "humChartContextMenuItem";
            resources.ApplyResources(this.humChartContextMenuItem, "humChartContextMenuItem");
            this.humChartContextMenuItem.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // windRoseContextChartMenuItem
            // 
            this.windRoseContextChartMenuItem.Name = "windRoseContextChartMenuItem";
            resources.ApplyResources(this.windRoseContextChartMenuItem, "windRoseContextChartMenuItem");
            this.windRoseContextChartMenuItem.Click += new System.EventHandler(this.OnWindRoseClick);
            // 
            // lblManager
            // 
            resources.ApplyResources(this.lblManager, "lblManager");
            this.lblManager.Name = "lblManager";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtInfoDateLast
            // 
            this.txtInfoDateLast.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfoDateLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoDateLast.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtInfoDateLast, "txtInfoDateLast");
            this.txtInfoDateLast.Name = "txtInfoDateLast";
            this.txtInfoDateLast.ReadOnly = true;
            this.txtInfoDateLast.TabStop = false;
            // 
            // txtInfoDateFirst
            // 
            this.txtInfoDateFirst.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfoDateFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoDateFirst.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtInfoDateFirst, "txtInfoDateFirst");
            this.txtInfoDateFirst.Name = "txtInfoDateFirst";
            this.txtInfoDateFirst.ReadOnly = true;
            this.txtInfoDateFirst.TabStop = false;
            // 
            // txtInfoItemsCount
            // 
            this.txtInfoItemsCount.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfoItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfoItemsCount.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.txtInfoItemsCount, "txtInfoItemsCount");
            this.txtInfoItemsCount.Name = "txtInfoItemsCount";
            this.txtInfoItemsCount.ReadOnly = true;
            this.txtInfoItemsCount.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WorkSpace);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // HeaderContextMenu
            // 
            this.HeaderContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextTempDry,
            this.contextTempWet,
            this.contextPressure,
            this.contextWind,
            this.contextHumidity,
            this.contextSaturation,
            this.contextOnDuty});
            this.HeaderContextMenu.Name = "HeaderContextMenu";
            resources.ApplyResources(this.HeaderContextMenu, "HeaderContextMenu");
            // 
            // contextTempDry
            // 
            this.contextTempDry.Checked = true;
            this.contextTempDry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextTempDry.Name = "contextTempDry";
            resources.ApplyResources(this.contextTempDry, "contextTempDry");
            this.contextTempDry.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextTempWet
            // 
            this.contextTempWet.Checked = true;
            this.contextTempWet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextTempWet.Name = "contextTempWet";
            resources.ApplyResources(this.contextTempWet, "contextTempWet");
            this.contextTempWet.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextPressure
            // 
            this.contextPressure.Checked = true;
            this.contextPressure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextPressure.Name = "contextPressure";
            resources.ApplyResources(this.contextPressure, "contextPressure");
            this.contextPressure.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextWind
            // 
            this.contextWind.Checked = true;
            this.contextWind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextWind.Name = "contextWind";
            resources.ApplyResources(this.contextWind, "contextWind");
            this.contextWind.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextHumidity
            // 
            this.contextHumidity.Checked = true;
            this.contextHumidity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextHumidity.Name = "contextHumidity";
            resources.ApplyResources(this.contextHumidity, "contextHumidity");
            this.contextHumidity.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextSaturation
            // 
            this.contextSaturation.Checked = true;
            this.contextSaturation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextSaturation.Name = "contextSaturation";
            resources.ApplyResources(this.contextSaturation, "contextSaturation");
            this.contextSaturation.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // contextOnDuty
            // 
            this.contextOnDuty.Checked = true;
            this.contextOnDuty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.contextOnDuty.Name = "contextOnDuty";
            resources.ApplyResources(this.contextOnDuty, "contextOnDuty");
            this.contextOnDuty.Click += new System.EventHandler(this.OnViewShowItems);
            // 
            // ContentContextMenu
            // 
            this.ContentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextEditItem,
            this.contextDeleteItem,
            this.contextShowChart,
            this.toolStripSeparator4,
            this.contextSelectAll});
            this.ContentContextMenu.Name = "ContentContextMenu";
            resources.ApplyResources(this.ContentContextMenu, "ContentContextMenu");
            // 
            // contextEditItem
            // 
            this.contextEditItem.Name = "contextEditItem";
            resources.ApplyResources(this.contextEditItem, "contextEditItem");
            this.contextEditItem.Click += new System.EventHandler(this.OnDataEdit);
            // 
            // contextDeleteItem
            // 
            this.contextDeleteItem.Name = "contextDeleteItem";
            resources.ApplyResources(this.contextDeleteItem, "contextDeleteItem");
            this.contextDeleteItem.Click += new System.EventHandler(this.OnDataDelete);
            // 
            // contextShowChart
            // 
            this.contextShowChart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextShowTemp,
            this.contextShowPres,
            this.contextShowHum});
            this.contextShowChart.Name = "contextShowChart";
            resources.ApplyResources(this.contextShowChart, "contextShowChart");
            this.contextShowChart.DropDownOpening += new System.EventHandler(this.OnContextShowOpening);
            // 
            // contextShowTemp
            // 
            this.contextShowTemp.Name = "contextShowTemp";
            resources.ApplyResources(this.contextShowTemp, "contextShowTemp");
            this.contextShowTemp.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // contextShowPres
            // 
            this.contextShowPres.Name = "contextShowPres";
            resources.ApplyResources(this.contextShowPres, "contextShowPres");
            this.contextShowPres.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // contextShowHum
            // 
            this.contextShowHum.Name = "contextShowHum";
            resources.ApplyResources(this.contextShowHum, "contextShowHum");
            this.contextShowHum.Click += new System.EventHandler(this.OnShowChartClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // contextSelectAll
            // 
            this.contextSelectAll.Name = "contextSelectAll";
            resources.ApplyResources(this.contextSelectAll, "contextSelectAll");
            this.contextSelectAll.Click += new System.EventHandler(this.OnViewSelectAll);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.WorkSpace)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ChartContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.HeaderContextMenu.ResumeLayout(false);
            this.ContentContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WorkSpace;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton openToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton aboutToolbarButton;
        private System.Windows.Forms.ToolStripButton addDataToolbarButton;
        private System.Windows.Forms.ToolStripButton editDataToolbarButton;
        private System.Windows.Forms.ToolStripButton deleteDataToolbarButton;
        private System.Windows.Forms.ToolStripButton closeToolbarButton;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripButton newToolbarButton;
        private System.Windows.Forms.ToolStripButton saveToolbarButton;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempdryShowViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presShowViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windShowViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humShowViewMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInfoItemsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfoDateLast;
        private System.Windows.Forms.TextBox txtInfoDateFirst;
        private System.Windows.Forms.ToolStripMenuItem satShowViewMenuItem;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem dutyShowViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempwetShowViewMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem propsDataMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem textsViewMenuItem;
        private System.Windows.Forms.ContextMenuStrip HeaderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextTempDry;
        private System.Windows.Forms.ToolStripMenuItem contextTempWet;
        private System.Windows.Forms.ToolStripMenuItem contextPressure;
        private System.Windows.Forms.ToolStripMenuItem contextWind;
        private System.Windows.Forms.ToolStripMenuItem contextHumidity;
        private System.Windows.Forms.ToolStripMenuItem contextSaturation;
        private System.Windows.Forms.ToolStripMenuItem contextOnDuty;
        private System.Windows.Forms.ContextMenuStrip ContentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextEditItem;
        private System.Windows.Forms.ToolStripMenuItem contextDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem contextShowChart;
        private SplitButton btnShowChart;
        private System.Windows.Forms.ContextMenuStrip ChartContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tempChartContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presChartContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humChartContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem contextSelectAll;
        private System.Windows.Forms.ToolStripMenuItem contextShowTemp;
        private System.Windows.Forms.ToolStripMenuItem contextShowPres;
        private System.Windows.Forms.ToolStripMenuItem contextShowHum;
        private System.Windows.Forms.ToolStripMenuItem windRoseContextChartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempDry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTempWet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWind;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaturation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.Button btnPrint;
        private bool _bPrOpened = false;
        private System.Windows.Forms.ToolStripMenuItem ServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsServiceMenuItem;
    }
}