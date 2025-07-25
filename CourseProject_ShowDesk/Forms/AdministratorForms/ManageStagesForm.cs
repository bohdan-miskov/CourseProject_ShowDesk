﻿using CourseProject_ShowDesk.Forms.DirectorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class ManageStagesForm : MetroFramework.Forms.MetroForm
    {
        private readonly StageManager stageManager;
        private readonly PerformanceManager performanceManager;
        private readonly Employee userAccount;

        private readonly SearchDataGrid searchData;

        public ManageStagesForm(Employee userAccount)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this, true);

            try
            {
                stageManager = new StageManager(new StageBaseService());
                performanceManager = new PerformanceManager(new PerformanceBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee());
                settingsForm.ShowDialog();

                //FormConfigurator.RestartForm<ManageStagesForm>(this, userAccount);
                FormConfigurator.RestartApp();
            }

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;

            timerUpdate.Interval = AppConstants.UpdateStagesInterval;

            searchData = new SearchDataGrid(dataGridViewStages);
        }
        private async void ManageStagesForm_Load(object sender, EventArgs e)
        {
            await stageManager.LoadFromDatabaseAsync();
            await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();
            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void ManageStagesForm_Shown(object sender, EventArgs e)
        {
            ShowGreetings(userAccount.FullName);

            timerUpdate.Start();
        }
        private void DataGridViewStages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void DataGridViewStages_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private async void AddStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddStageAsync();
            await UpdataDataFromDatabaseAsync();
        }

        private async void EditStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditStageAsync();
            await UpdataDataFromDatabaseAsync();
        }

        private async void RemoveStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RemoveStageAsync();
            await UpdataDataFromDatabaseAsync();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByFragment();
        }

        private void TextBoxSearchField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchByFragment();
        }

        private void DataGridViewStages_KeyDown(object sender, KeyEventArgs e)
        {
            searchData.SearchNavigation(e);
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await UpdataDataFromDatabaseAsync();
        }
        private async void TimerUpdate_Tick(object sender, EventArgs e)
        {
            await UpdataDataFromDatabaseAsync();
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
        private async Task UpdataDataFromDatabaseAsync()
        {
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            await stageManager.LoadFromDatabaseAsync();
            UpdateDataGridStages();
            DisableEditAndRemoveStage();
            FormConfigurator.RemoveActivePictureBoxUpdate(pictureBoxUpdate);
        }

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewStages.CurrentRow.Cells[0].Value.ToString());
        }

        private async Task AddStageAsync()
        {
           await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();
            AddStageForm addStageForm = new AddStageForm(userAccount, stageManager.Stages);
            this.Hide();
            addStageForm.ShowDialog();

            if (addStageForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (addStageForm.GetIsValid())
            {
                await stageManager.AddStageAsync(addStageForm.GetNewStage());
            }
        }

        private async Task EditStageAsync()
        {
            Guid stageId = GetCurrentRowId();
            await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();

            EditStageForm editStageForm = new EditStageForm(
                userAccount,
                stageManager.GetById(stageId),
                stageManager.Stages,
                performanceManager.Performances
                );
            this.Hide();
            editStageForm.ShowDialog();

            if (editStageForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (editStageForm.GetIsValid())
            {
                await stageManager.UpdateStageAsync(editStageForm.GetStage());
            }
        }

        private async Task RemoveStageAsync()
        {
            Guid stageId = GetCurrentRowId();
            Stage currentsStage = stageManager.GetById(stageId);
            await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();

            if (IsStageActive(currentsStage, out string errorMessage))
            {
                MessageBox.Show(
                                errorMessage,
                                "Stage error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            await stageManager.RemoveStageAsync(stageId);
        }
        private bool IsStageActive(Stage stage, out string errorMessage)
        {
            errorMessage = null;
            if (performanceManager.Performances == null) return false;

            foreach (Performance performance in performanceManager.Performances)
            {
                if (performance.StageId == stage.Id)
                {
                    errorMessage = "There was an error in the stage: If an upcoming performance is using this stage, its stage cannot be romove.";
                    return true;
                }
            }

            return false;
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
