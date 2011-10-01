namespace MicroClimat.Forms
{
    partial class ProjectPropertiesForm
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.colPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.tabPageGadgets = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTermTip = new System.Windows.Forms.Label();
            this.chbAnemometr = new System.Windows.Forms.CheckBox();
            this.chbTermometr = new System.Windows.Forms.CheckBox();
            this.chbPsixrometr = new System.Windows.Forms.CheckBox();
            this.chbBarometr = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageMembers.SuspendLayout();
            this.tabPageGadgets.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToResizeColumns = false;
            this.dgvParts.AllowUserToResizeRows = false;
            this.dgvParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPart});
            this.dgvParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvParts.Location = new System.Drawing.Point(6, 33);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(343, 207);
            this.dgvParts.TabIndex = 2;
            this.dgvParts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChanged);
            this.dgvParts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvChanged);
            this.dgvParts.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvChanged);
            this.dgvParts.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // colPart
            // 
            this.colPart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPart.HeaderText = "Участники проекта";
            this.colPart.Name = "colPart";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(335, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(254, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMembers);
            this.tabControl1.Controls.Add(this.tabPageGadgets);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 272);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMembers.Controls.Add(this.btnEditMember);
            this.tabPageMembers.Controls.Add(this.btnDeleteMember);
            this.tabPageMembers.Controls.Add(this.btnAddMember);
            this.tabPageMembers.Controls.Add(this.label1);
            this.tabPageMembers.Controls.Add(this.txtManager);
            this.tabPageMembers.Controls.Add(this.dgvParts);
            this.tabPageMembers.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(394, 246);
            this.tabPageMembers.TabIndex = 0;
            this.tabPageMembers.Text = "Участники";
            // 
            // btnEditMember
            // 
            this.btnEditMember.Enabled = false;
            this.btnEditMember.Image = global::MicroClimat.Properties.Resources.EditMember;
            this.btnEditMember.Location = new System.Drawing.Point(355, 108);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(32, 32);
            this.btnEditMember.TabIndex = 5;
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.BtnEditMemberClick);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Enabled = false;
            this.btnDeleteMember.Image = global::MicroClimat.Properties.Resources.DeleteMember;
            this.btnDeleteMember.Location = new System.Drawing.Point(355, 70);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteMember.TabIndex = 4;
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.BtnDeleteMemberClick);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Image = global::MicroClimat.Properties.Resources.AddMember;
            this.btnAddMember.Location = new System.Drawing.Point(355, 33);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(32, 32);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.BtnAddMemberClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Руководитель проекта:";
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(137, 7);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(250, 20);
            this.txtManager.TabIndex = 1;
            this.txtManager.TextChanged += new System.EventHandler(this.OnDataChanged);
            // 
            // tabPageGadgets
            // 
            this.tabPageGadgets.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageGadgets.Controls.Add(this.label2);
            this.tabPageGadgets.Controls.Add(this.lblTermTip);
            this.tabPageGadgets.Controls.Add(this.chbAnemometr);
            this.tabPageGadgets.Controls.Add(this.chbTermometr);
            this.tabPageGadgets.Controls.Add(this.chbPsixrometr);
            this.tabPageGadgets.Controls.Add(this.chbBarometr);
            this.tabPageGadgets.Location = new System.Drawing.Point(4, 22);
            this.tabPageGadgets.Name = "tabPageGadgets";
            this.tabPageGadgets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGadgets.Size = new System.Drawing.Size(394, 246);
            this.tabPageGadgets.TabIndex = 1;
            this.tabPageGadgets.Text = "Приборы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите приборы, которые вы используете в проекте:";
            // 
            // lblTermTip
            // 
            this.lblTermTip.AutoSize = true;
            this.lblTermTip.Location = new System.Drawing.Point(97, 50);
            this.lblTermTip.Name = "lblTermTip";
            this.lblTermTip.Size = new System.Drawing.Size(0, 13);
            this.lblTermTip.TabIndex = 5;
            // 
            // chbAnemometr
            // 
            this.chbAnemometr.AutoSize = true;
            this.chbAnemometr.Location = new System.Drawing.Point(9, 95);
            this.chbAnemometr.Name = "chbAnemometr";
            this.chbAnemometr.Size = new System.Drawing.Size(84, 17);
            this.chbAnemometr.TabIndex = 4;
            this.chbAnemometr.Text = "Анемометр";
            this.chbAnemometr.UseVisualStyleBackColor = true;
            this.chbAnemometr.CheckedChanged += new System.EventHandler(this.OnDataChanged);
            // 
            // chbTermometr
            // 
            this.chbTermometr.AutoSize = true;
            this.chbTermometr.Location = new System.Drawing.Point(9, 72);
            this.chbTermometr.Name = "chbTermometr";
            this.chbTermometr.Size = new System.Drawing.Size(84, 17);
            this.chbTermometr.TabIndex = 3;
            this.chbTermometr.Text = "Термометр";
            this.chbTermometr.UseVisualStyleBackColor = true;
            this.chbTermometr.CheckedChanged += new System.EventHandler(this.OnDataChanged);
            // 
            // chbPsixrometr
            // 
            this.chbPsixrometr.AutoSize = true;
            this.chbPsixrometr.Location = new System.Drawing.Point(9, 49);
            this.chbPsixrometr.Name = "chbPsixrometr";
            this.chbPsixrometr.Size = new System.Drawing.Size(88, 17);
            this.chbPsixrometr.TabIndex = 2;
            this.chbPsixrometr.Text = "Психрометр";
            this.chbPsixrometr.UseVisualStyleBackColor = true;
            this.chbPsixrometr.CheckedChanged += new System.EventHandler(this.ChbPsixrometrCheckedChanged);
            // 
            // chbBarometr
            // 
            this.chbBarometr.AutoSize = true;
            this.chbBarometr.Location = new System.Drawing.Point(9, 26);
            this.chbBarometr.Name = "chbBarometr";
            this.chbBarometr.Size = new System.Drawing.Size(76, 17);
            this.chbBarometr.TabIndex = 1;
            this.chbBarometr.Text = "Барометр";
            this.chbBarometr.UseVisualStyleBackColor = true;
            this.chbBarometr.CheckedChanged += new System.EventHandler(this.OnDataChanged);
            // 
            // ProjectPropertiesForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(425, 323);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectPropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства проекта";
            this.Load += new System.EventHandler(this.MembersFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMembers.ResumeLayout(false);
            this.tabPageMembers.PerformLayout();
            this.tabPageGadgets.ResumeLayout(false);
            this.tabPageGadgets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMembers;
        private System.Windows.Forms.TabPage tabPageGadgets;
        private System.Windows.Forms.CheckBox chbAnemometr;
        private System.Windows.Forms.CheckBox chbTermometr;
        private System.Windows.Forms.CheckBox chbPsixrometr;
        private System.Windows.Forms.CheckBox chbBarometr;
        private System.Windows.Forms.Label lblTermTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnAddMember;
    }
}