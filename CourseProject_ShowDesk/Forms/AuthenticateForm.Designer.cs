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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.buttonAuthentificate = new System.Windows.Forms.Button();
            this.groupBoxAuthenticate = new System.Windows.Forms.GroupBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelAuthenticate = new System.Windows.Forms.Panel();
            this.groupBoxAuthenticate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panelAuthenticate.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.Color.Silver;
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Administrator",
            "Cashier",
            "Director"});
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
            // groupBoxAuthenticate
            // 
            this.groupBoxAuthenticate.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAuthenticate.Controls.Add(this.comboBoxUser);
            this.groupBoxAuthenticate.Controls.Add(this.buttonAuthentificate);
            this.groupBoxAuthenticate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAuthenticate.Location = new System.Drawing.Point(213, 58);
            this.groupBoxAuthenticate.Name = "groupBoxAuthenticate";
            this.groupBoxAuthenticate.Size = new System.Drawing.Size(185, 118);
            this.groupBoxAuthenticate.TabIndex = 6;
            this.groupBoxAuthenticate.TabStop = false;
            this.groupBoxAuthenticate.Text = "Choice role";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(24, 13);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(174, 192);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 5;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // panelAuthenticate
            // 
            this.panelAuthenticate.BackColor = System.Drawing.Color.Transparent;
            this.panelAuthenticate.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.panelAuthenticate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAuthenticate.Controls.Add(this.groupBoxAuthenticate);
            this.panelAuthenticate.Controls.Add(this.pictureBoxAvatar);
            this.panelAuthenticate.Location = new System.Drawing.Point(-1, 63);
            this.panelAuthenticate.Name = "panelAuthenticate";
            this.panelAuthenticate.Size = new System.Drawing.Size(426, 222);
            this.panelAuthenticate.TabIndex = 7;
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseProject_ShowDesk.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 284);
            this.Controls.Add(this.panelAuthenticate);
            this.Name = "AuthenticateForm";
            this.Text = "AuthenticateForm";
            this.groupBoxAuthenticate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panelAuthenticate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonAuthentificate;
        private System.Windows.Forms.GroupBox groupBoxAuthenticate;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Panel panelAuthenticate;
    }
}