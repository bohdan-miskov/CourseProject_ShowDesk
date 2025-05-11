using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddStageForm : MetroFramework.Forms.MetroForm
    {
        private bool logOut;
        private bool isValid;

        private readonly Stage newStage;
        private readonly Employee userAccount;
        private readonly StageValidator validator;

        public AddStageForm(Employee userAccount, List<Stage> stages)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;
            validator = new StageValidator(stages);
            newStage = new Stage();

            isValid = false;
            logOut = false;
        }

        private void TextBoxStageName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAdd.Focus();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SaveStage();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void SaveStage()
        {
            CreateStage();
            if (validator.Validate(newStage, out string errorMessage))
            {
                AddEditSeatingForm addSeatingForm = new AddEditSeatingForm(userAccount);
                this.Hide();
                addSeatingForm.ShowDialog();

                if (addSeatingForm.GetLogOut())
                {
                    LogOut();
                    return;
                }

                if (addSeatingForm.GetIsValid())
                {
                    newStage.SeatList = addSeatingForm.GetSeatList();
                    newStage.DecorList = addSeatingForm.GetDecorList();
                    newStage.StageLocation = addSeatingForm.GetCanvasLocation();
                    newStage.StageSize = addSeatingForm.GetCanvasSize();

                    isValid = true;
                    this.Close();
                }
                else this.Show();
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
            newStage.Name = stageName;
        }

        private void LogOut()
        {
            logOut = true;
            this.Close();
        }

        public bool GetLogOut()
        {
            return logOut;
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
