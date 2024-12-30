namespace CourseProject_TheaterHub
{
    partial class AddStageForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.groupBoxStage = new System.Windows.Forms.GroupBox();
            this.groupBoxStage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(138, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(138, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 28);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(40, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 21);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Enabled = false;
            this.textBoxIndex.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndex.Location = new System.Drawing.Point(138, 40);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(168, 28);
            this.textBoxIndex.TabIndex = 6;
            this.textBoxIndex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIndex_KeyUp);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(40, 47);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(54, 21);
            this.labelIndex.TabIndex = 5;
            this.labelIndex.Text = "Index";
            // 
            // groupBoxStage
            // 
            this.groupBoxStage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStage.BackgroundImage = global::CourseProject_TheaterHub.Properties.Resources.formBackground;
            this.groupBoxStage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxStage.Controls.Add(this.labelIndex);
            this.groupBoxStage.Controls.Add(this.buttonAdd);
            this.groupBoxStage.Controls.Add(this.textBoxIndex);
            this.groupBoxStage.Controls.Add(this.textBoxName);
            this.groupBoxStage.Controls.Add(this.labelName);
            this.groupBoxStage.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStage.Location = new System.Drawing.Point(1, 62);
            this.groupBoxStage.Name = "groupBoxStage";
            this.groupBoxStage.Size = new System.Drawing.Size(362, 186);
            this.groupBoxStage.TabIndex = 10;
            this.groupBoxStage.TabStop = false;
            this.groupBoxStage.Text = "Stage";
            // 
            // AddStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 247);
            this.Controls.Add(this.groupBoxStage);
            this.Name = "AddStageForm";
            this.Text = "AddStageForm";
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.GroupBox groupBoxStage;
    }
}