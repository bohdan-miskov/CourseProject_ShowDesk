using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        private List<Stage> stages;

        private List<Performance> performances;

        private int countOfPastPerformances;

        private bool isPastPerformances = false;

        public ManagePerformancesForm()
        {
            InitializeComponent();
            stages = new List<Stage>();
            performances = new List<Performance>();

            LoadPerformancesFromFile();
            LoadStagesFromFile();

            FliterPerformancesByDate();

            UpdateDataGridPerformances();

            DisableEditAndRemoveStage();
        }

        private void dataGridViewPerformances_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void dataGridViewPerformances_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void ManagePerformancesFormClosing(object sender, FormClosingEventArgs e)
        {
            SavePerformancesToFile();
        }

        private void addSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerformance();

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void editSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerformance();

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void removeSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewPerformances.CurrentRow.Index + countOfPastPerformances;

            performances.RemoveAt(index);

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenRevenue();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
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

        private void UpdateDataGridPerformances()
        {
            dataGridViewPerformances.Rows.Clear();
            performanceToolStripMenuItem.Enabled = true;
            countOfPastPerformances = 0;

            SortPerformancesByDate();

            foreach (Performance performance in performances)
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

            foreach (Performance performance in performances)
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

        private void SortPerformancesByDate()
        {
            for(int i=0; i<performances.Count-1; i++)
            {
                for(int j=0; j<performances.Count-i-1;  j++)
                {
                    if (performances[j].PerformanceDateTime > performances[j+1].PerformanceDateTime)
                    {
                        Performance tempPerformance=performances[j];
                        performances[j] = performances[j + 1];
                        performances[j + 1] = tempPerformance;
                    }
                }
            }
        }


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

        private void SavePerformancesToFile()
        {
            FileHandler.SaveListToJson(AppConstants.PerformancesFileName, performances);
        }

        private void LoadPerformancesFromFile()
        {
            if (File.Exists(AppConstants.PerformancesFileName))
            {
                performances = FileHandler.LoadListFromJson<Performance>(AppConstants.PerformancesFileName);
            }
            else
            {
                MessageBox.Show(
                                $"File {AppConstants.PerformancesFileName} not found",
                                "Load performances error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

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

        private void FliterPerformancesByDate()
        {
            List<Performance> filteredPerformances = new List<Performance>();

            foreach(Performance performance in performances)
            {
                if((DateTime.Now - performance.PerformanceDateTime).Days < AppConstants.RangeDateOfPastPerformances)
                {
                    filteredPerformances.Add(performance);
                }
            }

            performances = filteredPerformances;
        }

        private void DisableEditAndRemoveStage()
        {
            if (dataGridViewPerformances.CurrentRow != null)
            {
                editPerformanceToolStripMenuItem.Enabled = true;
                removePerformanceToolStripMenuItem.Enabled = true;
            }
            else
            {
                editPerformanceToolStripMenuItem.Enabled = false;
                removePerformanceToolStripMenuItem.Enabled = false;
            }
        }


        private void AddPerformance()
        {
            AddPerformanceForm addPerformanceForm = new AddPerformanceForm(stages, performances);
            addPerformanceForm.ShowDialog();

            if (addPerformanceForm.GetIsValid())
            {
                performances.Add(addPerformanceForm.GetNewPerformance());
            }
        }

        private void EditPerformance()
        {
            int index = dataGridViewPerformances.CurrentRow.Index + countOfPastPerformances;

            EditPerformanceForm editPerformanceForm = new EditPerformanceForm(stages, performances, index);
            editPerformanceForm.ShowDialog();

            if (editPerformanceForm.GetIsValid())
            {
                performances[index] = editPerformanceForm.GetNewPerformance();
            }
        }

        private void OpenRevenue()
        {
            ViewRevenueForm viewRevenueForm = new ViewRevenueForm(performances);
            viewRevenueForm.ShowDialog();
        }
    }
}
