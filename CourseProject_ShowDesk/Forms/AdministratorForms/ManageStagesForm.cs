using CourseProject_ShowDesk.Scripts;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class ManageStagesForm : MetroFramework.Forms.MetroForm
    {
        //private List<Stage> stages;
        private StageManager stageManager;

        public ManageStagesForm(string accountName)
        {
            InitializeComponent();

            stageManager = new StageManager();

            //stages = new List<Stage>();

            labelAccountName.Text = accountName;

            //LoadStagesFromFile();

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
            Guid stageId = Guid.Parse(dataGridViewStages.CurrentRow.Cells[0].Value.ToString());

            stageManager.RemoveStage(stageId);

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageStagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveStagesToFile();
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

            foreach (Stage stage in stageManager.Stages)
            {
                AddStageToDataGrid(stage);
            }
        }

        private void AddStageToDataGrid(Stage stage)
        {
            dataGridViewStages.Rows.Add(
                stage.Id,
                stage.Index,
                stage.Name,
                stage.Zones.Count
                    );
        }

        //private void SaveStagesToFile()
        //{
        //    FileHandler.SaveListToJson(AppConstants.StagesFileName, stages);
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


        private void AddStage()
        {
            AddStageForm addStageForm = new AddStageForm(stageManager.CreateIndex());
            this.Hide();
            addStageForm.ShowDialog();
            this.Show();

            if (addStageForm.GetIsValid())
            {
                stageManager.AddStage(addStageForm.GetNewStage());
            }
        }

        private void EditStage()
        {
            Guid stageId = Guid.Parse(dataGridViewStages.CurrentRow.Cells[0].Value.ToString());

            EditStageForm editStageForm = new EditStageForm(stageManager.GetById(stageId));
            this.Hide();
            editStageForm.ShowDialog();
            this.Show();

            if (editStageForm.GetIsValid())
            {
                stageManager.UpdateStage(editStageForm.GetStage());
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
