namespace CourseProject_ShowDesk
{
    partial class AddPerformanceForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelPerformanceName = new System.Windows.Forms.Label();
            this.labelBaseTicketPrice = new System.Windows.Forms.Label();
            this.labelPerfomanceDate = new System.Windows.Forms.Label();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.textBoxBaseTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxPerformanceName = new System.Windows.Forms.TextBox();
            this.dateTimePickerPerfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.toolTipPerformance = new System.Windows.Forms.ToolTip(this.components);
            this.labelDuration = new System.Windows.Forms.Label();
            this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(198, 212);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 40);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.BackColor = System.Drawing.Color.Transparent;
            this.labelStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.Location = new System.Drawing.Point(26, 173);
            this.labelStage.Name = "labelStage";
            this.labelStage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelStage.Size = new System.Drawing.Size(51, 25);
            this.labelStage.TabIndex = 16;
            this.labelStage.Text = "Stage";
            // 
            // labelPerformanceName
            // 
            this.labelPerformanceName.AutoSize = true;
            this.labelPerformanceName.BackColor = System.Drawing.Color.Transparent;
            this.labelPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformanceName.Location = new System.Drawing.Point(26, 71);
            this.labelPerformanceName.Name = "labelPerformanceName";
            this.labelPerformanceName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerformanceName.Size = new System.Drawing.Size(155, 25);
            this.labelPerformanceName.TabIndex = 15;
            this.labelPerformanceName.Text = "Performance name";
            // 
            // labelBaseTicketPrice
            // 
            this.labelBaseTicketPrice.AutoSize = true;
            this.labelBaseTicketPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseTicketPrice.Location = new System.Drawing.Point(26, 139);
            this.labelBaseTicketPrice.Name = "labelBaseTicketPrice";
            this.labelBaseTicketPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelBaseTicketPrice.Size = new System.Drawing.Size(103, 25);
            this.labelBaseTicketPrice.TabIndex = 14;
            this.labelBaseTicketPrice.Text = "Ticket price";
            // 
            // labelPerfomanceDate
            // 
            this.labelPerfomanceDate.AutoSize = true;
            this.labelPerfomanceDate.BackColor = System.Drawing.Color.Transparent;
            this.labelPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfomanceDate.Location = new System.Drawing.Point(26, 37);
            this.labelPerfomanceDate.Name = "labelPerfomanceDate";
            this.labelPerfomanceDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerfomanceDate.Size = new System.Drawing.Size(139, 25);
            this.labelPerfomanceDate.TabIndex = 13;
            this.labelPerfomanceDate.Text = "Perfomance date";
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStage.BackColor = System.Drawing.Color.Silver;
            this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(198, 170);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(222, 29);
            this.comboBoxStage.TabIndex = 12;
            this.comboBoxStage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxStage_KeyUp);
            // 
            // textBoxBaseTicketPrice
            // 
            this.textBoxBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseTicketPrice.Location = new System.Drawing.Point(198, 136);
            this.textBoxBaseTicketPrice.Name = "textBoxBaseTicketPrice";
            this.textBoxBaseTicketPrice.Size = new System.Drawing.Size(222, 28);
            this.textBoxBaseTicketPrice.TabIndex = 11;
            this.toolTipPerformance.SetToolTip(this.textBoxBaseTicketPrice, "Base price, without increase");
            this.textBoxBaseTicketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBaseTicketPrice_KeyPress);
            this.textBoxBaseTicketPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBaseTicketPrice_KeyUp);
            // 
            // textBoxPerformanceName
            // 
            this.textBoxPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerformanceName.Location = new System.Drawing.Point(198, 68);
            this.textBoxPerformanceName.Name = "textBoxPerformanceName";
            this.textBoxPerformanceName.Size = new System.Drawing.Size(222, 28);
            this.textBoxPerformanceName.TabIndex = 10;
            this.textBoxPerformanceName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // dateTimePickerPerfomanceDate
            // 
            this.dateTimePickerPerfomanceDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPerfomanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPerfomanceDate.Location = new System.Drawing.Point(198, 34);
            this.dateTimePickerPerfomanceDate.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerPerfomanceDate.Name = "dateTimePickerPerfomanceDate";
            this.dateTimePickerPerfomanceDate.Size = new System.Drawing.Size(222, 28);
            this.dateTimePickerPerfomanceDate.TabIndex = 9;
            this.dateTimePickerPerfomanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerPerfomanceDate_KeyUp);
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPerformance.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.groupBoxPerformance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerDuration);
            this.groupBoxPerformance.Controls.Add(this.labelDuration);
            this.groupBoxPerformance.Controls.Add(this.labelPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.buttonAdd);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.labelStage);
            this.groupBoxPerformance.Controls.Add(this.textBoxPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.labelPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.textBoxBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.labelBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.comboBoxStage);
            this.groupBoxPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformance.Location = new System.Drawing.Point(1, 63);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(469, 276);
            this.groupBoxPerformance.TabIndex = 18;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.Transparent;
            this.labelDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(26, 105);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelDuration.Size = new System.Drawing.Size(81, 25);
            this.labelDuration.TabIndex = 19;
            this.labelDuration.Text = "Duration";
            // 
            // dateTimePickerDuration
            // 
            this.dateTimePickerDuration.CustomFormat = "";
            this.dateTimePickerDuration.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDuration.Location = new System.Drawing.Point(198, 102);
            this.dateTimePickerDuration.MinDate = new System.DateTime(2025, 1, 9, 0, 0, 0, 0);
            this.dateTimePickerDuration.Name = "dateTimePickerDuration";
            this.dateTimePickerDuration.ShowUpDown = true;
            this.dateTimePickerDuration.Size = new System.Drawing.Size(222, 28);
            this.dateTimePickerDuration.TabIndex = 20;
            // 
            // AddPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 339);
            this.Controls.Add(this.groupBoxPerformance);
            this.Name = "AddPerformanceForm";
            this.Text = "AddPerformanceForm";
            this.groupBoxPerformance.ResumeLayout(false);
            this.groupBoxPerformance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelPerformanceName;
        private System.Windows.Forms.Label labelBaseTicketPrice;
        private System.Windows.Forms.Label labelPerfomanceDate;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.TextBox textBoxBaseTicketPrice;
        private System.Windows.Forms.TextBox textBoxPerformanceName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerfomanceDate;
        private System.Windows.Forms.GroupBox groupBoxPerformance;
        private System.Windows.Forms.ToolTip toolTipPerformance;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
    }
}