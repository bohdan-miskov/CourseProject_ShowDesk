namespace CourseProject_TheaterHub
{
    partial class BuyTicketForm
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxReserved = new System.Windows.Forms.CheckBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxPositions = new System.Windows.Forms.ComboBox();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.groupBoxTicket = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(221, 217);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 36);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(148, 179);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(213, 28);
            this.textBoxPrice.TabIndex = 35;
            this.textBoxPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPrice_KeyUp);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(34, 186);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 21);
            this.labelPrice.TabIndex = 34;
            this.labelPrice.Text = "Price";
            // 
            // checkBoxReserved
            // 
            this.checkBoxReserved.AutoSize = true;
            this.checkBoxReserved.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReserved.Location = new System.Drawing.Point(38, 152);
            this.checkBoxReserved.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkBoxReserved.Name = "checkBoxReserved";
            this.checkBoxReserved.Size = new System.Drawing.Size(97, 25);
            this.checkBoxReserved.TabIndex = 33;
            this.checkBoxReserved.Text = "Reserved";
            this.checkBoxReserved.UseVisualStyleBackColor = true;
            this.checkBoxReserved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkBoxReserved_KeyUp);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(148, 40);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.ReadOnly = true;
            this.textBoxIndex.Size = new System.Drawing.Size(213, 28);
            this.textBoxIndex.TabIndex = 32;
            this.textBoxIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIndex_KeyUp);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(34, 47);
            this.labelIndex.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(54, 21);
            this.labelIndex.TabIndex = 31;
            this.labelIndex.Text = "Index";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(34, 117);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(75, 21);
            this.labelPosition.TabIndex = 30;
            this.labelPosition.Text = "Position";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(34, 82);
            this.labelType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(48, 21);
            this.labelType.TabIndex = 29;
            this.labelType.Text = "Type";
            // 
            // comboBoxPositions
            // 
            this.comboBoxPositions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPositions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPositions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPositions.BackColor = System.Drawing.Color.Silver;
            this.comboBoxPositions.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPositions.FormattingEnabled = true;
            this.comboBoxPositions.Location = new System.Drawing.Point(148, 109);
            this.comboBoxPositions.Name = "comboBoxPositions";
            this.comboBoxPositions.Size = new System.Drawing.Size(213, 29);
            this.comboBoxPositions.TabIndex = 28;
            this.comboBoxPositions.SelectedIndexChanged += new System.EventHandler(this.comboBoxPositions_SelectedIndexChanged);
            this.comboBoxPositions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxPositions_KeyUp);
            // 
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTicketType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTicketType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTicketType.BackColor = System.Drawing.Color.Silver;
            this.comboBoxTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicketType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Items.AddRange(new object[] {
            "Standard",
            "Standard Plus",
            "Premium"});
            this.comboBoxTicketType.Location = new System.Drawing.Point(148, 74);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(213, 29);
            this.comboBoxTicketType.TabIndex = 27;
            this.comboBoxTicketType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTicketType_SelectedIndexChanged);
            this.comboBoxTicketType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxTicketType_KeyUp);
            // 
            // groupBoxTicket
            // 
            this.groupBoxTicket.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTicket.BackgroundImage = global::CourseProject_TheaterHub.Properties.Resources.formBackground;
            this.groupBoxTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxTicket.Controls.Add(this.labelInfo);
            this.groupBoxTicket.Controls.Add(this.textBoxPrice);
            this.groupBoxTicket.Controls.Add(this.comboBoxTicketType);
            this.groupBoxTicket.Controls.Add(this.comboBoxPositions);
            this.groupBoxTicket.Controls.Add(this.labelType);
            this.groupBoxTicket.Controls.Add(this.buttonAdd);
            this.groupBoxTicket.Controls.Add(this.labelPosition);
            this.groupBoxTicket.Controls.Add(this.labelIndex);
            this.groupBoxTicket.Controls.Add(this.labelPrice);
            this.groupBoxTicket.Controls.Add(this.textBoxIndex);
            this.groupBoxTicket.Controls.Add(this.checkBoxReserved);
            this.groupBoxTicket.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTicket.Location = new System.Drawing.Point(1, 65);
            this.groupBoxTicket.Name = "groupBoxTicket";
            this.groupBoxTicket.Size = new System.Drawing.Size(415, 288);
            this.groupBoxTicket.TabIndex = 40;
            this.groupBoxTicket.TabStop = false;
            this.groupBoxTicket.Text = "Ticket";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Silver;
            this.labelInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelInfo.Location = new System.Drawing.Point(35, 217);
            this.labelInfo.MaximumSize = new System.Drawing.Size(180, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(96, 18);
            this.labelInfo.TabIndex = 37;
            this.labelInfo.Text = "Only position";
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 355);
            this.Controls.Add(this.groupBoxTicket);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            this.groupBoxTicket.ResumeLayout(false);
            this.groupBoxTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxReserved;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxPositions;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.GroupBox groupBoxTicket;
        private System.Windows.Forms.Label labelInfo;
    }
}