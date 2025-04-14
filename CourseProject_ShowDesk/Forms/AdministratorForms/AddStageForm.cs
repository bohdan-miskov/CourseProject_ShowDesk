using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddStageForm : MetroFramework.Forms.MetroForm
    {
        private bool isValid;

        private Stage newStage;
        private readonly Employee userAccount;

        public AddStageForm(Employee userAccount)
        {
            InitializeComponent();

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;

            isValid = false;
        }

        private void TextBoxStageName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAdd.Focus();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SaveStage();
        }
        private void SaveStage()
        {
            CreateStage();
            StageValidator validator = new StageValidator();
            if (validator.Validate(newStage, out string errorMessage))
            {
                AddEditSeatingForm addSeatingForm = new AddEditSeatingForm(userAccount);
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

        private void CreateStage()
        {
            string stageName = textBoxStageName.Text;
            newStage = new Stage(stageName);
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
