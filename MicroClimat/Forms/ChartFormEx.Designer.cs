using MicroClimat.Controls;

namespace MicroClimat.Forms
{
    partial class ChartFormEx
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
            this.mainChart = new ZedGraph.ZedGraphControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.chartOutContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btтChartOut = new SplitButton();
            this.chartOutContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainChart.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.mainChart.IsEnableHPan = false;
            this.mainChart.IsEnableHZoom = false;
            this.mainChart.IsEnableVPan = false;
            this.mainChart.IsEnableVZoom = false;
            this.mainChart.IsEnableWheelZoom = false;
            this.mainChart.IsShowContextMenu = false;
            this.mainChart.IsShowCopyMessage = false;
            this.mainChart.IsShowPointValues = true;
            this.mainChart.LinkButtons = System.Windows.Forms.MouseButtons.None;
            this.mainChart.Location = new System.Drawing.Point(13, 13);
            this.mainChart.Name = "mainChart";
            this.mainChart.ScrollGrace = 0;
            this.mainChart.ScrollMaxX = 0;
            this.mainChart.ScrollMaxY = 0;
            this.mainChart.ScrollMaxY2 = 0;
            this.mainChart.ScrollMinX = 0;
            this.mainChart.ScrollMinY = 0;
            this.mainChart.ScrollMinY2 = 0;
            this.mainChart.Size = new System.Drawing.Size(657, 352);
            this.mainChart.TabIndex = 0;
            this.mainChart.ZoomButtons = System.Windows.Forms.MouseButtons.None;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(595, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // chartOutContextMenu
            // 
            this.chartOutContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.printMenuItem});
            this.chartOutContextMenu.Name = "chartOutContextMenu";
            this.chartOutContextMenu.Size = new System.Drawing.Size(183, 48);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveMenuItem.Text = "Сохранить в файл...";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItemClick);
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.Size = new System.Drawing.Size(182, 22);
            this.printMenuItem.Text = "Печать...";
            this.printMenuItem.Click += new System.EventHandler(this.PrintMenuItemClick);
            // 
            // btтChartOut
            // 
            this.btтChartOut.AlwaysDropDown = true;
            this.btтChartOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btтChartOut.ClickedImage = "SplitButtonClickedImage.gif";
            this.btтChartOut.ContextMenuStrip = this.chartOutContextMenu;
            this.btтChartOut.DisabledImage = "SplitButtonDisabledImage.gif";
            this.btтChartOut.FocusedImage = "Focused";
            this.btтChartOut.HoverImage = "SplitButtonHoverImage.gif";
            this.btтChartOut.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btтChartOut.ImageKey = "SplitButtonImage.gif";
            this.btтChartOut.Location = new System.Drawing.Point(458, 371);
            this.btтChartOut.Name = "btтChartOut";
            this.btтChartOut.NormalImage = "SplitButtonImage.gif";
            this.btтChartOut.Size = new System.Drawing.Size(131, 34);
            this.btтChartOut.TabIndex = 8;
            this.btтChartOut.Text = "Вывод графика";
            this.btтChartOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btтChartOut.UseVisualStyleBackColor = true;
            // 
            // ChartFormEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 417);
            this.Controls.Add(this.btтChartOut);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mainChart);
            this.MinimizeBox = false;
            this.Name = "ChartFormEx";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "График изменения";
            this.chartOutContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl mainChart;
        private System.Windows.Forms.Button btnClose;
        private SplitButton btтChartOut;
        private System.Windows.Forms.ContextMenuStrip chartOutContextMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
    }
}