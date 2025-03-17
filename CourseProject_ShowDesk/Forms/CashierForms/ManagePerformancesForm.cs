using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        private List<Stage> stages;

        private PerformanceManager performanceManager;

        private int countOfPastPerformances;

        private bool isPastPerformances = false;

        public ManagePerformancesForm(string accountName)
        {
            InitializeComponent();
            stages = new List<Stage>();
            performanceManager = new PerformanceManager();

            labelAccountName.Text = accountName;

            LoadPerformancesFromFile();
            LoadStagesFromFile();

            FliterPerformancesByDate();

            UpdateDataGridPerformances();

            DisableEditAndRemoveStage();

            ShowGreetings(accountName);
        }

        private void dataGridViewPerformances_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void dataGridViewPerformances_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void addPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerformance();

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void editPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerformance();

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void removePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].ToString());

            performanceManager.RemovePerformance(id);

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRevenue();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            SwitchPerformances();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManagePerformancesFormClosing(object sender, FormClosingEventArgs e)
        {
            SavePerformancesToFile();
        }

        private void ManagePerformancesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowGreetings(string name)
        {
            MessageBox.Show(
                $"{name} Welcome to our program! You entered under the profession of {AppConstants.ListOfProfessions[2]}",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateDataGridPerformances()
        {
            dataGridViewPerformances.Rows.Clear();
            performanceToolStripMenuItem.Enabled = true;
            addPerformanceToolStripMenuItem1.Enabled = true;
            editPerformanceToolStripMenuItem1.Enabled = true;
            removePerformanceToolStripMenuItem1.Enabled = true;
            countOfPastPerformances = 0;

            SortPerformancesByDate();

            foreach (Performance performance in performanceManager.Performances)
            {
                if (performance.PerformanceDateTime > DateTime.Now)
                {
                    AddPerformanceToDataGrid(performance);
                }
                else
                {
                    countOfPastPerformances++;
                }
            }
        }

        private void UpdateDataGridPastPerformances()
        {
            dataGridViewPerformances.Rows.Clear();
            performanceToolStripMenuItem.Enabled = false;
            addPerformanceToolStripMenuItem1.Enabled = false;
            editPerformanceToolStripMenuItem1.Enabled = false;
            removePerformanceToolStripMenuItem1.Enabled = false;

            foreach (Performance performance in performanceManager.Performances)
            {
                if (performance.PerformanceDateTime < DateTime.Now)
                {
                    AddPerformanceToDataGrid(performance);
                }
            }
        }

        private void AddPerformanceToDataGrid(Performance performance)
        {
            string timePerformance = $"{performance.PerformanceDateTime.Hour:D2}:{performance.PerformanceDateTime.Minute:D2}";
            dataGridViewPerformances.Rows.Add(
                performance.PerformanceDateTime.Date.ToShortDateString(),
                timePerformance,
                performance.Name,
                performance.Price.ToString()+AppConstants.CurrencySymbol.ToString(),
                performance.Duration.ToString(),
                GetStageName(performance.StageIndex),
                GetTotalPositions(performance.StageIndex),
                GetSoldTickets(performance.Tickets),
                GetReservedTickets(performance.Tickets)
                );
        }

        //private void SortPerformancesByDate()
        //{
        //    for(int i=0; i<performanceManager.Performances.Count-1; i++)
        //    {
        //        for(int j=0; j< performanceManager.Performances.Count-i-1;  j++)
        //        {
        //            if (performances[j].PerformanceDateTime > performances[j+1].PerformanceDateTime)
        //            {
        //                Performance tempPerformance=performances[j];
        //                performances[j] = performances[j + 1];
        //                performances[j + 1] = tempPerformance;
        //            }
        //        }
        //    }
        //}


        private string GetStageName(int stageIndex)
        {
            for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].Index == stageIndex)
                {
                    return stages[i].Name;
                }
            }
            return "Not found";
        }

        private int GetTotalPositions(int stageIndex)
        {
            for (int i = 0; i < stages.Count; i++)
            {
                if (stages[i].Index == stageIndex)
                {
                    return stages[i].GetTotalPositions();
                }
            }
            return 0;
        }

        private int GetSoldTickets(List<StandardTicket> tickets)
        {
            int counter = 0;
            foreach (StandardTicket ticket in tickets)
            {
                if (!ticket.Reserved)
                {
                    counter++;
                }
            }
            return counter;
        }

        private int GetReservedTickets(List<StandardTicket> tickets)
        {
            int counter = 0;
            foreach (StandardTicket ticket in tickets)
            {
                if (ticket.Reserved)
                {
                    counter++;
                }
            }
            return counter;
        }

        //private void SavePerformancesToFile()
        //{
        //    FileHandler.SaveListToJson(AppConstants.PerformancesFileName, performances);
        //}

        //private void LoadPerformancesFromFile()
        //{
        //    if (File.Exists(AppConstants.PerformancesFileName))
        //    {
        //        performances = FileHandler.LoadListFromJson<Performance>(AppConstants.PerformancesFileName);
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //                        $"File {AppConstants.PerformancesFileName} not found",
        //                        "Load performances error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}

        private void LoadStagesFromFile()
        {
            if (File.Exists(AppConstants.StagesFileName))
            {
                stages = FileHandler.LoadListFromJson<Stage>(AppConstants.StagesFileName);
            }
            else
            {
                MessageBox.Show(
                                $"File {AppConstants.StagesFileName} not found",
                                "Load stages error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //private void FliterPerformancesByDate()
        //{
        //    List<Performance> filteredPerformances = new List<Performance>();

        //    foreach(Performance performance in performances)
        //    {
        //        if((DateTime.Now - performance.PerformanceDateTime).Days < AppConstants.RangeDateOfPastPerformances)
        //        {
        //            filteredPerformances.Add(performance);
        //        }
        //    }

        //    performances = filteredPerformances;
        //}

        private void DisableEditAndRemoveStage()
        {
            if (dataGridViewPerformances.CurrentRow != null)
            {
                editPerformanceToolStripMenuItem.Enabled = true;
                removePerformanceToolStripMenuItem.Enabled = true;
                editPerformanceToolStripMenuItem1.Enabled = true;
                removePerformanceToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editPerformanceToolStripMenuItem.Enabled = false;
                removePerformanceToolStripMenuItem.Enabled = false;
                editPerformanceToolStripMenuItem1.Enabled = false;
                removePerformanceToolStripMenuItem1.Enabled = false;
            }
        }


        private void AddPerformance()
        {
            AddEditPerformanceForm addPerformanceForm = new AddEditPerformanceForm(stages, performanceManager.Performances);
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
            Guid id = Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].Value.ToString());

            AddEditPerformanceForm editPerformanceForm = new AddEditPerformanceForm(stages, performanceManager.Performances, performanceManager.GetById(id));
            this.Hide();
            editPerformanceForm.ShowDialog();
            this.Show();

            if (editPerformanceForm.GetIsValid())
            {
                performanceManager.UpdatePerformance(editPerformanceForm.GetPerformance());
            }
        }

        private void OpenRevenue()
        {
            ViewRevenueForm viewRevenueForm = new ViewRevenueForm(performanceManager.Performances);
            this.Hide();
            viewRevenueForm.ShowDialog();
            this.Show();
        }

        private void SwitchPerformances()
        {
            if (isPastPerformances)
            {
                UpdateDataGridPerformances();
                isPastPerformances = !isPastPerformances;
            }
            else
            {
                UpdateDataGridPastPerformances();
                isPastPerformances = !isPastPerformances;
            }
        }
    }
}
