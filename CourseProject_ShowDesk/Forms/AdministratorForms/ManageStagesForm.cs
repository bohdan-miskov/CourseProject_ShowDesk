using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class ManageStagesForm : MetroFramework.Forms.MetroForm
    {
        private List<Stage> stages;

        public ManageStagesForm(string accountName)
        {
            InitializeComponent();

            stages = new List<Stage>();

            labelAccountName.Text = accountName;

            LoadStagesFromFile();

            UpdateDataGridStages();

            DisableEditAndRemoveStage();

            ShowGreetings(accountName);
        }

        private void dataGridViewStages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void dataGridViewStages_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void addStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStage();

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void editStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStage();

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void removeStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewStages.CurrentRow.Index;

            stages.RemoveAt(index);

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageStagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveStagesToFile();
        }

        private void ManageStagesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

            foreach (Stage stage in stages)
            {
                AddStageToDataGrid(stage);
            }
        }

        private void AddStageToDataGrid(Stage stage)
        {
            dataGridViewStages.Rows.Add(
                    stage.Index,
                    stage.Name,
                    stage.Zones.Count
                    );
        }

        private void SaveStagesToFile()
        {
            FileHandler.SaveListToJson(AppConstants.StagesFileName, stages);
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


        private void AddStage()
        {
            AddStageForm addStageForm = new AddStageForm(stages);
            this.Hide();
            addStageForm.ShowDialog();
            this.Show();

            if (addStageForm.GetIsValid())
            {
                stages.Add(addStageForm.GetNewStage());
            }
        }

        private void EditStage()
        {
            int index = dataGridViewStages.CurrentRow.Index;

            EditStageForm editStageForm = new EditStageForm(stages[index]);
            this.Hide();
            editStageForm.ShowDialog();
            this.Show();

            if (editStageForm.GetIsValid())
            {
                stages[index] = editStageForm.GetStage();
            }
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
    }
}
