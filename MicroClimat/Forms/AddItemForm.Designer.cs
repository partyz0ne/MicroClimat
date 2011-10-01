namespace MicroClimat.Forms
{
    partial class AddItemForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTypeStation = new System.Windows.Forms.RadioButton();
            this.rbTypeAspir = new System.Windows.Forms.RadioButton();
            this.chbIce = new System.Windows.Forms.CheckBox();
            this.rbMM = new System.Windows.Forms.RadioButton();
            this.rbBar = new System.Windows.Forms.RadioButton();
            this.txtPressureMM = new System.Windows.Forms.TextBox();
            this.txtPressureBar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResHum = new System.Windows.Forms.TextBox();
            this.txtResSat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbAnemometr = new System.Windows.Forms.CheckBox();
            this.cmbWindDirect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chbPsixrometr = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudTempWet = new System.Windows.Forms.NumericUpDown();
            this.nudTempDry = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chbBarometr = new System.Windows.Forms.CheckBox();
            this.chbListOnDuty = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.chbTermometr = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempWet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempDry)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура сухого, °C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Температура смоченного, °C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Давление:";
            // 
            // rbTypeStation
            // 
            this.rbTypeStation.AutoSize = true;
            this.rbTypeStation.Enabled = false;
            this.rbTypeStation.Location = new System.Drawing.Point(175, 77);
            this.rbTypeStation.Name = "rbTypeStation";
            this.rbTypeStation.Size = new System.Drawing.Size(138, 17);
            this.rbTypeStation.TabIndex = 7;
            this.rbTypeStation.Text = "станционный (0,8 м/с)";
            this.rbTypeStation.UseVisualStyleBackColor = true;
            this.rbTypeStation.CheckedChanged += new System.EventHandler(this.RbTypeStationCheckedChanged);
            // 
            // rbTypeAspir
            // 
            this.rbTypeAspir.AutoSize = true;
            this.rbTypeAspir.Checked = true;
            this.rbTypeAspir.Enabled = false;
            this.rbTypeAspir.Location = new System.Drawing.Point(9, 77);
            this.rbTypeAspir.Name = "rbTypeAspir";
            this.rbTypeAspir.Size = new System.Drawing.Size(142, 17);
            this.rbTypeAspir.TabIndex = 6;
            this.rbTypeAspir.TabStop = true;
            this.rbTypeAspir.Text = "аспирационный (2 м/с)";
            this.rbTypeAspir.UseVisualStyleBackColor = true;
            this.rbTypeAspir.CheckedChanged += new System.EventHandler(this.RbTypeAspirCheckedChanged);
            // 
            // chbIce
            // 
            this.chbIce.AutoSize = true;
            this.chbIce.Enabled = false;
            this.chbIce.Location = new System.Drawing.Point(274, 51);
            this.chbIce.Name = "chbIce";
            this.chbIce.Size = new System.Drawing.Size(44, 17);
            this.chbIce.TabIndex = 5;
            this.chbIce.Text = "лёд";
            this.chbIce.UseVisualStyleBackColor = true;
            this.chbIce.CheckedChanged += new System.EventHandler(this.ChbIceCheckedChanged);
            // 
            // rbMM
            // 
            this.rbMM.AutoSize = true;
            this.rbMM.Checked = true;
            this.rbMM.Enabled = false;
            this.rbMM.Location = new System.Drawing.Point(73, 50);
            this.rbMM.Name = "rbMM";
            this.rbMM.Size = new System.Drawing.Size(75, 17);
            this.rbMM.TabIndex = 4;
            this.rbMM.TabStop = true;
            this.rbMM.Text = "мм рт. ст.";
            this.rbMM.UseVisualStyleBackColor = true;
            this.rbMM.CheckedChanged += new System.EventHandler(this.PressureCheckedChanged);
            // 
            // rbBar
            // 
            this.rbBar.AutoSize = true;
            this.rbBar.Enabled = false;
            this.rbBar.Location = new System.Drawing.Point(73, 24);
            this.rbBar.Name = "rbBar";
            this.rbBar.Size = new System.Drawing.Size(51, 17);
            this.rbBar.TabIndex = 2;
            this.rbBar.Text = "мбар";
            this.rbBar.UseVisualStyleBackColor = true;
            this.rbBar.CheckedChanged += new System.EventHandler(this.PressureCheckedChanged);
            // 
            // txtPressureMM
            // 
            this.txtPressureMM.Enabled = false;
            this.txtPressureMM.Location = new System.Drawing.Point(168, 50);
            this.txtPressureMM.Name = "txtPressureMM";
            this.txtPressureMM.Size = new System.Drawing.Size(100, 20);
            this.txtPressureMM.TabIndex = 5;
            this.txtPressureMM.Text = "0";
            this.txtPressureMM.Leave += new System.EventHandler(this.RecalcPresuure);
            // 
            // txtPressureBar
            // 
            this.txtPressureBar.Enabled = false;
            this.txtPressureBar.Location = new System.Drawing.Point(168, 23);
            this.txtPressureBar.Name = "txtPressureBar";
            this.txtPressureBar.Size = new System.Drawing.Size(100, 20);
            this.txtPressureBar.TabIndex = 3;
            this.txtPressureBar.Leave += new System.EventHandler(this.RecalcPresuure);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtResHum);
            this.groupBox2.Controls.Add(this.txtResSat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты по влажности воздуха";
            // 
            // txtResHum
            // 
            this.txtResHum.BackColor = System.Drawing.SystemColors.Control;
            this.txtResHum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResHum.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResHum.Location = new System.Drawing.Point(205, 18);
            this.txtResHum.Name = "txtResHum";
            this.txtResHum.ReadOnly = true;
            this.txtResHum.Size = new System.Drawing.Size(100, 20);
            this.txtResHum.TabIndex = 1;
            // 
            // txtResSat
            // 
            this.txtResSat.BackColor = System.Drawing.SystemColors.Control;
            this.txtResSat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResSat.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResSat.Location = new System.Drawing.Point(205, 44);
            this.txtResSat.Name = "txtResSat";
            this.txtResSat.ReadOnly = true;
            this.txtResSat.Size = new System.Drawing.Size(100, 20);
            this.txtResSat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Недостаточность насыщения, г/м3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Относительная влажность, %:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(511, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(430, 316);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalcClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(592, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbAnemometr);
            this.groupBox4.Controls.Add(this.cmbWindDirect);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nudWindSpeed);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(344, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // chbAnemometr
            // 
            this.chbAnemometr.AutoSize = true;
            this.chbAnemometr.Location = new System.Drawing.Point(6, 1);
            this.chbAnemometr.Name = "chbAnemometr";
            this.chbAnemometr.Size = new System.Drawing.Size(84, 17);
            this.chbAnemometr.TabIndex = 0;
            this.chbAnemometr.Text = "&Анемометр";
            this.chbAnemometr.UseVisualStyleBackColor = true;
            this.chbAnemometr.CheckedChanged += new System.EventHandler(this.ChbAnemometrCheckedChanged);
            // 
            // cmbWindDirect
            // 
            this.cmbWindDirect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWindDirect.Enabled = false;
            this.cmbWindDirect.FormattingEnabled = true;
            this.cmbWindDirect.Items.AddRange(new object[] {
            "с",
            "с/в",
            "в",
            "ю/в",
            "ю",
            "ю/з",
            "з",
            "с/з"});
            this.cmbWindDirect.Location = new System.Drawing.Point(245, 18);
            this.cmbWindDirect.Name = "cmbWindDirect";
            this.cmbWindDirect.Size = new System.Drawing.Size(72, 21);
            this.cmbWindDirect.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Направление:";
            // 
            // nudWindSpeed
            // 
            this.nudWindSpeed.DecimalPlaces = 1;
            this.nudWindSpeed.Enabled = false;
            this.nudWindSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWindSpeed.Location = new System.Drawing.Point(95, 19);
            this.nudWindSpeed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWindSpeed.Name = "nudWindSpeed";
            this.nudWindSpeed.Size = new System.Drawing.Size(55, 20);
            this.nudWindSpeed.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Скорость, м/с:";
            // 
            // chbPsixrometr
            // 
            this.chbPsixrometr.AutoSize = true;
            this.chbPsixrometr.Location = new System.Drawing.Point(6, 0);
            this.chbPsixrometr.Name = "chbPsixrometr";
            this.chbPsixrometr.Size = new System.Drawing.Size(88, 17);
            this.chbPsixrometr.TabIndex = 0;
            this.chbPsixrometr.Text = "&Психрометр";
            this.chbPsixrometr.UseVisualStyleBackColor = true;
            this.chbPsixrometr.CheckedChanged += new System.EventHandler(this.ChbPsixrometrCheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudTempWet);
            this.groupBox5.Controls.Add(this.nudTempDry);
            this.groupBox5.Controls.Add(this.rbTypeAspir);
            this.groupBox5.Controls.Add(this.rbTypeStation);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.chbPsixrometr);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.chbIce);
            this.groupBox5.Location = new System.Drawing.Point(13, 153);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 106);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // nudTempWet
            // 
            this.nudTempWet.DecimalPlaces = 1;
            this.nudTempWet.Enabled = false;
            this.nudTempWet.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudTempWet.Location = new System.Drawing.Point(168, 50);
            this.nudTempWet.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudTempWet.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nudTempWet.Name = "nudTempWet";
            this.nudTempWet.Size = new System.Drawing.Size(100, 20);
            this.nudTempWet.TabIndex = 4;
            this.nudTempWet.ValueChanged += new System.EventHandler(this.NudTempWetValueChanged);
            // 
            // nudTempDry
            // 
            this.nudTempDry.DecimalPlaces = 1;
            this.nudTempDry.Enabled = false;
            this.nudTempDry.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudTempDry.Location = new System.Drawing.Point(168, 19);
            this.nudTempDry.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudTempDry.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nudTempDry.Name = "nudTempDry";
            this.nudTempDry.Size = new System.Drawing.Size(100, 20);
            this.nudTempDry.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbMM);
            this.groupBox6.Controls.Add(this.chbBarometr);
            this.groupBox6.Controls.Add(this.rbBar);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtPressureMM);
            this.groupBox6.Controls.Add(this.txtPressureBar);
            this.groupBox6.Location = new System.Drawing.Point(13, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 81);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // chbBarometr
            // 
            this.chbBarometr.AutoSize = true;
            this.chbBarometr.Location = new System.Drawing.Point(6, 0);
            this.chbBarometr.Name = "chbBarometr";
            this.chbBarometr.Size = new System.Drawing.Size(76, 17);
            this.chbBarometr.TabIndex = 0;
            this.chbBarometr.Text = "&Барометр";
            this.chbBarometr.UseVisualStyleBackColor = true;
            this.chbBarometr.CheckedChanged += new System.EventHandler(this.ChbBarometrCheckedChanged);
            // 
            // chbListOnDuty
            // 
            this.chbListOnDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chbListOnDuty.CheckOnClick = true;
            this.chbListOnDuty.FormattingEnabled = true;
            this.chbListOnDuty.Location = new System.Drawing.Point(8, 19);
            this.chbListOnDuty.Name = "chbListOnDuty";
            this.chbListOnDuty.Size = new System.Drawing.Size(271, 169);
            this.chbListOnDuty.TabIndex = 0;
            this.chbListOnDuty.SelectedIndexChanged += new System.EventHandler(this.ChbListOnDutySelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMember);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.chbListOnDuty);
            this.groupBox1.Location = new System.Drawing.Point(344, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дежурные";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Enabled = false;
            this.btnDeleteMember.Image = global::MicroClimat.Properties.Resources.DeleteMember;
            this.btnDeleteMember.Location = new System.Drawing.Point(285, 56);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.BtnDeleteMemberClick);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Image = global::MicroClimat.Properties.Resources.AddMember;
            this.btnAddMember.Location = new System.Drawing.Point(285, 19);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(32, 32);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMemberClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtTime);
            this.groupBox3.Controls.Add(this.dtDate);
            this.groupBox3.Location = new System.Drawing.Point(344, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 44);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дата и время наблюдения";
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "HH:mm";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(167, 17);
            this.dtTime.Name = "dtTime";
            this.dtTime.ShowUpDown = true;
            this.dtTime.Size = new System.Drawing.Size(54, 20);
            this.dtTime.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(6, 17);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(155, 20);
            this.dtDate.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.nudTemp);
            this.groupBox7.Controls.Add(this.chbTermometr);
            this.groupBox7.Location = new System.Drawing.Point(13, 100);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(324, 47);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Температура воздуха, °C:";
            // 
            // nudTemp
            // 
            this.nudTemp.DecimalPlaces = 1;
            this.nudTemp.Enabled = false;
            this.nudTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTemp.Location = new System.Drawing.Point(168, 19);
            this.nudTemp.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudTemp.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.Size = new System.Drawing.Size(100, 20);
            this.nudTemp.TabIndex = 3;
            // 
            // chbTermometr
            // 
            this.chbTermometr.AutoSize = true;
            this.chbTermometr.Location = new System.Drawing.Point(6, -1);
            this.chbTermometr.Name = "chbTermometr";
            this.chbTermometr.Size = new System.Drawing.Size(84, 17);
            this.chbTermometr.TabIndex = 0;
            this.chbTermometr.Text = "Термометр";
            this.chbTermometr.UseVisualStyleBackColor = true;
            this.chbTermometr.CheckedChanged += new System.EventHandler(this.ChbTermometrCheckedChanged);
            // 
            // AddItemForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(681, 353);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Данные наблюдения";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempWet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempDry)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTypeStation;
        private System.Windows.Forms.RadioButton rbTypeAspir;
        private System.Windows.Forms.CheckBox chbIce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPressureMM;
        private System.Windows.Forms.TextBox txtPressureBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMM;
        private System.Windows.Forms.RadioButton rbBar;
        private System.Windows.Forms.TextBox txtResHum;
        private System.Windows.Forms.TextBox txtResSat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudWindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbWindDirect;
        private System.Windows.Forms.CheckBox chbPsixrometr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chbBarometr;
        private System.Windows.Forms.CheckBox chbAnemometr;
        private System.Windows.Forms.CheckedListBox chbListOnDuty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudTempDry;
        private System.Windows.Forms.NumericUpDown nudTempWet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.CheckBox chbTermometr;


    }
}

