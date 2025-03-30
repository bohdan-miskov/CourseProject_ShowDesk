namespace CourseProject_ShowDesk.Forms.CashierForms
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.groupBoxTicket = new System.Windows.Forms.GroupBox();
            this.labelSeatInfo = new System.Windows.Forms.Label();
            this.panelSeating = new System.Windows.Forms.Panel();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.groupBoxPremium = new System.Windows.Forms.GroupBox();
            this.comboBoxSouvenir = new System.Windows.Forms.ComboBox();
            this.labelSouvenir = new System.Windows.Forms.Label();
            this.groupBoxStandardPlus = new System.Windows.Forms.GroupBox();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.labelDrink = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxTicket.SuspendLayout();
            this.groupBoxPremium.SuspendLayout();
            this.groupBoxStandardPlus.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(221, 217);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 36);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(148, 179);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(213, 28);
            this.textBoxPrice.TabIndex = 35;
            this.textBoxPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPrice_KeyUp);
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
            this.checkBoxReserved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckBoxReserved_KeyUp);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(148, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(213, 28);
            this.textBoxId.TabIndex = 32;
            this.textBoxId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxIndex_KeyUp);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(34, 47);
            this.labelId.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 21);
            this.labelId.TabIndex = 31;
            this.labelId.Text = "Id";
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
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTicketType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTicketType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTicketType.BackColor = System.Drawing.Color.White;
            this.comboBoxTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicketType.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Location = new System.Drawing.Point(148, 74);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(213, 29);
            this.comboBoxTicketType.TabIndex = 27;
            this.comboBoxTicketType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTicketType_SelectedIndexChanged);
            this.comboBoxTicketType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxTicketType_KeyUp);
            // 
            // groupBoxTicket
            // 
            this.groupBoxTicket.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxTicket.Controls.Add(this.labelSeatInfo);
            this.groupBoxTicket.Controls.Add(this.panelSeating);
            this.groupBoxTicket.Controls.Add(this.labelCurrency);
            this.groupBoxTicket.Controls.Add(this.groupBoxPremium);
            this.groupBoxTicket.Controls.Add(this.groupBoxStandardPlus);
            this.groupBoxTicket.Controls.Add(this.labelInfo);
            this.groupBoxTicket.Controls.Add(this.textBoxPrice);
            this.groupBoxTicket.Controls.Add(this.comboBoxTicketType);
            this.groupBoxTicket.Controls.Add(this.labelType);
            this.groupBoxTicket.Controls.Add(this.buttonAdd);
            this.groupBoxTicket.Controls.Add(this.labelPosition);
            this.groupBoxTicket.Controls.Add(this.labelId);
            this.groupBoxTicket.Controls.Add(this.labelPrice);
            this.groupBoxTicket.Controls.Add(this.textBoxId);
            this.groupBoxTicket.Controls.Add(this.checkBoxReserved);
            this.groupBoxTicket.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTicket.Location = new System.Drawing.Point(1, 65);
            this.groupBoxTicket.Name = "groupBoxTicket";
            this.groupBoxTicket.Size = new System.Drawing.Size(1177, 438);
            this.groupBoxTicket.TabIndex = 40;
            this.groupBoxTicket.TabStop = false;
            this.groupBoxTicket.Text = "Ticket";
            // 
            // labelSeatInfo
            // 
            this.labelSeatInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.labelSeatInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeatInfo.Location = new System.Drawing.Point(376, 24);
            this.labelSeatInfo.Name = "labelSeatInfo";
            this.labelSeatInfo.Size = new System.Drawing.Size(139, 124);
            this.labelSeatInfo.TabIndex = 42;
            this.labelSeatInfo.Text = "Seat info";
            // 
            // panelSeating
            // 
            this.panelSeating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSeating.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSeating.Location = new System.Drawing.Point(529, 24);
            this.panelSeating.Name = "panelSeating";
            this.panelSeating.Size = new System.Drawing.Size(645, 411);
            this.panelSeating.TabIndex = 41;
            this.panelSeating.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseDown);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.Location = new System.Drawing.Point(337, 181);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(22, 24);
            this.labelCurrency.TabIndex = 40;
            this.labelCurrency.Text = "$";
            // 
            // groupBoxPremium
            // 
            this.groupBoxPremium.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxPremium.Controls.Add(this.comboBoxSouvenir);
            this.groupBoxPremium.Controls.Add(this.labelSouvenir);
            this.groupBoxPremium.Location = new System.Drawing.Point(23, 356);
            this.groupBoxPremium.Name = "groupBoxPremium";
            this.groupBoxPremium.Size = new System.Drawing.Size(336, 67);
            this.groupBoxPremium.TabIndex = 39;
            this.groupBoxPremium.TabStop = false;
            this.groupBoxPremium.Text = "Premium";
            // 
            // comboBoxSouvenir
            // 
            this.comboBoxSouvenir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSouvenir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSouvenir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSouvenir.BackColor = System.Drawing.Color.White;
            this.comboBoxSouvenir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSouvenir.FormattingEnabled = true;
            this.comboBoxSouvenir.Location = new System.Drawing.Point(119, 27);
            this.comboBoxSouvenir.Name = "comboBoxSouvenir";
            this.comboBoxSouvenir.Size = new System.Drawing.Size(182, 29);
            this.comboBoxSouvenir.TabIndex = 31;
            // 
            // labelSouvenir
            // 
            this.labelSouvenir.AutoSize = true;
            this.labelSouvenir.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSouvenir.Location = new System.Drawing.Point(11, 35);
            this.labelSouvenir.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelSouvenir.Name = "labelSouvenir";
            this.labelSouvenir.Size = new System.Drawing.Size(78, 21);
            this.labelSouvenir.TabIndex = 32;
            this.labelSouvenir.Text = "Souvenir";
            // 
            // groupBoxStandardPlus
            // 
            this.groupBoxStandardPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxStandardPlus.Controls.Add(this.comboBoxDrink);
            this.groupBoxStandardPlus.Controls.Add(this.labelDrink);
            this.groupBoxStandardPlus.Location = new System.Drawing.Point(23, 283);
            this.groupBoxStandardPlus.Name = "groupBoxStandardPlus";
            this.groupBoxStandardPlus.Size = new System.Drawing.Size(338, 67);
            this.groupBoxStandardPlus.TabIndex = 38;
            this.groupBoxStandardPlus.TabStop = false;
            this.groupBoxStandardPlus.Text = "Standard Plus";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDrink.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDrink.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDrink.BackColor = System.Drawing.Color.White;
            this.comboBoxDrink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(119, 27);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(184, 29);
            this.comboBoxDrink.TabIndex = 31;
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrink.Location = new System.Drawing.Point(11, 35);
            this.labelDrink.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(57, 21);
            this.labelDrink.TabIndex = 32;
            this.labelDrink.Text = "Drink";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Silver;
            this.labelInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.ClientSize = new System.Drawing.Size(1178, 505);
            this.Controls.Add(this.groupBoxTicket);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicket";
            this.groupBoxTicket.ResumeLayout(false);
            this.groupBoxTicket.PerformLayout();
            this.groupBoxPremium.ResumeLayout(false);
            this.groupBoxPremium.PerformLayout();
            this.groupBoxStandardPlus.ResumeLayout(false);
            this.groupBoxStandardPlus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxReserved;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.GroupBox groupBoxTicket;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.GroupBox groupBoxStandardPlus;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.GroupBox groupBoxPremium;
        private System.Windows.Forms.ComboBox comboBoxSouvenir;
        private System.Windows.Forms.Label labelSouvenir;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Panel panelSeating;
        private System.Windows.Forms.Label labelSeatInfo;
    }
}