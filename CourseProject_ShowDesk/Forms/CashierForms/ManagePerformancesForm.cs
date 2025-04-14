using CourseProject_ShowDesk.Forms.DirectorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        private readonly PerformanceManager performanceManager;
        private readonly StageManager stageManager;
        private readonly Employee userAccount;

        private bool isPastPerformances = false;

        public ManagePerformancesForm(Employee userAccount)
        {
            InitializeComponent();

            try
            {
                performanceManager = new PerformanceManager(new PerformanceBaseService());
                stageManager = new StageManager(new StageBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee("Guest", "", ""));
            }

            timerUpdate.Interval = AppConstants.UpdatePerformancesInterval;

            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;

            PopulateComponents();

            UpdateDataGridPerformances();

            DisableEditAndRemovePerformance();

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

        private void AddPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerformance();
            UpdateDataFromDataBase();
        }

        private void EditPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerformance();
            UpdateDataFromDataBase();
        }

        private void RemovePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePerformance();
            UpdateDataFromDataBase();
        }
        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTickets();
            UpdateDataFromDataBase();
        }
        private void RevenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRevenue();
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            SwitchPerformances();
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
        }
        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
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

        private void UpdateDataFromDataBase()
        {
            stageManager.LoadFromDatabase();
            performanceManager.LoadFromDatabase();

            if (isPastPerformances) UpdateDataGridPerformances(performanceManager.PastPerformances);
            else UpdateDataGridPerformances();

            DisableEditAndRemovePerformance();
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

        private void AddPerformanceToDataGrid(Performance performance)
        {
            string timePerformance = $"{performance.PerformanceDateTime.Hour:D2}:{performance.PerformanceDateTime.Minute:D2}";
            dataGridViewPerformances.Rows.Add(
                performance.Id,
                performance.PerformanceDateTime.Date.ToShortDateString(),
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
            }
        }

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].Value.ToString());
        }

        private void AddPerformance()
        {
            AddEditPerformanceForm addPerformanceForm = new AddEditPerformanceForm(userAccount, stageManager.Stages, performanceManager.Performances);
            this.Hide();
            addPerformanceForm.ShowDialog();
            this.Show();

            if (addPerformanceForm.GetIsValid())
            {
                performanceManager.AddPerformance(addPerformanceForm.GetPerformance());
            }
        }

        private void EditPerformance()
        {
            Guid id = GetCurrentRowId();

            AddEditPerformanceForm editPerformanceForm = new AddEditPerformanceForm(userAccount, stageManager.Stages, performanceManager.Performances, performanceManager.GetById(id));
            this.Hide();
            editPerformanceForm.ShowDialog();
            this.Show();

            if (editPerformanceForm.GetIsValid())
            {
                performanceManager.UpdatePerformance(editPerformanceForm.GetPerformance());
            }
        }

        private void RemovePerformance()
        {
            Guid id = GetCurrentRowId();
            performanceManager.RemovePerformance(id);
        }

        private void ViewTickets()
        {
            Guid id = GetCurrentRowId();
            Performance currentPerformance = performanceManager.GetById(id);
            Stage currentStage = stageManager.GetById(currentPerformance.StageId);

            ManageTicketsForm manageTicketsForm = new ManageTicketsForm(userAccount, currentStage, currentPerformance);

            this.Hide();
            manageTicketsForm.ShowDialog();
            this.Show();
        }
        private void OpenRevenue()
        {
            ViewRevenueForm viewRevenueForm = new ViewRevenueForm(userAccount, performanceManager.PastPerformances);

            this.Hide();
            viewRevenueForm.ShowDialog();
            this.Show();
        }

        private void SwitchPerformances()
        {
            if (isPastPerformances)
            {
                UpdateDataGridPerformances();
                isPastPerformances = false;
            }
            else
            {
                UpdateDataGridPerformances(performanceManager.PastPerformances);
                isPastPerformances = true;
            }
        }
    }
}
