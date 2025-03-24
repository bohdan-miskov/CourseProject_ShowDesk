using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddStageForm : MetroFramework.Forms.MetroForm
    {
        private int index;

        private bool isValid;

        private Stage newStage;

        public AddStageForm(int index)
        {
            InitializeComponent();

            this.index = index;

            textBoxIndex.Text = Convert.ToString(index);

            isValid = false;
            newStage = new Stage();
        }

        private void TextBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxStageName.Focus();
            }
        }

        private void TextBoxStageName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SaveStage();
        }
        private void SaveStage()
        {
            newStage = CreateStage();
            StageValidator validator = new StageValidator();
            if (validator.Validate(newStage,out string errorMessage))
            {
                AddEditSeatingForm addSeatingForm = new AddEditSeatingForm();
                this.Hide();
                addSeatingForm.ShowDialog();
                this.Show();

                if (addSeatingForm.GetIsValid())
                {
                    newStage.SeatList = addSeatingForm.GetSeatList();
                    newStage.DecorList = addSeatingForm.GetDecorList();

                    isValid = true;
                    this.Close();
                }
            }
            else MessageBox.Show(
                                errorMessage,
                                "Stage error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }

        private Stage CreateStage()
        {
            string stageName = textBoxStageName.Text;

            return newStage = new Stage(index, stageName);    
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public Stage GetNewStage()
        {
            return newStage;
        }
    }
}
