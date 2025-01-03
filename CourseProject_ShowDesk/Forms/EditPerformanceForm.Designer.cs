namespace CourseProject_ShowDesk
{
    partial class EditPerformanceForm
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
            this.removeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelPerformanceName = new System.Windows.Forms.Label();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelPerfomanceDate = new System.Windows.Forms.Label();
            this.menuStripPerformance = new System.Windows.Forms.MenuStrip();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.textBoxPerformanceName = new System.Windows.Forms.TextBox();
            this.dateTimePickerPerfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPerformance = new System.Windows.Forms.GroupBox();
            this.textBoxBaseTicketPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.groupBoxTickets = new System.Windows.Forms.GroupBox();
            this.groupBoxForm = new System.Windows.Forms.GroupBox();
            this.labelPerformanceTime = new System.Windows.Forms.Label();
            this.dateTimePickerPerformanceTime = new System.Windows.Forms.DateTimePicker();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdditionalServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPerformance.SuspendLayout();
            this.groupBoxPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.groupBoxTickets.SuspendLayout();
            this.groupBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeTicketToolStripMenuItem
            // 
            this.removeTicketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTicketToolStripMenuItem.Name = "removeTicketToolStripMenuItem";
            this.removeTicketToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeTicketToolStripMenuItem.Text = "Remove";
            this.removeTicketToolStripMenuItem.Click += new System.EventHandler(this.removeTicketToolStripMenuItem_Click);
            // 
            // addTicketToolStripMenuItem
            // 
            this.addTicketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTicketToolStripMenuItem.Name = "addTicketToolStripMenuItem";
            this.addTicketToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addTicketToolStripMenuItem.Text = "Add";
            this.addTicketToolStripMenuItem.Click += new System.EventHandler(this.BuyTicketFormToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTicketToolStripMenuItem,
            this.ChangeStatusToolStripMenuItem,
            this.removeTicketToolStripMenuItem});
            this.ticketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // ChangeStatusToolStripMenuItem
            // 
            this.ChangeStatusToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeStatusToolStripMenuItem.Name = "ChangeStatusToolStripMenuItem";
            this.ChangeStatusToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ChangeStatusToolStripMenuItem.Text = "Change status";
            this.ChangeStatusToolStripMenuItem.Click += new System.EventHandler(this.ChangeStatusToolStripMenuItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(217, 214);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 38);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.Location = new System.Drawing.Point(51, 176);
            this.labelStage.Name = "labelStage";
            this.labelStage.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelStage.Size = new System.Drawing.Size(51, 25);
            this.labelStage.TabIndex = 16;
            this.labelStage.Text = "Stage";
            // 
            // labelPerformanceName
            // 
            this.labelPerformanceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPerformanceName.AutoSize = true;
            this.labelPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformanceName.Location = new System.Drawing.Point(51, 107);
            this.labelPerformanceName.Name = "labelPerformanceName";
            this.labelPerformanceName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerformanceName.Size = new System.Drawing.Size(54, 25);
            this.labelPerformanceName.TabIndex = 15;
            this.labelPerformanceName.Text = "Name";
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketPrice.Location = new System.Drawing.Point(51, 141);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelTicketPrice.Size = new System.Drawing.Size(103, 25);
            this.labelTicketPrice.TabIndex = 14;
            this.labelTicketPrice.Text = "Ticket price";
            // 
            // labelPerfomanceDate
            // 
            this.labelPerfomanceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPerfomanceDate.AutoSize = true;
            this.labelPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfomanceDate.Location = new System.Drawing.Point(51, 42);
            this.labelPerfomanceDate.Name = "labelPerfomanceDate";
            this.labelPerfomanceDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerfomanceDate.Size = new System.Drawing.Size(146, 25);
            this.labelPerfomanceDate.TabIndex = 13;
            this.labelPerfomanceDate.Text = "Performance date";
            // 
            // menuStripPerformance
            // 
            this.menuStripPerformance.BackColor = System.Drawing.Color.Teal;
            this.menuStripPerformance.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripPerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem});
            this.menuStripPerformance.Location = new System.Drawing.Point(0, 0);
            this.menuStripPerformance.Name = "menuStripPerformance";
            this.menuStripPerformance.Size = new System.Drawing.Size(68, 26);
            this.menuStripPerformance.TabIndex = 17;
            this.menuStripPerformance.Text = "menuStrip1";
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxStage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStage.BackColor = System.Drawing.Color.Silver;
            this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(217, 172);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(299, 29);
            this.comboBoxStage.TabIndex = 12;
            this.comboBoxStage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxStage_KeyUp);
            // 
            // textBoxPerformanceName
            // 
            this.textBoxPerformanceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPerformanceName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPerformanceName.Location = new System.Drawing.Point(217, 104);
            this.textBoxPerformanceName.Name = "textBoxPerformanceName";
            this.textBoxPerformanceName.Size = new System.Drawing.Size(299, 28);
            this.textBoxPerformanceName.TabIndex = 10;
            this.textBoxPerformanceName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // dateTimePickerPerfomanceDate
            // 
            this.dateTimePickerPerfomanceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPerfomanceDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPerfomanceDate.Location = new System.Drawing.Point(217, 36);
            this.dateTimePickerPerfomanceDate.Name = "dateTimePickerPerfomanceDate";
            this.dateTimePickerPerfomanceDate.Size = new System.Drawing.Size(299, 28);
            this.dateTimePickerPerfomanceDate.TabIndex = 9;
            this.dateTimePickerPerfomanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerPerfomanceDate_KeyUp);
            // 
            // groupBoxPerformance
            // 
            this.groupBoxPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPerformance.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPerformance.Controls.Add(this.labelPerformanceTime);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerPerformanceTime);
            this.groupBoxPerformance.Controls.Add(this.buttonSave);
            this.groupBoxPerformance.Controls.Add(this.labelStage);
            this.groupBoxPerformance.Controls.Add(this.labelPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.labelTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.labelPerfomanceDate);
            this.groupBoxPerformance.Controls.Add(this.comboBoxStage);
            this.groupBoxPerformance.Controls.Add(this.textBoxBaseTicketPrice);
            this.groupBoxPerformance.Controls.Add(this.textBoxPerformanceName);
            this.groupBoxPerformance.Controls.Add(this.dateTimePickerPerfomanceDate);
            this.groupBoxPerformance.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPerformance.Location = new System.Drawing.Point(8, 19);
            this.groupBoxPerformance.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoxPerformance.Name = "groupBoxPerformance";
            this.groupBoxPerformance.Size = new System.Drawing.Size(572, 270);
            this.groupBoxPerformance.TabIndex = 15;
            this.groupBoxPerformance.TabStop = false;
            this.groupBoxPerformance.Text = "Performance";
            // 
            // textBoxBaseTicketPrice
            // 
            this.textBoxBaseTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBaseTicketPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBaseTicketPrice.Location = new System.Drawing.Point(217, 138);
            this.textBoxBaseTicketPrice.Name = "textBoxBaseTicketPrice";
            this.textBoxBaseTicketPrice.Size = new System.Drawing.Size(299, 28);
            this.textBoxBaseTicketPrice.TabIndex = 11;
            this.textBoxBaseTicketPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBaseTicketPrice_KeyPress);
            this.textBoxBaseTicketPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBaseTicketPrice_KeyUp);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnType,
            this.columnPosition,
            this.columnPrice,
            this.columnReserved,
            this.columnAdditionalServices});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTickets.Location = new System.Drawing.Point(3, 24);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(664, 197);
            this.dataGridViewTickets.TabIndex = 12;
            this.dataGridViewTickets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_RowEnter);
            this.dataGridViewTickets.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_RowLeave);
            // 
            // groupBoxTickets
            // 
            this.groupBoxTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTickets.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTickets.Controls.Add(this.dataGridViewTickets);
            this.groupBoxTickets.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTickets.Location = new System.Drawing.Point(10, 295);
            this.groupBoxTickets.Name = "groupBoxTickets";
            this.groupBoxTickets.Size = new System.Drawing.Size(670, 224);
            this.groupBoxTickets.TabIndex = 16;
            this.groupBoxTickets.TabStop = false;
            this.groupBoxTickets.Text = "Tickets";
            // 
            // groupBoxForm
            // 
            this.groupBoxForm.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.groupBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxForm.Controls.Add(this.groupBoxPerformance);
            this.groupBoxForm.Controls.Add(this.groupBoxTickets);
            this.groupBoxForm.Location = new System.Drawing.Point(0, 63);
            this.groupBoxForm.Name = "groupBoxForm";
            this.groupBoxForm.Size = new System.Drawing.Size(694, 525);
            this.groupBoxForm.TabIndex = 18;
            this.groupBoxForm.TabStop = false;
            // 
            // labelPerformanceTime
            // 
            this.labelPerformanceTime.AutoSize = true;
            this.labelPerformanceTime.BackColor = System.Drawing.Color.Transparent;
            this.labelPerformanceTime.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerformanceTime.Location = new System.Drawing.Point(51, 73);
            this.labelPerformanceTime.Name = "labelPerformanceTime";
            this.labelPerformanceTime.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPerformanceTime.Size = new System.Drawing.Size(141, 25);
            this.labelPerformanceTime.TabIndex = 21;
            this.labelPerformanceTime.Text = "Perfomance time";
            // 
            // dateTimePickerPerformanceTime
            // 
            this.dateTimePickerPerformanceTime.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPerformanceTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerPerformanceTime.Location = new System.Drawing.Point(217, 70);
            this.dateTimePickerPerformanceTime.Name = "dateTimePickerPerformanceTime";
            this.dateTimePickerPerformanceTime.Size = new System.Drawing.Size(299, 28);
            this.dateTimePickerPerformanceTime.TabIndex = 20;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // columnPosition
            // 
            this.columnPosition.HeaderText = "Position";
            this.columnPosition.Name = "columnPosition";
            this.columnPosition.ReadOnly = true;
            // 
            // columnPrice
            // 
            this.columnPrice.HeaderText = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.ReadOnly = true;
            // 
            // columnReserved
            // 
            this.columnReserved.HeaderText = "Reserved";
            this.columnReserved.Name = "columnReserved";
            this.columnReserved.ReadOnly = true;
            // 
            // columnAdditionalServices
            // 
            this.columnAdditionalServices.HeaderText = "Additional services";
            this.columnAdditionalServices.Name = "columnAdditionalServices";
            this.columnAdditionalServices.ReadOnly = true;
            // 
            // EditPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 588);
            this.Controls.Add(this.groupBoxForm);
            this.Controls.Add(this.menuStripPerformance);
            this.Name = "EditPerformanceForm";
            this.Text = "EditPerformanceForm";
            this.menuStripPerformance.ResumeLayout(false);
            this.menuStripPerformance.PerformLayout();
            this.groupBoxPerformance.ResumeLayout(false);
            this.groupBoxPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.groupBoxTickets.ResumeLayout(false);
            this.groupBoxForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem removeTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeStatusToolStripMenuItem;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelPerformanceName;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label labelPerfomanceDate;
        private System.Windows.Forms.MenuStrip menuStripPerformance;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.TextBox textBoxPerformanceName;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerfomanceDate;
        private System.Windows.Forms.GroupBox groupBoxPerformance;
        private System.Windows.Forms.TextBox textBoxBaseTicketPrice;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.GroupBox groupBoxTickets;
        private System.Windows.Forms.GroupBox groupBoxForm;
        private System.Windows.Forms.Label labelPerformanceTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerformanceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAdditionalServices;
    }
}