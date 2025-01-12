namespace CourseProject_ShowDesk.Scripts
{
    partial class ManageEmployeesForm
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
            this.menuStripManageEmployees = new System.Windows.Forms.MenuStrip();
            this.emloyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.columnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessionList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHidePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.contextMenuStripDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripManageEmployees
            // 
            this.menuStripManageEmployees.BackColor = System.Drawing.Color.Teal;
            this.menuStripManageEmployees.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripManageEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emloyeeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripManageEmployees.Location = new System.Drawing.Point(0, 0);
            this.menuStripManageEmployees.Name = "menuStripManageEmployees";
            this.menuStripManageEmployees.Size = new System.Drawing.Size(281, 26);
            this.menuStripManageEmployees.TabIndex = 13;
            this.menuStripManageEmployees.Text = "menuStrip1";
            // 
            // emloyeeToolStripMenuItem
            // 
            this.emloyeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem});
            this.emloyeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emloyeeToolStripMenuItem.Name = "emloyeeToolStripMenuItem";
            this.emloyeeToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.emloyeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeEmployeeToolStripMenuItem_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFullName,
            this.columnLogin,
            this.columnPassword,
            this.columnProfessionList});
            this.dataGridViewEmployees.ContextMenuStrip = this.contextMenuStripDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(552, 196);
            this.dataGridViewEmployees.TabIndex = 14;
            this.dataGridViewEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_RowEnter);
            this.dataGridViewEmployees.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_RowLeave);
            // 
            // columnFullName
            // 
            this.columnFullName.HeaderText = "FullName";
            this.columnFullName.Name = "columnFullName";
            this.columnFullName.ReadOnly = true;
            // 
            // columnLogin
            // 
            this.columnLogin.HeaderText = "Login";
            this.columnLogin.Name = "columnLogin";
            this.columnLogin.ReadOnly = true;
            // 
            // columnPassword
            // 
            this.columnPassword.HeaderText = "Password";
            this.columnPassword.Name = "columnPassword";
            this.columnPassword.ReadOnly = true;
            // 
            // columnProfessionList
            // 
            this.columnProfessionList.HeaderText = "Professions";
            this.columnProfessionList.Name = "columnProfessionList";
            this.columnProfessionList.ReadOnly = true;
            // 
            // contextMenuStripDataGrid
            // 
            this.contextMenuStripDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowPassword,
            this.toolStripMenuItemHidePassword});
            this.contextMenuStripDataGrid.Name = "contextMenuStripDataGrid";
            this.contextMenuStripDataGrid.Size = new System.Drawing.Size(157, 48);
            // 
            // toolStripMenuItemShowPassword
            // 
            this.toolStripMenuItemShowPassword.Name = "toolStripMenuItemShowPassword";
            this.toolStripMenuItemShowPassword.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemShowPassword.Text = "Show password";
            this.toolStripMenuItemShowPassword.Click += new System.EventHandler(this.toolStripMenuItemShowPassword_Click);
            // 
            // toolStripMenuItemHidePassword
            // 
            this.toolStripMenuItemHidePassword.Name = "toolStripMenuItemHidePassword";
            this.toolStripMenuItemHidePassword.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemHidePassword.Text = "Hide password";
            this.toolStripMenuItemHidePassword.Click += new System.EventHandler(this.toolStripMenuItemHidePassword_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.menuStripManageEmployees);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageEmployeesForm_FormClosing);
            this.menuStripManageEmployees.ResumeLayout(false);
            this.menuStripManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.contextMenuStripDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripManageEmployees;
        private System.Windows.Forms.ToolStripMenuItem emloyeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessionList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowPassword;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHidePassword;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}