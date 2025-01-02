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
    public partial class ManageStagesForm : MetroFramework.Forms.MetroForm
    {
        private string stageFileName = "stages.json";

        private List<Stage> stages;

        public ManageStagesForm()
        {
            InitializeComponent();

            stages = new List<Stage>();

            LoadStagesFromFile();

            UpdateDataGridStages();

            DisableEditAndRemoveStage();
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
            FileHandler.SaveStagesToJson(stageFileName, stages);
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

        private void addStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStageForm addStageForm = new AddStageForm(stages);
            addStageForm.ShowDialog(this);

            if (addStageForm.GetIsValid())
            {
                stages.Add(addStageForm.GetNewStage());
            }

            UpdateDataGridStages();
            DisableEditAndRemoveStage();
        }

        private void editStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStageForm editStageForm = new EditStageForm(stages[dataGridViewStages.CurrentRow.Index]);
            editStageForm.ShowDialog(this);

            if (editStageForm.GetIsValid())
            {
                stages[dataGridViewStages.CurrentRow.Index] = editStageForm.GetStage();
            }

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
            Owner.Show();
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

        private void dataGridViewStages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }

        private void dataGridViewStages_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveStage();
        }
    }
}
