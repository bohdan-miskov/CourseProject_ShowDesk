namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    partial class AddEditSeatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSeatingForm));
            this.buttonAddSeat = new System.Windows.Forms.Button();
            this.buttonAddDecor = new System.Windows.Forms.Button();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.buttonSetUnavailable = new System.Windows.Forms.Button();
            this.buttonDeleteSeat = new System.Windows.Forms.Button();
            this.buttonDeleteDecor = new System.Windows.Forms.Button();
            this.buttonInsertSeat = new System.Windows.Forms.Button();
            this.panelSeating = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.pictureBoxAccountIcon = new System.Windows.Forms.PictureBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.groupBoxProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSeat
            // 
            this.buttonAddSeat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAddSeat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSeat.Location = new System.Drawing.Point(23, 60);
            this.buttonAddSeat.Name = "buttonAddSeat";
            this.buttonAddSeat.Size = new System.Drawing.Size(104, 41);
            this.buttonAddSeat.TabIndex = 0;
            this.buttonAddSeat.Text = "Add Seat";
            this.buttonAddSeat.UseVisualStyleBackColor = false;
            this.buttonAddSeat.Click += new System.EventHandler(this.ButtonAddSeat_Click);
            // 
            // buttonAddDecor
            // 
            this.buttonAddDecor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAddDecor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDecor.Location = new System.Drawing.Point(23, 258);
            this.buttonAddDecor.Name = "buttonAddDecor";
            this.buttonAddDecor.Size = new System.Drawing.Size(104, 41);
            this.buttonAddDecor.TabIndex = 1;
            this.buttonAddDecor.Text = "Add Decor";
            this.buttonAddDecor.UseVisualStyleBackColor = false;
            this.buttonAddDecor.Click += new System.EventHandler(this.ButtonAddDecor_Click);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonChangeColor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeColor.Location = new System.Drawing.Point(23, 352);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(104, 41);
            this.buttonChangeColor.TabIndex = 2;
            this.buttonChangeColor.Text = "Change color";
            this.buttonChangeColor.UseVisualStyleBackColor = false;
            this.buttonChangeColor.Click += new System.EventHandler(this.ButtonChangeColor_Click);
            // 
            // buttonSetUnavailable
            // 
            this.buttonSetUnavailable.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSetUnavailable.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetUnavailable.Location = new System.Drawing.Point(23, 201);
            this.buttonSetUnavailable.Name = "buttonSetUnavailable";
            this.buttonSetUnavailable.Size = new System.Drawing.Size(104, 51);
            this.buttonSetUnavailable.TabIndex = 3;
            this.buttonSetUnavailable.Text = "Set Unavailable";
            this.buttonSetUnavailable.UseVisualStyleBackColor = false;
            this.buttonSetUnavailable.Click += new System.EventHandler(this.ButtonSetUnavailable_Click);
            // 
            // buttonDeleteSeat
            // 
            this.buttonDeleteSeat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDeleteSeat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSeat.Location = new System.Drawing.Point(23, 154);
            this.buttonDeleteSeat.Name = "buttonDeleteSeat";
            this.buttonDeleteSeat.Size = new System.Drawing.Size(104, 41);
            this.buttonDeleteSeat.TabIndex = 4;
            this.buttonDeleteSeat.Text = "Delete Seat";
            this.buttonDeleteSeat.UseVisualStyleBackColor = false;
            this.buttonDeleteSeat.Click += new System.EventHandler(this.ButtonDeleteSeat_Click);
            // 
            // buttonDeleteDecor
            // 
            this.buttonDeleteDecor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDeleteDecor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDecor.Location = new System.Drawing.Point(23, 305);
            this.buttonDeleteDecor.Name = "buttonDeleteDecor";
            this.buttonDeleteDecor.Size = new System.Drawing.Size(104, 41);
            this.buttonDeleteDecor.TabIndex = 6;
            this.buttonDeleteDecor.Text = "Delete Decor";
            this.buttonDeleteDecor.UseVisualStyleBackColor = false;
            this.buttonDeleteDecor.Click += new System.EventHandler(this.ButtonDeleteDecor_Click);
            // 
            // buttonInsertSeat
            // 
            this.buttonInsertSeat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInsertSeat.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertSeat.Location = new System.Drawing.Point(23, 107);
            this.buttonInsertSeat.Name = "buttonInsertSeat";
            this.buttonInsertSeat.Size = new System.Drawing.Size(104, 41);
            this.buttonInsertSeat.TabIndex = 5;
            this.buttonInsertSeat.Text = "Insert Seat";
            this.buttonInsertSeat.UseVisualStyleBackColor = false;
            this.buttonInsertSeat.Click += new System.EventHandler(this.ButtonInsertSeat_Click);
            // 
            // panelSeating
            // 
            this.panelSeating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSeating.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSeating.Location = new System.Drawing.Point(135, 60);
            this.panelSeating.Name = "panelSeating";
            this.panelSeating.Size = new System.Drawing.Size(645, 427);
            this.panelSeating.TabIndex = 7;
            this.panelSeating.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseDown);
            this.panelSeating.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseMove);
            this.panelSeating.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelSeating_MouseUp);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(25, 443);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.pictureBoxAccountIcon);
            this.groupBoxProfile.Controls.Add(this.labelAccountName);
            this.groupBoxProfile.Location = new System.Drawing.Point(613, 23);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(167, 31);
            this.groupBoxProfile.TabIndex = 17;
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
            // AddEditSeatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDeleteDecor);
            this.Controls.Add(this.panelSeating);
            this.Controls.Add(this.buttonInsertSeat);
            this.Controls.Add(this.buttonDeleteSeat);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.buttonSetUnavailable);
            this.Controls.Add(this.buttonAddSeat);
            this.Controls.Add(this.buttonAddDecor);
            this.Name = "AddEditSeatingForm";
            this.Text = "AddEditSeatingForm";
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccountIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddSeat;
        private System.Windows.Forms.Button buttonDeleteSeat;
        private System.Windows.Forms.Button buttonSetUnavailable;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.Button buttonAddDecor;
        private System.Windows.Forms.Button buttonDeleteDecor;
        private System.Windows.Forms.Button buttonInsertSeat;
        private System.Windows.Forms.Panel panelSeating;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxAccountIcon;
        private System.Windows.Forms.Label labelAccountName;
    }
}