using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TheaterHub
{
    public partial class ManagePerformancesForm : MetroFramework.Forms.MetroForm
    {
        private string performanceFileName = "performances.json";
        private string stageFileName = "stages.json";

        private List<Stage> stages;

        private List<Performance> performances;

        public ManagePerformancesForm()
        {
            InitializeComponent();
            stages = new List<Stage>();
            performances = new List<Performance>();

            LoadPerformancesFromFile();
            LoadStagesFromFile();

            UpdateDataGridPerformances();

            DisableEditAndRemoveStage();
        }
      
        private void UpdateDataGridPerformances()
        {
            dataGridViewPerformances.Rows.Clear();

            foreach (Performance performance in performances)
            {
                string timePerformance = $"{performance.PerformanceDateTime.Hour:D2}:{performance.PerformanceDateTime.Minute:D2}";
                dataGridViewPerformances.Rows.Add(
                    performance.PerformanceDateTime.Date.ToShortDateString(),
                    timePerformance,
                    performance.Name,
                    performance.Price,
                    GetStageName(performance.StageIndex),
                    GetTotalPositions(performance.StageIndex),
                    GetSoldTickets(performance.Tickets),
                    GetReservedTickets(performance.Tickets)
                    );
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

        private int GetSoldTickets(List<Ticket> tickets)
        {
            int counter = 0;
            foreach (Ticket ticket in tickets)
            {
                if (!ticket.Reserved)
                {
                    counter ++;
                }
            }
            return counter;
        }

        private int GetReservedTickets(List<Ticket> tickets)
        {
            int counter = 0;
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Reserved)
                {
                    counter ++;
                }
            }
            return counter;
        }

        private void SavePerformancesToFile()
        {
            FileHandler.SavePerformancesToJson(performanceFileName, performances);
        }

        private void LoadPerformancesFromFile()
        {
            if (File.Exists(performanceFileName))
            {
                performances = FileHandler.LoadPerformancesFromJson(performanceFileName);
            }
            else
            {
                MessageBox.Show(this,
                                $"File {performanceFileName} not found",
                                "Load performances error",
                                MessageBoxButtons.OK);
            }
        }

        private void LoadStagesFromFile()
        {
            if (File.Exists(stageFileName))
            {
                stages = FileHandler.LoadStagesFromJson(stageFileName);
            }
            else
            {
                MessageBox.Show(this,
                                $"File {stageFileName} not found",
                                "Load stages error",
                                MessageBoxButtons.OK);
            }
        }


        private void DisableEditAndRemoveStage()
        {
            if (dataGridViewPerformances.CurrentRow != null)
            {
                editSpecToolStripMenuItem.Enabled = true;
                removeSpecToolStripMenuItem.Enabled = true;
            }
            else
            {
                editSpecToolStripMenuItem.Enabled = false;
                removeSpecToolStripMenuItem.Enabled = false;
            }
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
            AddPerformanceForm addPerformanceForm = new AddPerformanceForm(stages, performances);
            addPerformanceForm.BackgroundImage = Properties.Resources.formBackground;
            addPerformanceForm.ShowDialog();

            if (addPerformanceForm.GetIsValid())
            {
                performances.Add(addPerformanceForm.GetNewPerformance());
            }

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void editSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPerformanceForm editPerformanceForm = new EditPerformanceForm(stages, performances[dataGridViewPerformances.CurrentRow.Index]);
            editPerformanceForm.ShowDialog(this);

            if (editPerformanceForm.GetIsValid())
            {
                performances[dataGridViewPerformances.CurrentRow.Index] = editPerformanceForm.GetNewPerformance();
            }

            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void removeSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performances.RemoveAt(dataGridViewPerformances.CurrentRow.Index);
            UpdateDataGridPerformances();
            DisableEditAndRemoveStage();
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRevenueForm viewRevenueForm = new ViewRevenueForm(performances);
            viewRevenueForm.ShowDialog(this);
        }
    }
}
