using CourseProject_ShowDesk.Forms.CashierForms;
using CourseProject_ShowDesk.Forms.DirectorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class ManageStagesForm : MetroFramework.Forms.MetroForm
    {
        private readonly StageManager stageManager;
        private readonly Employee userAccount;

        private readonly SearchDataGrid searchData;

        public ManageStagesForm(Employee userAccount)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            try
            {
                stageManager = new StageManager(new StageBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee("Guest", "", ""));
                settingsForm.ShowDialog();

                //FormConfigurator.RestartForm<ManageStagesForm>(this, userAccount);
                FormConfigurator.RestartApp();
            }

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;

            timerUpdate.Interval = AppConstants.UpdateStagesInterval;

            UpdateDataGridStages();

            DisableEditAndRemoveStage();

            ShowGreetings(userAccount.FullName);

            timerUpdate.Start();

            searchData = new SearchDataGrid(dataGridViewStages);
        }

        private void DataGridViewStages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void DataGridViewStages_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void AddStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStage();
            UpdataDataFromDatabase();
        }

        private void EditStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStage();
            UpdataDataFromDatabase();
        }

        private void RemoveStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStage();
            UpdataDataFromDatabase();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByFragment();
        }

        private void TextBoxSearchField_Enter(object sender, EventArgs e)
        {
            SearchByFragment();
        }

        private void DataGridViewStages_KeyDown(object sender, KeyEventArgs e)
        {
            searchData.SearchNavigation(e);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdataDataFromDatabase();
        }
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdataDataFromDatabase();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void ManageStagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerUpdate.Stop();
        }

        private void ShowGreetings(string name)
        {
            MessageBox.Show(
                $"{name} Welcome to our program! You entered under the profession of {AppConstants.ListOfProfessions[1]}",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateDataGridStages()
        {
            dataGridViewStages.Rows.Clear();

            foreach (Stage stage in stageManager.Stages)
            {
                AddStageToDataGrid(stage);
            }
        }

        private void AddStageToDataGrid(Stage stage)
        {
            dataGridViewStages.Rows.Add(
                stage.Id,
                stage.Name,
                stage.Zones.Count,
                stage.SeatList.Count,
                stage.GetTotalPositions()
                    );
        }
        private void UpdataDataFromDatabase()
        {
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            stageManager.LoadFromDatabase();
            UpdateDataGridStages();
            DisableEditAndRemoveStage();
            FormConfigurator.RemoveActivePictureBoxUpdate(pictureBoxUpdate);
        }

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewStages.CurrentRow.Cells[0].Value.ToString());
        }

        private void AddStage()
        {
            AddStageForm addStageForm = new AddStageForm(userAccount);
            this.Hide();
            addStageForm.ShowDialog();
            this.Show();

            if (addStageForm.GetLogOut())
            {
                LogOut();
                return;
            }

            if (addStageForm.GetIsValid())
            {
                stageManager.AddStage(addStageForm.GetNewStage());
            }
        }

        private void EditStage()
        {
            Guid stageId = GetCurrentRowId();

            EditStageForm editStageForm = new EditStageForm(userAccount, stageManager.GetById(stageId));
            this.Hide();
            editStageForm.ShowDialog();
            this.Show();

            if (editStageForm.GetLogOut())
            {
                LogOut();
                return;
            }

            if (editStageForm.GetIsValid())
            {
                stageManager.UpdateStage(editStageForm.GetStage());
            }
        }

        private void RemoveStage()
        {
            Guid stageId = GetCurrentRowId();
            stageManager.RemoveStage(stageId);
        }

        private void DisableEditAndRemoveStage()
        {
            if (dataGridViewStages.CurrentRow != null)
            {
                editStageToolStripMenuItem.Enabled = true;
                removeStageToolStripMenuItem.Enabled = true;
                editStageToolStripMenuItem1.Enabled = true;
                removeStageToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editStageToolStripMenuItem.Enabled = false;
                removeStageToolStripMenuItem.Enabled = false;
                editStageToolStripMenuItem1.Enabled = false;
                removeStageToolStripMenuItem1.Enabled = false;
            }
        }

        private void SearchByFragment()
        {
            string searchField = textBoxSearchField.Text.Trim();

            searchData.Search(searchField);

            if (searchData.HasResults()) searchData.HighlightCurrentResult();
            else MessageBox.Show(
                                "No results found",
                                "Not found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void LogOut()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
