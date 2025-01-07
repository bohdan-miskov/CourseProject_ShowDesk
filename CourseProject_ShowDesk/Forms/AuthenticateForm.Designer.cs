namespace CourseProject_ShowDesk
{
    partial class AuthenticateForm
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
            this.groupBoxAuthenticate = new System.Windows.Forms.GroupBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.buttonAuthentificate = new System.Windows.Forms.Button();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBoxAuthenticate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxChoice.SuspendLayout();
            this.groupBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthenticate
            // 
            this.groupBoxAuthenticate.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.groupBoxAuthenticate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxAuthenticate.Controls.Add(this.pictureBoxAvatar);
            this.groupBoxAuthenticate.Controls.Add(this.groupBoxChoice);
            this.groupBoxAuthenticate.Controls.Add(this.groupBoxSignIn);
            this.groupBoxAuthenticate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuthenticate.Location = new System.Drawing.Point(1, 57);
            this.groupBoxAuthenticate.Name = "groupBoxAuthenticate";
            this.groupBoxAuthenticate.Size = new System.Drawing.Size(530, 277);
            this.groupBoxAuthenticate.TabIndex = 8;
            this.groupBoxAuthenticate.TabStop = false;
            this.groupBoxAuthenticate.Text = "Authenticate";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(22, 27);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(203, 236);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 8;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxChoice.Controls.Add(this.comboBoxUser);
            this.groupBoxChoice.Controls.Add(this.buttonAuthentificate);
            this.groupBoxChoice.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoice.Location = new System.Drawing.Point(244, 19);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(185, 118);
            this.groupBoxChoice.TabIndex = 9;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Choice role";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.Color.Silver;
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(6, 40);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(173, 29);
            this.comboBoxUser.TabIndex = 1;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxUser_KeyUp);
            // 
            // buttonAuthentificate
            // 
            this.buttonAuthentificate.BackColor = System.Drawing.Color.Silver;
            this.buttonAuthentificate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAuthentificate.Location = new System.Drawing.Point(6, 75);
            this.buttonAuthentificate.Name = "buttonAuthentificate";
            this.buttonAuthentificate.Size = new System.Drawing.Size(173, 37);
            this.buttonAuthentificate.TabIndex = 0;
            this.buttonAuthentificate.Text = "Sign In";
            this.buttonAuthentificate.UseVisualStyleBackColor = false;
            this.buttonAuthentificate.Click += new System.EventHandler(this.buttonAuthentificate_Click);
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSignIn.Controls.Add(this.textBoxPassword);
            this.groupBoxSignIn.Controls.Add(this.labelPassword);
            this.groupBoxSignIn.Controls.Add(this.labelLogin);
            this.groupBoxSignIn.Controls.Add(this.textBoxLogin);
            this.groupBoxSignIn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSignIn.Location = new System.Drawing.Point(245, 143);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(270, 120);
            this.groupBoxSignIn.TabIndex = 10;
            this.groupBoxSignIn.TabStop = false;
            this.groupBoxSignIn.Text = "Sign In";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(114, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(147, 28);
            this.textBoxPassword.TabIndex = 27;
            this.textBoxPassword.Text = "Administrator";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(21, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 26;
            this.labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(21, 36);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 21);
            this.labelLogin.TabIndex = 24;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(114, 29);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(147, 28);
            this.textBoxLogin.TabIndex = 25;
            this.textBoxLogin.Text = "Admin";
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 334);
            this.Controls.Add(this.groupBoxAuthenticate);
            this.Name = "AuthenticateForm";
            this.Text = "AuthenticateForm";
            this.groupBoxAuthenticate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthenticate;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonAuthentificate;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}