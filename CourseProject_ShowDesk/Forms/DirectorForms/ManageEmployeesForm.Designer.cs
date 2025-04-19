namespace CourseProject_ShowDesk.Forms.DirectorForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeesForm));
            this.menuStripManageEmployees = new System.Windows.Forms.MenuStrip();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessionList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelAccountName = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItemShowPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHidePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emloyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchField = new System.Windows.Forms.TextBox();
            this.menuStripManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.contextMenuStripEmployees.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripManageEmployees
            // 
            this.menuStripManageEmployees.BackColor = System.Drawing.Color.Azure;
            this.menuStripManageEmployees.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripManageEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emloyeeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripManageEmployees.Location = new System.Drawing.Point(0, 0);
            this.menuStripManageEmployees.Name = "menuStripManageEmployees";
            this.menuStripManageEmployees.Size = new System.Drawing.Size(193, 26);
            this.menuStripManageEmployees.TabIndex = 13;
            this.menuStripManageEmployees.Text = "menuStrip1";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.columnFullName,
            this.columnLogin,
            this.columnPassword,
            this.columnProfessionList});
            this.dataGridViewEmployees.ContextMenuStrip = this.contextMenuStripEmployees;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewEmployees.MultiSelect = false;
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(596, 208);
            this.dataGridViewEmployees.TabIndex = 14;
            this.dataGridViewEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmployees_RowEnter);
            this.dataGridViewEmployees.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmployees_RowLeave);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
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
            // contextMenuStripEmployees
            // 
            this.contextMenuStripEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowPassword,
            this.toolStripMenuItemHidePassword,
            this.addEmployeeToolStripMenuItem1,
            this.editEmployeeToolStripMenuItem1,
            this.removeEmployeeToolStripMenuItem1});
            this.contextMenuStripEmployees.Name = "contextMenuStripDataGrid";
            this.contextMenuStripEmployees.Size = new System.Drawing.Size(173, 114);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.ContextMenuStrip = this.contextMenuStripAccount;
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(449, 22);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 15;
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
            // timerUpdate
            // 
            this.timerUpdate.Interval = 300000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUpdate.Image = global::CourseProject_ShowDesk.Properties.Resources.restart_icon;
            this.pictureBoxUpdate.Location = new System.Drawing.Point(422, 29);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 22;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
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
            // toolStripMenuItemShowPassword
            // 
            this.toolStripMenuItemShowPassword.Image = global::CourseProject_ShowDesk.Properties.Resources.show_icon;
            this.toolStripMenuItemShowPassword.Name = "toolStripMenuItemShowPassword";
            this.toolStripMenuItemShowPassword.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemShowPassword.Text = "Show password";
            this.toolStripMenuItemShowPassword.Click += new System.EventHandler(this.ToolStripMenuItemShowPassword_Click);
            // 
            // toolStripMenuItemHidePassword
            // 
            this.toolStripMenuItemHidePassword.Image = global::CourseProject_ShowDesk.Properties.Resources.hide_icon;
            this.toolStripMenuItemHidePassword.Name = "toolStripMenuItemHidePassword";
            this.toolStripMenuItemHidePassword.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItemHidePassword.Text = "Hide password";
            this.toolStripMenuItemHidePassword.Click += new System.EventHandler(this.ToolStripMenuItemHidePassword_Click);
            // 
            // addEmployeeToolStripMenuItem1
            // 
            this.addEmployeeToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            this.addEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.addEmployeeToolStripMenuItem1.Text = "Add employee";
            this.addEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem1
            // 
            this.editEmployeeToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editEmployeeToolStripMenuItem1.Name = "editEmployeeToolStripMenuItem1";
            this.editEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.editEmployeeToolStripMenuItem1.Text = "Edit employee";
            this.editEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.EditEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem1
            // 
            this.removeEmployeeToolStripMenuItem1.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeEmployeeToolStripMenuItem1.Name = "removeEmployeeToolStripMenuItem1";
            this.removeEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.removeEmployeeToolStripMenuItem1.Text = "Remove employee";
            this.removeEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.RemoveEmployeeToolStripMenuItem_Click);
            // 
            // emloyeeToolStripMenuItem
            // 
            this.emloyeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem});
            this.emloyeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emloyeeToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.employee_icon;
            this.emloyeeToolStripMenuItem.Name = "emloyeeToolStripMenuItem";
            this.emloyeeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.emloyeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.add_icon;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.edit_icon;
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.EditEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.remove_icon;
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.RemoveEmployeeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Image = global::CourseProject_ShowDesk.Properties.Resources.settings_icon;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.search_icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(385, 27);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(26, 26);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxSearchField
            // 
            this.textBoxSearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchField.Location = new System.Drawing.Point(240, 27);
            this.textBoxSearchField.Name = "textBoxSearchField";
            this.textBoxSearchField.Size = new System.Drawing.Size(139, 26);
            this.textBoxSearchField.TabIndex = 23;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 288);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchField);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.menuStripManageEmployees);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageEmployeesForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageEmployeesForm_KeyDown);
            this.menuStripManageEmployees.ResumeLayout(false);
            this.menuStripManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.contextMenuStripEmployees.ResumeLayout(false);
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.contextMenuStripAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEmployees;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowPassword;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHidePassword;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessionList;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchField;
    }
}