namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    partial class AddEditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEmployeeForm));
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.groupBoxProfessionList = new System.Windows.Forms.GroupBox();
            this.checkBoxCashier = new System.Windows.Forms.CheckBox();
            this.checkBoxDirector = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelEmployeeFullName = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxProfessionList.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxEmployee.Controls.Add(this.groupBoxProfessionList);
            this.groupBoxEmployee.Controls.Add(this.textBoxPassword);
            this.groupBoxEmployee.Controls.Add(this.labelEmployeeFullName);
            this.groupBoxEmployee.Controls.Add(this.textBoxFullName);
            this.groupBoxEmployee.Controls.Add(this.labelPassword);
            this.groupBoxEmployee.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployee.Controls.Add(this.labelLogin);
            this.groupBoxEmployee.Controls.Add(this.textBoxLogin);
            this.groupBoxEmployee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployee.Location = new System.Drawing.Point(0, 63);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(394, 257);
            this.groupBoxEmployee.TabIndex = 24;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee";
            // 
            // groupBoxProfessionList
            // 
            this.groupBoxProfessionList.Controls.Add(this.checkBoxCashier);
            this.groupBoxProfessionList.Controls.Add(this.checkBoxDirector);
            this.groupBoxProfessionList.Controls.Add(this.checkBoxAdministrator);
            this.groupBoxProfessionList.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProfessionList.Location = new System.Drawing.Point(9, 142);
            this.groupBoxProfessionList.Name = "groupBoxProfessionList";
            this.groupBoxProfessionList.Size = new System.Drawing.Size(162, 108);
            this.groupBoxProfessionList.TabIndex = 24;
            this.groupBoxProfessionList.TabStop = false;
            this.groupBoxProfessionList.Text = "Professions";
            // 
            // checkBoxCashier
            // 
            this.checkBoxCashier.AutoSize = true;
            this.checkBoxCashier.Location = new System.Drawing.Point(11, 80);
            this.checkBoxCashier.Name = "checkBoxCashier";
            this.checkBoxCashier.Size = new System.Drawing.Size(75, 22);
            this.checkBoxCashier.TabIndex = 2;
            this.checkBoxCashier.Text = "Cashier";
            this.checkBoxCashier.UseVisualStyleBackColor = true;
            this.checkBoxCashier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckBoxCashier_KeyUp);
            // 
            // checkBoxDirector
            // 
            this.checkBoxDirector.AutoSize = true;
            this.checkBoxDirector.Location = new System.Drawing.Point(11, 24);
            this.checkBoxDirector.Name = "checkBoxDirector";
            this.checkBoxDirector.Size = new System.Drawing.Size(80, 22);
            this.checkBoxDirector.TabIndex = 1;
            this.checkBoxDirector.Text = "Director";
            this.checkBoxDirector.UseVisualStyleBackColor = true;
            this.checkBoxDirector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckBoxDirector_KeyUp);
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(11, 52);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(119, 22);
            this.checkBoxAdministrator.TabIndex = 0;
            this.checkBoxAdministrator.Text = "Administrator";
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            this.checkBoxAdministrator.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckBoxAdministrator_KeyUp);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(201, 102);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(168, 28);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyUp);
            // 
            // labelEmployeeFullName
            // 
            this.labelEmployeeFullName.AutoSize = true;
            this.labelEmployeeFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeFullName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFullName.Location = new System.Drawing.Point(16, 44);
            this.labelEmployeeFullName.Name = "labelEmployeeFullName";
            this.labelEmployeeFullName.Size = new System.Drawing.Size(90, 21);
            this.labelEmployeeFullName.TabIndex = 14;
            this.labelEmployeeFullName.Text = "Full name";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(201, 37);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(168, 28);
            this.textBoxFullName.TabIndex = 15;
            this.textBoxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFullName_KeyPress);
            this.textBoxFullName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxFullName_KeyUp);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(16, 109);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Password";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAddEmployee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(201, 196);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(168, 48);
            this.buttonAddEmployee.TabIndex = 16;
            this.buttonAddEmployee.Text = "Save";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(16, 75);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 21);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(201, 68);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(168, 28);
            this.textBoxLogin.TabIndex = 18;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLogin_KeyPress);
            this.textBoxLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxLogin_KeyUp);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(217, 26);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 25;
            this.groupBoxProfile.TabStop = false;
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
            // AddEditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "AddEditEmployeeForm";
            this.Text = "AddEditEmployee";
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxProfessionList.ResumeLayout(false);
            this.groupBoxProfessionList.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label labelEmployeeFullName;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxProfessionList;
        private System.Windows.Forms.CheckBox checkBoxCashier;
        private System.Windows.Forms.CheckBox checkBoxDirector;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
    }
}