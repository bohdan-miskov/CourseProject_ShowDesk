namespace CourseProject_TheaterHub
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBaseTicketPrice = new System.Windows.Forms.Label();
            this.labelPerfomanceDate = new System.Windows.Forms.Label();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.textBoxBaseTicketPrice = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerPerfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.groupBoxPerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(198, 178);
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
            this.labelStage.Location = new System.Drawing.Point(26, 139);
            this.labelStage.Name = "labelStage";
            this.labelStage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelStage.Size = new System.Drawing.Size(51, 25);
            this.labelStage.TabIndex = 16;
            this.labelStage.Text = "Stage";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(26, 71);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelName.Size = new System.Drawing.Size(54, 25);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name";
            // 
            // labelBaseTicketPrice
            // 
            this.labelBaseTicketPrice.AutoSize = true;
            this.labelBaseTicketPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaseTicketPrice.Location = new System.Drawing.Point(26, 105);
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
            this.comboBoxStage.Location = new System.Drawing.Point(198, 136);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(222, 29);
            this.comboBoxStage.TabIndex = 12;
            this.comboBoxStage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxStage_KeyUp);
            // 
            // textBoxBaseTicketPrice
            // 
            this.textBoxBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseTicketPrice.Location = new System.Drawing.Point(198, 102);
            this.textBoxBaseTicketPrice.Name = "textBoxBaseTicketPrice";
            this.textBoxBaseTicketPrice.Size = new System.Drawing.Size(222, 28);
            this.textBoxBaseTicketPrice.TabIndex = 11;
            this.textBoxBaseTicketPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBaseTicketPrice_KeyUp);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(198, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(222, 28);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // dateTimePickerPerfomanceDate
            // 
            this.dateTimePickerPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPerfomanceDate.Location = new System.Drawing.Point(198, 34);
            this.dateTimePickerPerfomanceDate.Name = "dateTimePickerPerfomanceDate";
            this.dateTimePickerPerfomanceDate.Size = new System.Drawing.Size(222, 28);
            this.dateTimePickerPerfomanceDate.TabIndex = 9;
            this.dateTimePickerPerfomanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerPerfomanceDate_KeyUp);
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPerformance.BackgroundImage = global::CourseProject_TheaterHub.Properties.Resources.formBackground;
            this.groupBoxPerformance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxPerformance.Controls.Add(this.labelPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.buttonAdd);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.labelStage);
            this.groupBoxPerformance.Controls.Add(this.textBoxName);
            this.groupBoxPerformance.Controls.Add(this.labelName);
            this.groupBoxPerformance.Controls.Add(this.textBoxBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.labelBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.comboBoxStage);
            this.groupBoxPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformance.Location = new System.Drawing.Point(1, 63);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(469, 240);
            this.groupBoxPerformance.TabIndex = 18;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance";
            // 
            // AddPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 304);
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
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBaseTicketPrice;
        private System.Windows.Forms.Label labelPerfomanceDate;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.TextBox textBoxBaseTicketPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerfomanceDate;
        private System.Windows.Forms.GroupBox groupBoxPerformance;
    }
}