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

        public ManageStagesForm()
        {
            InitializeComponent();

            stages = new List<Stage>();

            LoadStagesFromFile();

            UpdateDataGridStages();

            DisableEditAndRemoveStage();
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
            stages.RemoveAt(dataGridViewStages.CurrentRow.Index);

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void ManageStagesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveStagesToFile();
        }

        private void UpdateDataGridStages()
        {
            dataGridViewStages.Rows.Clear();

            foreach (Stage stage in stages)
            {
                dataGridViewStages.Rows.Add(
                    stage.Index,
                    stage.Name,
                    stage.Zones.Count
                    );
            }
        }

        private void SaveStagesToFile()
        {
            FileHandler.SaveToJson(AppConstants.StagesFileName, stages);
        }

        private void LoadStagesFromFile()
        {
            if (File.Exists(AppConstants.StagesFileName))
            {
                stages = FileHandler.LoadFromJson<Stage>(AppConstants.StagesFileName);
            }
            else
            {
                MessageBox.Show(this,
                                $"File {AppConstants.StagesFileName} not found",
                                "Load stages error",
                                MessageBoxButtons.OK);
            }
        }


        private void AddStage()
        {
            AddStageForm addStageForm = new AddStageForm(stages);
            addStageForm.ShowDialog();

            if (addStageForm.GetIsValid())
            {
                stages.Add(addStageForm.GetNewStage());
            }
        }

        private void EditStage()
        {
            EditStageForm editStageForm = new EditStageForm(stages[dataGridViewStages.CurrentRow.Index]);
            editStageForm.ShowDialog();

            if (editStageForm.GetIsValid())
            {
                stages[dataGridViewStages.CurrentRow.Index] = editStageForm.GetStage();
            }
        }

        private void DisableEditAndRemoveStage()
        {
            if (dataGridViewStages.CurrentRow != null)
            {
                editStageToolStripMenuItem.Enabled = true;
                removeStageToolStripMenuItem.Enabled = true;
            }
            else
            {
                editStageToolStripMenuItem.Enabled = false;
                removeStageToolStripMenuItem.Enabled = false;
            }
        }
    }
}
