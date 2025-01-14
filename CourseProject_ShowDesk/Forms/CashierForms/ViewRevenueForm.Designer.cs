namespace CourseProject_ShowDesk
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
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinishDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxRevenue = new System.Windows.Forms.GroupBox();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.timerRevenue = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAdditionalParameter = new System.Windows.Forms.GroupBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxBestPerformance = new System.Windows.Forms.TextBox();
            this.labelBestPerformance = new System.Windows.Forms.Label();
            this.textBoxWorstPerformance = new System.Windows.Forms.TextBox();
            this.labelWorstPerformance = new System.Windows.Forms.Label();
            this.labelChartType = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.groupBoxForm.SuspendLayout();
            this.groupBoxAdditionalParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(126, 30);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(181, 28);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            this.dateTimePickerStartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerStartDate_KeyUp);
            // 
            // dateTimePickerFinishDate
            // 
            this.dateTimePickerFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinishDate.Location = new System.Drawing.Point(126, 64);
            this.dateTimePickerFinishDate.Name = "dateTimePickerFinishDate";
            this.dateTimePickerFinishDate.Size = new System.Drawing.Size(181, 28);
            this.dateTimePickerFinishDate.TabIndex = 1;
            this.dateTimePickerFinishDate.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            this.dateTimePickerFinishDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerFinishDate_KeyUp);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.BackColor = System.Drawing.Color.Transparent;
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
            this.labelStartDate.Location = new System.Drawing.Point(21, 37);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 21);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start date";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Silver;
            this.buttonCalculate.Location = new System.Drawing.Point(126, 136);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(140, 45);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxRevenue
            // 
            this.groupBoxRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRevenue.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRevenue.Controls.Add(this.chartRevenue);
            this.groupBoxRevenue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRevenue.Location = new System.Drawing.Point(325, 19);
            this.groupBoxRevenue.Name = "groupBoxRevenue";
            this.groupBoxRevenue.Size = new System.Drawing.Size(606, 401);
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
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            legend1.Title = "Revenue";
            legend1.TitleFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(9, 30);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(591, 371);
            this.chartRevenue.TabIndex = 0;
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxForm.Controls.Add(this.groupBoxAdditionalParameter);
            this.groupBoxForm.Controls.Add(this.groupBoxPeriod);
            this.groupBoxForm.Controls.Add(this.groupBoxRevenue);
            this.groupBoxForm.Location = new System.Drawing.Point(-1, 65);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(951, 436);
            this.groupBoxForm.TabIndex = 8;
            this.groupBoxForm.TabStop = false;
            // 
            // timerRevenue
            // 
            this.timerRevenue.Interval = 10;
            this.timerRevenue.Tick += new System.EventHandler(this.timerRevenue_Tick);
            // 
            // groupBoxAdditionalParameter
            // 
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
            this.groupBoxAdditionalParameter.Size = new System.Drawing.Size(312, 199);
            this.groupBoxAdditionalParameter.TabIndex = 8;
            this.groupBoxAdditionalParameter.TabStop = false;
            this.groupBoxAdditionalParameter.Text = "Additional parameter";
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
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(125, 30);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(181, 28);
            this.textBoxSum.TabIndex = 1;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(125, 64);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(181, 28);
            this.textBoxAverage.TabIndex = 3;
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
            // textBoxBestPerformance
            // 
            this.textBoxBestPerformance.Location = new System.Drawing.Point(125, 111);
            this.textBoxBestPerformance.Name = "textBoxBestPerformance";
            this.textBoxBestPerformance.ReadOnly = true;
            this.textBoxBestPerformance.Size = new System.Drawing.Size(181, 28);
            this.textBoxBestPerformance.TabIndex = 5;
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
            // comboBoxChartType
            // 
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(126, 98);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(181, 29);
            this.comboBoxChartType.TabIndex = 6;
            // 
            // ViewRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 502);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "ViewRevenueForm";
            this.Text = "ViewRevenue";
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.groupBoxForm.ResumeLayout(false);
            this.groupBoxAdditionalParameter.ResumeLayout(false);
            this.groupBoxAdditionalParameter.PerformLayout();
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
        private System.Windows.Forms.Timer timerRevenue;
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
    }
}