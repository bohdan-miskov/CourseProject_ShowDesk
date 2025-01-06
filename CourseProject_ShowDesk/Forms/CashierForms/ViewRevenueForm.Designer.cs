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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinishDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPeriod = new System.Windows.Forms.GroupBox();
            this.labelFinishDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxRevenue = new System.Windows.Forms.GroupBox();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.groupBoxPeriod.SuspendLayout();
            this.groupBoxRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(176, 35);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerFinishDate
            // 
            this.dateTimePickerFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinishDate.Location = new System.Drawing.Point(176, 69);
            this.dateTimePickerFinishDate.Name = "dateTimePickerFinishDate";
            this.dateTimePickerFinishDate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePickerFinishDate.TabIndex = 1;
            this.dateTimePickerFinishDate.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // groupBoxPeriod
            // 
            this.groupBoxPeriod.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPeriod.Controls.Add(this.labelFinishDate);
            this.groupBoxPeriod.Controls.Add(this.labelStartDate);
            this.groupBoxPeriod.Controls.Add(this.buttonCalculate);
            this.groupBoxPeriod.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxPeriod.Controls.Add(this.dateTimePickerFinishDate);
            this.groupBoxPeriod.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPeriod.Location = new System.Drawing.Point(6, 19);
            this.groupBoxPeriod.Name = "groupBoxPeriod";
            this.groupBoxPeriod.Size = new System.Drawing.Size(397, 152);
            this.groupBoxPeriod.TabIndex = 6;
            this.groupBoxPeriod.TabStop = false;
            this.groupBoxPeriod.Text = "Period";
            // 
            // labelFinishDate
            // 
            this.labelFinishDate.AutoSize = true;
            this.labelFinishDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinishDate.Location = new System.Drawing.Point(54, 76);
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
            this.labelStartDate.Location = new System.Drawing.Point(54, 41);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 21);
            this.labelStartDate.TabIndex = 3;
            this.labelStartDate.Text = "Start date";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Silver;
            this.buttonCalculate.Location = new System.Drawing.Point(176, 106);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(115, 35);
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
            this.groupBoxRevenue.Location = new System.Drawing.Point(6, 177);
            this.groupBoxRevenue.Name = "groupBoxRevenue";
            this.groupBoxRevenue.Size = new System.Drawing.Size(774, 557);
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
            legend1.Name = "Legend1";
            legend1.Title = "Revenue";
            legend1.TitleFont = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(9, 30);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "revenueSeries";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(758, 279);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxForm.Controls.Add(this.groupBoxPeriod);
            this.groupBoxForm.Controls.Add(this.groupBoxRevenue);
            this.groupBoxForm.Location = new System.Drawing.Point(-1, 65);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(786, 495);
            this.groupBoxForm.TabIndex = 8;
            this.groupBoxForm.TabStop = false;
            // 
            // ViewRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxForm);
            this.Name = "ViewRevenueForm";
            this.Text = "ViewRevenueForm";
            this.groupBoxPeriod.ResumeLayout(false);
            this.groupBoxPeriod.PerformLayout();
            this.groupBoxRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.groupBoxForm.ResumeLayout(false);
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
    }
}