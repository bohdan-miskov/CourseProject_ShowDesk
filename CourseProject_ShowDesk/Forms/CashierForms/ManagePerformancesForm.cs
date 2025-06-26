using CourseProject_ShowDesk.Forms.DirectorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        private readonly PerformanceManager performanceManager;
        private readonly StageManager stageManager;
        private readonly Employee userAccount;

        private bool isPastPerformances = false;
        private DateTime pastPerformanceStartDate = DateTime.MinValue;
        private DateTime pastPerformanceEndDate = DateTime.MinValue;

        private readonly SearchDataGrid searchData;

        public ManagePerformancesForm(Employee userAccount)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this, true);

            try
            {
                performanceManager = new PerformanceManager(new PerformanceBaseService());
                stageManager = new StageManager(new StageBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee());
                settingsForm.ShowDialog();

                //FormConfigurator.RestartForm<ManagePerformancesForm>(this,userAccount);
                FormConfigurator.RestartApp();
            }

            timerUpdate.Interval = AppConstants.UpdatePerformancesInterval;

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;

            PopulateComponents();

            searchData = new SearchDataGrid(dataGridViewPerformances);
        }
        private async void ManagePerformancesForm_Load(object sender, EventArgs e)
        {
            await stageManager.LoadFromDatabaseAsync();
            await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();
            UpdateDataGridPerformances();
            DisableEditAndRemovePerformance();
        }
        private void ManagePerformancesForm_Shown(object sender, EventArgs e)
        {
            ShowGreetings(userAccount.FullName);

            timerUpdate.Start();
        }
        private void DataGridViewPerformances_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemovePerformance();
        }

        private void DataGridViewPerformances_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemovePerformance();
        }

        private async void AddPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddPerformanceAsync();
            await UpdateDataFromDataBaseAsync();
        }

        private async void EditPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditPerformanceAsync();
            await UpdateDataFromDataBaseAsync();
        }

        private async void RemovePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RemovePerformanceAsync();
            await UpdateDataFromDataBaseAsync();
        }

        private async void FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await FilterPerformancesWithFormAsync();
        }

        private async void TicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTickets();
            await UpdateDataFromDataBaseAsync();
        }
        private void RevenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRevenue();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByFragment();
        }
        private void TextBoxSearchField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchByFragment();
        }
        private void DataGridViewPerformances_KeyDown(object sender, KeyEventArgs e)
        {
            searchData.SearchNavigation(e);
        }
        private async void ButtonSwitch_Click(object sender, EventArgs e)
        {
            SwitchPerformances();
            await UpdateDataFromDataBaseAsync();
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
            searchData.ClearResults();
        }
        private void DateTimePickerPastPerformancesStartDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerPastPerformancesEndDate.Focus();
        }

        private void DateTimePickerPastPerformancesEndDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonLoadPastPerformance.Focus();
        }
        private void DateTimePickerPastPerformancesEndDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerPastPerformancesStartDate.MaxDate = dateTimePickerPastPerformancesEndDate.Value;
        }

        private void DateTimePickerPastPerformancesStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerPastPerformancesEndDate.MinDate = dateTimePickerPastPerformancesStartDate.Value;
        }
        private async void ButtonLoadPastPerformance_Click(object sender, EventArgs e)
        {
            SavePastPerformanceRange();
            await UpdateDataFromDataBaseAsync();
        }
        private async void ButtonCancelPastPerformance_Click(object sender, EventArgs e)
        {
            CancelPastPerformanceRange();
            await UpdateDataFromDataBaseAsync();
        }
        private async void TimerUpdate_Tick(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ManagePerformancesFormClosing(object sender, FormClosingEventArgs e)
        {
            timerUpdate.Stop();
        }

        private void ShowGreetings(string name)
        {
            MessageBox.Show(
                $"{name} Welcome to our program! You entered under the profession of {AppConstants.ListOfProfessions[2]}",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void PopulateComponents()
        {
            HidePastPerformanceRangeGroupBox();

            if (userAccount.ProfessionList.Contains(AppConstants.ListOfProfessions[1]))
            {
                performanceToolStripMenuItem.Visible = true;
                addPerformanceToolStripMenuItem1.Visible = true;
                editPerformanceToolStripMenuItem1.Visible = true;
                removePerformanceToolStripMenuItem1.Visible = true;
            }
            else
            {
                performanceToolStripMenuItem.Visible = false;
                addPerformanceToolStripMenuItem1.Visible = false;
                editPerformanceToolStripMenuItem1.Visible = false;
                removePerformanceToolStripMenuItem1.Visible = false;
            }
        }
        private void HidePastPerformanceRangeGroupBox()
        {
            groupBoxPastPerformanceRange.Enabled = false;
            groupBoxPastPerformanceRange.Visible = false;
        }
        private async Task UpdateDataFromDataBaseAsync()
        {
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            await stageManager.LoadFromDatabaseAsync();

            if (isPastPerformances)
            {
                if (pastPerformanceStartDate == DateTime.MinValue || pastPerformanceEndDate == DateTime.MinValue)
                    SelectPastPerformancesRange();
                else
                {
                    await performanceManager.LoadPastPerformancesFromDatabaseAsync(pastPerformanceStartDate, pastPerformanceEndDate); ;
                    UpdateDataGridPerformances(performanceManager.PastPerformances);
                    performanceManager.ResetPastPerformancesList();
                }
            }
            else
            {
                pastPerformanceStartDate = DateTime.MinValue;
                pastPerformanceEndDate = DateTime.MinValue;
                await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();
                UpdateDataGridPerformances();
            }

            DisableEditAndRemovePerformance();
            FormConfigurator.RemoveActivePictureBoxUpdate(pictureBoxUpdate);
        }
        private void UpdateDataGridPerformances(List<Performance> performances)
        {
            dataGridViewPerformances.Rows.Clear();

            foreach (Performance performance in performances)
            {
                AddPerformanceToDataGrid(performance);
            }
        }
        private void UpdateDataGridPerformances()
        {
            dataGridViewPerformances.Rows.Clear();

            foreach (Performance performance in performanceManager.Performances)
            {
                AddPerformanceToDataGrid(performance);
            }
        }
        private void SelectPastPerformancesRange()
        {
            Point center = GetFormCenter();
            groupBoxPastPerformanceRange.Location = new Point(
                center.X - groupBoxPastPerformanceRange.Width / 2,
                center.Y - groupBoxPastPerformanceRange.Height / 2
                );
            groupBoxPastPerformanceRange.Enabled = true;
            groupBoxPastPerformanceRange.Visible = true;

            dateTimePickerPastPerformancesEndDate.MaxDate = DateTime.Today;
            dateTimePickerPastPerformancesEndDate.Value = DateTime.Today;

            //DateTime startDay = DateTime.Today;
            dateTimePickerPastPerformancesStartDate.MaxDate = DateTime.Today;
            DateTime startDay = DateTime.Today.AddMonths(-1);
            dateTimePickerPastPerformancesStartDate.Value = startDay;

            dateTimePickerPastPerformancesStartDate.Focus();
        }
        private Point GetFormCenter()
        {
            return new Point(this.Width / 2, this.Height / 2);
        }
        private void AddPerformanceToDataGrid(Performance performance)
        {
            string timePerformance = $"{performance.LocalPerformanceDateTime.Hour:D2}:{performance.LocalPerformanceDateTime.Minute:D2}";
            dataGridViewPerformances.Rows.Add(
                performance.Id,
                performance.LocalPerformanceDateTime.Date.ToShortDateString(),
                timePerformance,
                performance.Name,
                performance.Price.ToString() + AppConstants.CurrencySymbol.ToString(),
                performance.Duration.ToString(),
                GetStageName(performance.StageId),
                GetTotalPositions(performance.StageId),
                performance.GetCountSoldTickets(),
                performance.GetCountReservedTickets()
                );
        }

        private string GetStageName(Guid stageId)
        {
            for (int i = 0; i < stageManager.Stages.Count; i++)
            {
                if (stageManager.Stages[i].Id == stageId)
                    return stageManager.Stages[i].Name;
            }
            return "Not found";
        }

        private int GetTotalPositions(Guid stageId)
        {
            for (int i = 0; i < stageManager.Stages.Count; i++)
            {
                if (stageManager.Stages[i].Id == stageId)
                    return stageManager.Stages[i].GetTotalPositions();
            }
            return 0;
        }

        private void DisableEditAndRemovePerformance()
        {
            if (dataGridViewPerformances.CurrentRow != null && !isPastPerformances)
            {
                editPerformanceToolStripMenuItem.Enabled = true;
                removePerformanceToolStripMenuItem.Enabled = true;
                editPerformanceToolStripMenuItem1.Enabled = true;
                removePerformanceToolStripMenuItem1.Enabled = true;
                ticketsToolStripMenuItem.Enabled = true;
                ticketsToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editPerformanceToolStripMenuItem.Enabled = false;
                removePerformanceToolStripMenuItem.Enabled = false;
                editPerformanceToolStripMenuItem1.Enabled = false;
                removePerformanceToolStripMenuItem1.Enabled = false;
                ticketsToolStripMenuItem.Enabled = false;
                ticketsToolStripMenuItem1.Enabled = false;

                if (isPastPerformances)
                {
                    addPerformanceToolStripMenuItem.Enabled = false;
                    addPerformanceToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    addPerformanceToolStripMenuItem.Enabled = true;
                    addPerformanceToolStripMenuItem1.Enabled = true;
                }
            }
        }

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].Value.ToString());
        }

        private async Task AddPerformanceAsync()
        {
            AddEditPerformanceForm addPerformanceForm = new AddEditPerformanceForm(userAccount, stageManager.Stages, performanceManager.Performances);
            this.Hide();
            addPerformanceForm.ShowDialog();

            if (addPerformanceForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (addPerformanceForm.GetIsValid())
            {
                Performance perf = addPerformanceForm.GetPerformance();
                await performanceManager.AddPerformanceAsync(perf);
            }
        }

        private async Task EditPerformanceAsync()
        {
            Guid id = GetCurrentRowId();

            AddEditPerformanceForm editPerformanceForm = new AddEditPerformanceForm(userAccount, stageManager.Stages, performanceManager.Performances, performanceManager.GetById(id));
            this.Hide();
            editPerformanceForm.ShowDialog();

            if (editPerformanceForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();


            if (editPerformanceForm.GetIsValid())
            {
                await performanceManager.UpdatePerformanceAsync(editPerformanceForm.GetPerformance());
            }
        }

        private async Task RemovePerformanceAsync()
        {
            Guid id = GetCurrentRowId();
            await performanceManager.RemovePerformanceAsync(id);
        }

        private async Task FilterPerformancesWithFormAsync()
        {
            AddEditPerformanceForm filterPerformanceForm = new AddEditPerformanceForm(userAccount, stageManager.Stages, performanceManager.Performances, null, true);
            this.Hide();
            filterPerformanceForm.ShowDialog();

            if (filterPerformanceForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (!filterPerformanceForm.GetIsValid()) return;

            List<Performance> filteredPerformances;
            Performance perfParameters = filterPerformanceForm.GetPerformance();

            if (isPastPerformances)
            {
                await performanceManager.LoadAllPastPerformancesFromDatabaseAsync();
                filteredPerformances = FilterPerformances(performanceManager.PastPerformances, perfParameters);
                performanceManager.ResetPastPerformancesList();
            }
            else
            {
                await performanceManager.LoadUpcomingPerformancesFromDatabaseAsync();
                filteredPerformances = FilterPerformances(performanceManager.Performances, perfParameters);
            }

            UpdateDataGridPerformances(filteredPerformances);
        }

        private List<Performance> FilterPerformances(List<Performance> performances, Performance perfParameters)
        {
            return performances.Where(performance =>
            {
                return (
                (string.IsNullOrWhiteSpace(perfParameters.Name) || performance.Name.ToLower().Contains(perfParameters.Name.ToLower())) &&
                (perfParameters.LocalPerformanceDateTime == DateTime.MinValue || performance.LocalPerformanceDateTime.Date == perfParameters.LocalPerformanceDateTime.Date) &&
                (perfParameters.Duration == TimeSpan.Zero || performance.Duration == perfParameters.Duration) &&
                (double.IsNaN(perfParameters.Price) || performance.Price == perfParameters.Price) &&
                (perfParameters.StageId == Guid.Empty || performance.StageId == perfParameters.StageId)
                );
            }).ToList();
        }

        private void ViewTickets()
        {
            Guid id = GetCurrentRowId();
            Performance currentPerformance = performanceManager.GetById(id);
            Stage currentStage = stageManager.GetById(currentPerformance.StageId);

            ManageTicketsForm manageTicketsForm = new ManageTicketsForm(userAccount, currentStage, currentPerformance);

            this.Hide();
            manageTicketsForm.ShowDialog();

            if (manageTicketsForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();
        }
        private void OpenRevenue()
        {
            ViewRevenueForm viewRevenueForm = new ViewRevenueForm(userAccount, performanceManager);

            this.Hide();
            viewRevenueForm.ShowDialog();
            if (viewRevenueForm.GetLogOut())
            {
                LogOut();
                return;
            }
            this.Show();
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

        private void SwitchPerformances()
        {
            if (isPastPerformances) isPastPerformances = false;
            else isPastPerformances = true;
        }

        private void SavePastPerformanceRange()
        {
            DateTime startDate = dateTimePickerPastPerformancesStartDate.Value;
            pastPerformanceStartDate = new DateTime(startDate.Year, startDate.Month, startDate.Day);
            DateTime endDate = dateTimePickerPastPerformancesEndDate.Value;
            pastPerformanceEndDate = new DateTime(endDate.Year, endDate.Month, endDate.Day + 1);
            HidePastPerformanceRangeGroupBox();
        }
        private void CancelPastPerformanceRange()
        {
            isPastPerformances = false;
            HidePastPerformanceRangeGroupBox();
        }

        private void LogOut()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
