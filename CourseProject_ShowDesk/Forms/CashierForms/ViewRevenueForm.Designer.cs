namespace CourseProject_ShowDesk.Forms.CashierForms
{
    partial class ViewRevenueForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRevenueForm));
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinishDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.buttonSavePdf = new System.Windows.Forms.Button();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.labelChartType = new System.Windows.Forms.Label();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxRevenue = new System.Windows.Forms.GroupBox();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.groupBoxAdditionalParameter = new System.Windows.Forms.GroupBox();
            this.labelCurrency2 = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxWorstPerformance = new System.Windows.Forms.TextBox();
            this.labelWorstPerformance = new System.Windows.Forms.Label();
            this.textBoxBestPerformance = new System.Windows.Forms.TextBox();
            this.labelBestPerformance = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxAdditionalParameter.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(126, 30);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(181, 28);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.DateTimePickerFrom_ValueChanged);
            this.dateTimePickerStartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerStartDate_KeyUp);
            // 
            // dateTimePickerFinishDate
            // 
            this.dateTimePickerFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinishDate.Location = new System.Drawing.Point(126, 64);
            this.dateTimePickerFinishDate.Name = "dateTimePickerFinishDate";
            this.dateTimePickerFinishDate.Size = new System.Drawing.Size(181, 28);
            this.dateTimePickerFinishDate.TabIndex = 1;
            this.dateTimePickerFinishDate.ValueChanged += new System.EventHandler(this.DateTimePickerTo_ValueChanged);
            this.dateTimePickerFinishDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateTimePickerFinishDate_KeyUp);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPeriod.Controls.Add(this.buttonSavePdf);
            this.groupBoxPeriod.Controls.Add(this.comboBoxChartType);
            this.groupBoxPeriod.Controls.Add(this.labelChartType);
            this.groupBoxPeriod.Controls.Add(this.labelFinishDate);
            this.groupBoxPeriod.Controls.Add(this.labelStartDate);
            this.groupBoxPeriod.Controls.Add(this.buttonCalculate);
            this.groupBoxPeriod.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxPeriod.Controls.Add(this.dateTimePickerFinishDate);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(6, 19);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(313, 195);
            this.groupBoxPeriod.TabIndex = 6;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // buttonSavePdf
            // 
            this.buttonSavePdf.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSavePdf.Location = new System.Drawing.Point(185, 149);
            this.buttonSavePdf.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.buttonSavePdf.Name = "buttonSavePdf";
            this.buttonSavePdf.Size = new System.Drawing.Size(120, 40);
            this.buttonSavePdf.TabIndex = 6;
            this.buttonSavePdf.Text = "Save as pdf";
            this.buttonSavePdf.UseVisualStyleBackColor = false;
            this.buttonSavePdf.Click += new System.EventHandler(this.ButtonSavePdf_Click);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(126, 98);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(181, 29);
            this.comboBoxChartType.TabIndex = 2;
            // 
            // labelChartType
            // 
            this.labelChartType.AutoSize = true;
            this.labelChartType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartType.Location = new System.Drawing.Point(21, 106);
            this.labelChartType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelChartType.Name = "labelChartType";
            this.labelChartType.Size = new System.Drawing.Size(90, 21);
            this.labelChartType.TabIndex = 5;
            this.labelChartType.Text = "Chart type";
            // 
            // labelFinishDate
            // 
            this.labelFinishDate.AutoSize = true;
            this.labelFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinishDate.Location = new System.Drawing.Point(21, 70);
            this.labelFinishDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelFinishDate.Name = "labelFinishDate";
            this.labelFinishDate.Size = new System.Drawing.Size(99, 21);
            this.labelFinishDate.TabIndex = 4;
            this.labelFinishDate.Text = "Finish date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(23, 37);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 21);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start date";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCalculate.Location = new System.Drawing.Point(25, 149);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 40);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // groupBoxRevenue
            // 
            this.groupBoxRevenue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxRevenue.Controls.Add(this.chartRevenue);
            this.groupBoxRevenue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRevenue.Location = new System.Drawing.Point(325, 19);
            this.groupBoxRevenue.Name = "groupBoxRevenue";
            this.groupBoxRevenue.Size = new System.Drawing.Size(606, 418);
            this.groupBoxRevenue.TabIndex = 7;
            this.groupBoxRevenue.TabStop = false;
            this.groupBoxRevenue.Text = "Revenue";
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRevenue.BackColor = System.Drawing.Color.Transparent;
            this.chartRevenue.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.Title = "Revenue";
            legend1.TitleFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(9, 30);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(591, 388);
            this.chartRevenue.TabIndex = 8;
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxForm.Controls.Add(this.groupBoxAdditionalParameter);
            this.groupBoxForm.Controls.Add(this.groupBoxPeriod);
            this.groupBoxForm.Controls.Add(this.groupBoxRevenue);
            this.groupBoxForm.Location = new System.Drawing.Point(-1, 65);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(951, 453);
            this.groupBoxForm.TabIndex = 8;
            this.groupBoxForm.TabStop = false;
            // 
            // groupBoxAdditionalParameter
            // 
            this.groupBoxAdditionalParameter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxAdditionalParameter.Controls.Add(this.labelCurrency2);
            this.groupBoxAdditionalParameter.Controls.Add(this.labelCurrency);
            this.groupBoxAdditionalParameter.Controls.Add(this.textBoxWorstPerformance);
            this.groupBoxAdditionalParameter.Controls.Add(this.labelWorstPerformance);
            this.groupBoxAdditionalParameter.Controls.Add(this.textBoxBestPerformance);
            this.groupBoxAdditionalParameter.Controls.Add(this.labelBestPerformance);
            this.groupBoxAdditionalParameter.Controls.Add(this.textBoxAverage);
            this.groupBoxAdditionalParameter.Controls.Add(this.labelAverage);
            this.groupBoxAdditionalParameter.Controls.Add(this.textBoxSum);
            this.groupBoxAdditionalParameter.Controls.Add(this.labelSum);
            this.groupBoxAdditionalParameter.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdditionalParameter.Location = new System.Drawing.Point(7, 221);
            this.groupBoxAdditionalParameter.Name = "groupBoxAdditionalParameter";
            this.groupBoxAdditionalParameter.Size = new System.Drawing.Size(312, 216);
            this.groupBoxAdditionalParameter.TabIndex = 8;
            this.groupBoxAdditionalParameter.TabStop = false;
            this.groupBoxAdditionalParameter.Text = "Additional parameter";
            // 
            // labelCurrency2
            // 
            this.labelCurrency2.AutoSize = true;
            this.labelCurrency2.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency2.Location = new System.Drawing.Point(282, 66);
            this.labelCurrency2.Name = "labelCurrency2";
            this.labelCurrency2.Size = new System.Drawing.Size(22, 24);
            this.labelCurrency2.TabIndex = 42;
            this.labelCurrency2.Text = "$";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(282, 31);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(22, 24);
            this.labelCurrency.TabIndex = 41;
            this.labelCurrency.Text = "$";
            // 
            // textBoxWorstPerformance
            // 
            this.textBoxWorstPerformance.Location = new System.Drawing.Point(125, 165);
            this.textBoxWorstPerformance.Name = "textBoxWorstPerformance";
            this.textBoxWorstPerformance.ReadOnly = true;
            this.textBoxWorstPerformance.Size = new System.Drawing.Size(181, 28);
            this.textBoxWorstPerformance.TabIndex = 7;
            // 
            // labelWorstPerformance
            // 
            this.labelWorstPerformance.AutoSize = true;
            this.labelWorstPerformance.Location = new System.Drawing.Point(17, 153);
            this.labelWorstPerformance.Name = "labelWorstPerformance";
            this.labelWorstPerformance.Size = new System.Drawing.Size(106, 42);
            this.labelWorstPerformance.TabIndex = 6;
            this.labelWorstPerformance.Text = "Worst\r\nperformance";
            // 
            // textBoxBestPerformance
            // 
            this.textBoxBestPerformance.Location = new System.Drawing.Point(125, 111);
            this.textBoxBestPerformance.Name = "textBoxBestPerformance";
            this.textBoxBestPerformance.ReadOnly = true;
            this.textBoxBestPerformance.Size = new System.Drawing.Size(181, 28);
            this.textBoxBestPerformance.TabIndex = 6;
            // 
            // labelBestPerformance
            // 
            this.labelBestPerformance.AutoSize = true;
            this.labelBestPerformance.Location = new System.Drawing.Point(13, 97);
            this.labelBestPerformance.Name = "labelBestPerformance";
            this.labelBestPerformance.Size = new System.Drawing.Size(106, 42);
            this.labelBestPerformance.TabIndex = 4;
            this.labelBestPerformance.Text = "Best \r\nperformance";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(125, 64);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(181, 28);
            this.textBoxAverage.TabIndex = 5;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(13, 71);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(71, 21);
            this.labelAverage.TabIndex = 2;
            this.labelAverage.Text = "Average";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(125, 30);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(181, 28);
            this.textBoxSum.TabIndex = 4;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(13, 37);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(83, 21);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "Summary";
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(764, 28);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 17;
            this.groupBoxProfile.TabStop = false;
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccount";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(106, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // pictureBoxAccountIcon
            // 
            this.pictureBoxAccountIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAccountIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAccountIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccountIcon.Image")));
            this.pictureBoxAccountIcon.Location = new System.Drawing.Point(4, 7);
            this.pictureBoxAccountIcon.Name = "pictureBoxAccountIcon";
            this.pictureBoxAccountIcon.Size = new System.Drawing.Size(23, 23);
            this.pictureBoxAccountIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccountIcon.TabIndex = 1;
            this.pictureBoxAccountIcon.TabStop = false;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(33, 10);
            this.labelAccountName.MaximumSize = new System.Drawing.Size(110, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(92, 17);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "AccountName";
            // 
            // ViewRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 515);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "ViewRevenueForm";
            this.Text = "ViewRevenue";
            this.Load += new System.EventHandler(this.ViewRevenueForm_Load);
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxAdditionalParameter.ResumeLayout(false);
            this.groupBoxAdditionalParameter.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishDate;
        private System.Windows.Forms.GroupBox groupBoxPeriod;
        private System.Windows.Forms.Label labelFinishDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.GroupBox groupBoxAdditionalParameter;
        private System.Windows.Forms.TextBox textBoxWorstPerformance;
        private System.Windows.Forms.Label labelWorstPerformance;
        private System.Windows.Forms.TextBox textBoxBestPerformance;
        private System.Windows.Forms.Label labelBestPerformance;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label labelChartType;
        private System.Windows.Forms.Label labelCurrency2;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonSavePdf;
    }
}