namespace CourseProject_ShowDesk
{
    partial class ManagePerformancesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPerformances = new System.Windows.Forms.DataGridView();
            this.menuStripManagePerformance = new System.Windows.Forms.MenuStrip();
            this.spectacleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnPerformanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPerformanceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTicketsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).BeginInit();
            this.menuStripManagePerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPerformances
            // 
            this.dataGridViewPerformances.AllowUserToAddRows = false;
            this.dataGridViewPerformances.AllowUserToDeleteRows = false;
            this.dataGridViewPerformances.AllowUserToResizeRows = false;
            this.dataGridViewPerformances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPerformances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerformances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPerformances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerformances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPerformanceDate,
            this.ColumnPerformanceTime,
            this.columnName,
            this.columnPrice,
            this.columnStage,
            this.columnTicketsCount,
            this.columnSold,
            this.columnReserved});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerformances.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPerformances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPerformances.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewPerformances.MultiSelect = false;
            this.dataGridViewPerformances.Name = "dataGridViewPerformances";
            this.dataGridViewPerformances.ReadOnly = true;
            this.dataGridViewPerformances.RowHeadersVisible = false;
            this.dataGridViewPerformances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerformances.Size = new System.Drawing.Size(690, 243);
            this.dataGridViewPerformances.TabIndex = 3;
            this.dataGridViewPerformances.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerformances_RowEnter);
            this.dataGridViewPerformances.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerformances_RowLeave);
            // 
            // menuStripManagePerformance
            // 
            this.menuStripManagePerformance.BackColor = System.Drawing.Color.Teal;
            this.menuStripManagePerformance.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripManagePerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spectacleToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStripManagePerformance.Location = new System.Drawing.Point(0, 0);
            this.menuStripManagePerformance.Name = "menuStripManagePerformance";
            this.menuStripManagePerformance.Size = new System.Drawing.Size(158, 26);
            this.menuStripManagePerformance.TabIndex = 4;
            this.menuStripManagePerformance.Text = "menuStripManagePerformance";
            // 
            // spectacleToolStripMenuItem
            // 
            this.spectacleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpecToolStripMenuItem,
            this.editSpecToolStripMenuItem,
            this.removeSpecToolStripMenuItem});
            this.spectacleToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spectacleToolStripMenuItem.Name = "spectacleToolStripMenuItem";
            this.spectacleToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.spectacleToolStripMenuItem.Text = "Спектакль";
            // 
            // addSpecToolStripMenuItem
            // 
            this.addSpecToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSpecToolStripMenuItem.Name = "addSpecToolStripMenuItem";
            this.addSpecToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addSpecToolStripMenuItem.Text = "Добавить";
            this.addSpecToolStripMenuItem.Click += new System.EventHandler(this.addSpecToolStripMenuItem_Click);
            // 
            // editSpecToolStripMenuItem
            // 
            this.editSpecToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSpecToolStripMenuItem.Name = "editSpecToolStripMenuItem";
            this.editSpecToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.editSpecToolStripMenuItem.Text = "Изменить";
            this.editSpecToolStripMenuItem.Click += new System.EventHandler(this.editSpecToolStripMenuItem_Click);
            // 
            // removeSpecToolStripMenuItem
            // 
            this.removeSpecToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSpecToolStripMenuItem.Name = "removeSpecToolStripMenuItem";
            this.removeSpecToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.removeSpecToolStripMenuItem.Text = "Удалить";
            this.removeSpecToolStripMenuItem.Click += new System.EventHandler(this.removeSpecToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.reportToolStripMenuItem.Text = "Отчет";
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.revenueReportToolStripMenuItem.Text = "Отчет о прибыли";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // columnPerformanceDate
            // 
            this.columnPerformanceDate.HeaderText = "Date";
            this.columnPerformanceDate.Name = "columnPerformanceDate";
            this.columnPerformanceDate.ReadOnly = true;
            // 
            // ColumnPerformanceTime
            // 
            this.ColumnPerformanceTime.HeaderText = "Time";
            this.ColumnPerformanceTime.Name = "ColumnPerformanceTime";
            this.ColumnPerformanceTime.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnStage
            // 
            this.columnStage.HeaderText = "Stage";
            this.columnStage.Name = "columnStage";
            this.columnStage.ReadOnly = true;
            // 
            // columnTicketsCount
            // 
            this.columnTicketsCount.HeaderText = "Tickets count";
            this.columnTicketsCount.Name = "columnTicketsCount";
            this.columnTicketsCount.ReadOnly = true;
            // 
            // columnSold
            // 
            this.columnSold.HeaderText = "Sold";
            this.columnSold.Name = "columnSold";
            this.columnSold.ReadOnly = true;
            // 
            // columnReserved
            // 
            this.columnReserved.HeaderText = "Reserved";
            this.columnReserved.Name = "columnReserved";
            this.columnReserved.ReadOnly = true;
            // 
            // ManagePerformancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 306);
            this.Controls.Add(this.dataGridViewPerformances);
            this.Controls.Add(this.menuStripManagePerformance);
            this.Name = "ManagePerformancesForm";
            this.Text = "ManagePerformanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagePerformancesFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerformances)).EndInit();
            this.menuStripManagePerformance.ResumeLayout(false);
            this.menuStripManagePerformance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPerformances;
        private System.Windows.Forms.MenuStrip menuStripManagePerformance;
        private System.Windows.Forms.ToolStripMenuItem spectacleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPerformanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPerformanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTicketsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReserved;
    }
}