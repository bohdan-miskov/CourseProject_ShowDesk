using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Scripts.Enities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
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

        private void textBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxStageName.Focus();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAdd.Focus();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SaveStage();
        }

        private void AddStageForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void SaveStage()
        {
            if (ValidateOfStage())
            {

                AddStage();

                AddEditSeatingForm addSeatingForm = new AddEditSeatingForm(null);
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
        }

        private void AddStage()
        {
            string stageName = textBoxStageName.Text;

            newStage = new Stage(index, stageName);    
        }

        private bool ValidateOfStage()
        {
            if (!ValidateOfStageName()) return false;

            return true;
        }

        private bool ValidateOfStageName()
        {
            if (!ParametersValidator.NameValidator(textBoxStageName.Text))
            {
                MessageBox.Show(
                                "There was an error in the name of the stage: the name must be more than two characters long",
                                "Stage name error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxStageName.Focus();
                return false;
            }
            return true;
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
