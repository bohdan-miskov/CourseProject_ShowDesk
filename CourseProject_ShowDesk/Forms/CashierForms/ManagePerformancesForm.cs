using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.CashierForms
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        //private List<Stage> stages;

        private readonly PerformanceManager performanceManager;
        private readonly StageManager stageManager;

       // private int countOfPastPerformances;

        private bool isPastPerformances = false;

        public ManagePerformancesForm(string accountName)
        {
            InitializeComponent();
            //stages = new List<Stage>();
            performanceManager = new PerformanceManager(new PerformanceBaseService());
            stageManager = new StageManager(new StageBaseService());

            labelAccountName.Text = accountName;

            //LoadPerformancesFromFile();
            //LoadStagesFromFile();

            //FliterPerformancesByDate();

            UpdateDataGridPerformances();

            DisableEditAndRemovePerformance();

            ShowGreetings(accountName);

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
            //UpdateDataGridPerformances();
            //DisableEditAndRemoveStage();
        }

        private void EditPerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerformance();
            UpdateDataFromDataBase();
            //UpdateDataGridPerformances();
            //DisableEditAndRemoveStage();
        }

        private void RemovePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].Value.ToString());

            performanceManager.RemovePerformance(id);
            UpdateDataFromDataBase();
            //UpdateDataGridPerformances();
            //DisableEditAndRemoveStage();
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
            new AuthenticateForm().Show();

            this.Close();
        }

        private void ManagePerformancesFormClosing(object sender, FormClosingEventArgs e)
        {
            //SavePerformancesToFile();
            timerUpdate.Stop();
        }

        private void ManagePerformancesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
            }
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
            //performanceToolStripMenuItem.Enabled = true;
            //ticketsToolStripMenuItem.Enabled = true;
            //countOfPastPerformances = 0;

            //SortPerformancesByDate();

            foreach (Performance performance in performances)
            {
                    AddPerformanceToDataGrid(performance);
                //if (performance.PerformanceDateTime > DateTime.Now)
                //{
                //}
                //else
                //{
                //    countOfPastPerformances++;
                //}
            }
        }
        private void UpdateDataGridPerformances()
        {
            dataGridViewPerformances.Rows.Clear();
            //performanceToolStripMenuItem.Enabled = true;
            //ticketsToolStripMenuItem.Enabled = true;
            //countOfPastPerformances = 0;

            //SortPerformancesByDate();

            foreach (Performance performance in performanceManager.Performances)
            {
                AddPerformanceToDataGrid(performance);
                //if (performance.PerformanceDateTime > DateTime.Now)
                //{
                //}
                //else
                //{
                //    countOfPastPerformances++;
                //}
            }
        }
        //private void UpdateDataGridPastPerformances()
        //{
        //    dataGridViewPerformances.Rows.Clear();
            

        //    foreach (Performance performance in performanceManager.PastPerformances)
        //    {
               
        //            AddPerformanceToDataGrid(performance);
                
        //    }
        //}

        private void AddPerformanceToDataGrid(Performance performance)
        {
            string timePerformance = $"{performance.PerformanceDateTime.Hour:D2}:{performance.PerformanceDateTime.Minute:D2}";
            dataGridViewPerformances.Rows.Add(
                performance.Id,
                performance.PerformanceDateTime.Date.ToShortDateString(),
                timePerformance,
                performance.Name,
                performance.Price.ToString()+AppConstants.CurrencySymbol.ToString(),
                performance.Duration.ToString(),
                GetStageName(performance.StageId),
                GetTotalPositions(performance.StageId),
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


        private string GetStageName(Guid stageId)
        {
            for (int i = 0; i < stageManager.Stages.Count; i++)
            {
                if (stageManager.Stages[i].Id == stageId)
                {
                    return stageManager.Stages[i].Name;
                }
            }
            return "Not found";
        }

        private int GetTotalPositions(Guid stageId)
        {
            for (int i = 0; i < stageManager.Stages.Count; i++)
            {
                if (stageManager.Stages[i].Id == stageId)
                {
                    return stageManager.Stages[i].GetTotalPositions();
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

        //private void LoadStagesFromFile()
        //{
        //    if (File.Exists(AppConstants.StagesFileName))
        //    {
        //        stages = FileHandler.LoadListFromJson<Stage>(AppConstants.StagesFileName);
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //                        $"File {AppConstants.StagesFileName} not found",
        //                        "Load stages error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}

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


        private void AddPerformance()
        {
            AddEditPerformanceForm addPerformanceForm = new AddEditPerformanceForm(stageManager.Stages, performanceManager.Performances);
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

            AddEditPerformanceForm editPerformanceForm = new AddEditPerformanceForm(stageManager.Stages, performanceManager.Performances, performanceManager.GetById(id));
            this.Hide();
            editPerformanceForm.ShowDialog();
            this.Show();

            if (editPerformanceForm.GetIsValid())
            {
                performanceManager.UpdatePerformance(editPerformanceForm.GetPerformance());
            }
        }
        private void ViewTickets()
        {
            Guid id = Guid.Parse(dataGridViewPerformances.CurrentRow.Cells[0].Value.ToString());
            Performance currentPerformance=performanceManager.GetById(id);
            Stage currentStage = stageManager.GetById(currentPerformance.StageId);
            ManageTicketsForm manageTicketsForm = new ManageTicketsForm(currentStage, currentPerformance);

            this.Hide();
            manageTicketsForm.ShowDialog();
            this.Show();
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
                UpdateDataGridPerformances(performanceManager.PastPerformances);
                isPastPerformances = !isPastPerformances;
            }
        }
    }
}
