namespace MicroClimat.Forms
{
    partial class CreateProjectWizard
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
            this.wizard1 = new CristiPotlog.Controls.Wizard();
            this.wizardPage1 = new CristiPotlog.Controls.WizardPage();
            this.chbChangeName = new System.Windows.Forms.CheckBox();
            this.txtPathToFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wizardPage4 = new CristiPotlog.Controls.WizardPage();
            this.wizardPage3 = new CristiPotlog.Controls.WizardPage();
            this.lblTermTip = new System.Windows.Forms.Label();
            this.chbAnemometr = new System.Windows.Forms.CheckBox();
            this.chbTermometr = new System.Windows.Forms.CheckBox();
            this.chbPsixrometr = new System.Windows.Forms.CheckBox();
            this.chbBarometr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wizardPage2 = new CristiPotlog.Controls.WizardPage();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.colPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wizard1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.wizardPage3.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard1
            // 
            this.wizard1.Controls.Add(this.wizardPage4);
            this.wizard1.Controls.Add(this.wizardPage3);
            this.wizard1.Controls.Add(this.wizardPage2);
            this.wizard1.Controls.Add(this.wizardPage1);
            this.wizard1.HeaderImage = global::MicroClimat.Properties.Resources.MicroClimat;
            this.wizard1.Location = new System.Drawing.Point(0, 0);
            this.wizard1.Name = "wizard1";
            this.wizard1.Pages.AddRange(new CristiPotlog.Controls.WizardPage[] {
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4});
            this.wizard1.Size = new System.Drawing.Size(410, 294);
            this.wizard1.TabIndex = 0;
            this.wizard1.WelcomeImage = global::MicroClimat.Properties.Resources.FinishWizImg;
            this.wizard1.Finish += new System.EventHandler(this.FinishCreate);
            this.wizard1.AfterSwitchPages += new CristiPotlog.Controls.Wizard.AfterSwitchPagesEventHandler(this.CheckButtons);
            this.wizard1.BeforeSwitchPages += new CristiPotlog.Controls.Wizard.BeforeSwitchPagesEventHandler(this.CheckData);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.label3);
            this.wizardPage1.Controls.Add(this.txtProjectName);
            this.wizardPage1.Controls.Add(this.chbChangeName);
            this.wizardPage1.Controls.Add(this.txtPathToFile);
            this.wizardPage1.Controls.Add(this.btnBrowse);
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Description = "Шаг 1. Выбор файла.";
            this.wizardPage1.Location = new System.Drawing.Point(0, 0);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(410, 246);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Title = "Создание проекта";
            // 
            // chbChangeName
            // 
            this.chbChangeName.AutoSize = true;
            this.chbChangeName.Enabled = false;
            this.chbChangeName.Location = new System.Drawing.Point(12, 162);
            this.chbChangeName.Name = "chbChangeName";
            this.chbChangeName.Size = new System.Drawing.Size(249, 17);
            this.chbChangeName.TabIndex = 2;
            this.chbChangeName.Text = "Изменить имя файла на сегодняшнюю дату";
            this.chbChangeName.UseVisualStyleBackColor = true;
            this.chbChangeName.CheckedChanged += new System.EventHandler(this.ChbChangeNameCheckedChanged);
            // 
            // txtPathToFile
            // 
            this.txtPathToFile.Location = new System.Drawing.Point(12, 97);
            this.txtPathToFile.Name = "txtPathToFile";
            this.txtPathToFile.ReadOnly = true;
            this.txtPathToFile.Size = new System.Drawing.Size(305, 20);
            this.txtPathToFile.TabIndex = 2;
            this.txtPathToFile.TextChanged += new System.EventHandler(this.TxtPathToFileTextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(323, 95);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Обзор...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите путь к файлу для сохранения нового проекта:";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Description = "Создание проекта закончено";
            this.wizardPage4.Location = new System.Drawing.Point(0, 0);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(410, 246);
            this.wizardPage4.Style = CristiPotlog.Controls.WizardPageStyle.Finish;
            this.wizardPage4.TabIndex = 12;
            this.wizardPage4.Title = "Проект";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.lblTermTip);
            this.wizardPage3.Controls.Add(this.chbAnemometr);
            this.wizardPage3.Controls.Add(this.chbTermometr);
            this.wizardPage3.Controls.Add(this.chbPsixrometr);
            this.wizardPage3.Controls.Add(this.chbBarometr);
            this.wizardPage3.Controls.Add(this.label2);
            this.wizardPage3.Description = "Шаг 3. Приборы.";
            this.wizardPage3.Location = new System.Drawing.Point(0, 0);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(410, 246);
            this.wizardPage3.TabIndex = 0;
            this.wizardPage3.Title = "Создание проекта";
            // 
            // lblTermTip
            // 
            this.lblTermTip.AutoSize = true;
            this.lblTermTip.Location = new System.Drawing.Point(110, 120);
            this.lblTermTip.Name = "lblTermTip";
            this.lblTermTip.Size = new System.Drawing.Size(0, 13);
            this.lblTermTip.TabIndex = 5;
            // 
            // chbAnemometr
            // 
            this.chbAnemometr.AutoSize = true;
            this.chbAnemometr.Location = new System.Drawing.Point(16, 165);
            this.chbAnemometr.Name = "chbAnemometr";
            this.chbAnemometr.Size = new System.Drawing.Size(84, 17);
            this.chbAnemometr.TabIndex = 3;
            this.chbAnemometr.Text = "Анемометр";
            this.chbAnemometr.UseVisualStyleBackColor = true;
            // 
            // chbTermometr
            // 
            this.chbTermometr.AutoSize = true;
            this.chbTermometr.Location = new System.Drawing.Point(16, 142);
            this.chbTermometr.Name = "chbTermometr";
            this.chbTermometr.Size = new System.Drawing.Size(84, 17);
            this.chbTermometr.TabIndex = 2;
            this.chbTermometr.Text = "Термометр";
            this.chbTermometr.UseVisualStyleBackColor = true;
            // 
            // chbPsixrometr
            // 
            this.chbPsixrometr.AutoSize = true;
            this.chbPsixrometr.Location = new System.Drawing.Point(16, 119);
            this.chbPsixrometr.Name = "chbPsixrometr";
            this.chbPsixrometr.Size = new System.Drawing.Size(88, 17);
            this.chbPsixrometr.TabIndex = 1;
            this.chbPsixrometr.Text = "Психрометр";
            this.chbPsixrometr.UseVisualStyleBackColor = true;
            this.chbPsixrometr.CheckedChanged += new System.EventHandler(this.ChbPsixrometrCheckedChanged);
            // 
            // chbBarometr
            // 
            this.chbBarometr.AutoSize = true;
            this.chbBarometr.Location = new System.Drawing.Point(16, 96);
            this.chbBarometr.Name = "chbBarometr";
            this.chbBarometr.Size = new System.Drawing.Size(76, 17);
            this.chbBarometr.TabIndex = 0;
            this.chbBarometr.Text = "Барометр";
            this.chbBarometr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите приборы, которые вы собираетесь использовать в проекте:";
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.dgvParts);
            this.wizardPage2.Controls.Add(this.groupBox2);
            this.wizardPage2.Description = "Шаг 2. Руководитель и участники проекта.";
            this.wizardPage2.Location = new System.Drawing.Point(0, 0);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(410, 246);
            this.wizardPage2.TabIndex = 0;
            this.wizardPage2.Title = "Создание проекта";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPart});
            this.dgvParts.Location = new System.Drawing.Point(12, 131);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.Size = new System.Drawing.Size(386, 112);
            this.dgvParts.TabIndex = 0;
            // 
            // colPart
            // 
            this.colPart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPart.HeaderText = "Участники";
            this.colPart.Name = "colPart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtManager);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Руководитель проекта";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(7, 20);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(293, 20);
            this.txtManager.TabIndex = 0;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(12, 136);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(143, 20);
            this.txtProjectName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите имя нового проекта:";
            // 
            // CreateProjectWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.ControlBox = false;
            this.Controls.Add(this.wizard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProjectWizard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мастер создания нового проекта";
            this.wizard1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            this.wizardPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CristiPotlog.Controls.Wizard wizard1;
        private CristiPotlog.Controls.WizardPage wizardPage1;
        private CristiPotlog.Controls.WizardPage wizardPage2;
        private CristiPotlog.Controls.WizardPage wizardPage3;
        private CristiPotlog.Controls.WizardPage wizardPage4;
        private System.Windows.Forms.TextBox txtPathToFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPart;
        private System.Windows.Forms.CheckBox chbChangeName;
        private System.Windows.Forms.CheckBox chbAnemometr;
        private System.Windows.Forms.CheckBox chbTermometr;
        private System.Windows.Forms.CheckBox chbPsixrometr;
        private System.Windows.Forms.CheckBox chbBarometr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTermTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectName;

    }
}