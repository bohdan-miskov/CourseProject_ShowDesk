namespace CourseProject_ShowDesk.Forms.CashierForms
{
    partial class ManageTicketsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripPerformance = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPerformance = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTicketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTicketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAdditionalServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.contextMenuStripPerformance.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPerformance
            // 
            this.menuStripPerformance.BackColor = System.Drawing.Color.Azure;
            this.menuStripPerformance.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripPerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem});
            this.menuStripPerformance.Location = new System.Drawing.Point(2, 0);
            this.menuStripPerformance.Name = "menuStripPerformance";
            this.menuStripPerformance.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStripPerformance.Size = new System.Drawing.Size(89, 28);
            this.menuStripPerformance.TabIndex = 18;
            this.menuStripPerformance.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTicketToolStripMenuItem,
            this.changeStatusToolStripMenuItem,
            this.removeTicketToolStripMenuItem});
            this.ticketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.ticket_icon;
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            // 
            // addTicketToolStripMenuItem
            // 
            this.addTicketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTicketToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addTicketToolStripMenuItem.Name = "addTicketToolStripMenuItem";
            this.addTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTicketToolStripMenuItem.Text = "Add";
            this.addTicketToolStripMenuItem.Click += new System.EventHandler(this.BuyTicketFormToolStripMenuItem_Click);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeStatusToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.change_icon;
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeStatusToolStripMenuItem.Text = "Change status";
            this.changeStatusToolStripMenuItem.Click += new System.EventHandler(this.ChangeStatusToolStripMenuItem_Click);
            // 
            // removeTicketToolStripMenuItem
            // 
            this.removeTicketToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTicketToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeTicketToolStripMenuItem.Name = "removeTicketToolStripMenuItem";
            this.removeTicketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeTicketToolStripMenuItem.Text = "Remove";
            this.removeTicketToolStripMenuItem.Click += new System.EventHandler(this.removeTicketToolStripMenuItem_Click);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.columnName,
            this.columnType,
            this.columnPosition,
            this.columnPrice,
            this.columnReserved,
            this.columnAdditionalServices});
            this.dataGridViewTickets.ContextMenuStrip = this.contextMenuStripPerformance;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTickets.Location = new System.Drawing.Point(2, 63);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(737, 303);
            this.dataGridViewTickets.TabIndex = 12;
            this.dataGridViewTickets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_RowEnter);
            this.dataGridViewTickets.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_RowLeave);
            // 
            // contextMenuStripPerformance
            // 
            this.contextMenuStripPerformance.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripPerformance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTicketToolStripMenuItem1,
            this.changeStatusToolStripMenuItem1,
            this.removeTicketToolStripMenuItem1});
            this.contextMenuStripPerformance.Name = "contextMenuStripPerformance";
            this.contextMenuStripPerformance.Size = new System.Drawing.Size(206, 70);
            // 
            // addTicketToolStripMenuItem1
            // 
            this.addTicketToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addTicketToolStripMenuItem1.Name = "addTicketToolStripMenuItem1";
            this.addTicketToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.addTicketToolStripMenuItem1.Text = "Add ticket";
            // 
            // changeStatusToolStripMenuItem1
            // 
            this.changeStatusToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.change_icon;
            this.changeStatusToolStripMenuItem1.Name = "changeStatusToolStripMenuItem1";
            this.changeStatusToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.changeStatusToolStripMenuItem1.Text = "Change ticket status";
            // 
            // removeTicketToolStripMenuItem1
            // 
            this.removeTicketToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeTicketToolStripMenuItem1.Name = "removeTicketToolStripMenuItem1";
            this.removeTicketToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.removeTicketToolStripMenuItem1.Text = "Remove ticket";
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
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
            // ManageTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 367);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.menuStripPerformance);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ManageTicketsForm";
            this.Padding = new System.Windows.Forms.Padding(37, 97, 37, 32);
            this.Text = "ManageTicketsForm";
            this.menuStripPerformance.ResumeLayout(false);
            this.menuStripPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.contextMenuStripPerformance.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPerformance;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTicketToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPerformance;
        private System.Windows.Forms.ToolStripMenuItem addTicketToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeTicketToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReserved;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAdditionalServices;
    }
}