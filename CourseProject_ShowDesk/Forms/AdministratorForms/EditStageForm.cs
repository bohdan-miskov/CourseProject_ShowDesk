using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class EditStageForm : MetroFramework.Forms.MetroForm
    {

        private bool isValid;

        private Stage stage;


        public EditStageForm(Stage stage)
        {
            InitializeComponent();

            this.stage = stage;

            ShowStage();

            UpdateDataGridZones();

            DisableEditAndRemoveZone();

            isValid = false;
        }

        private void textBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxStageName.Focus();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.Focus();
            }
        }

        private void dataGridViewZones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void dataGridViewZones_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void addZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddZone();

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void editZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditZone();

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void removeZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewZones.CurrentRow.Index;

            stage.RemoveZone(index);

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateOfStage())
            {
                isValid = true;

                SaveStage();

                this.Close();
            }
        }

        private void ShowStage()
        {
            textBoxIndex.Text = Convert.ToString(stage.Index);
            textBoxStageName.Text = stage.Name;
        }

        private void UpdateDataGridZones()
        {
            dataGridViewZones.Rows.Clear();

            foreach (Zone zone in stage.Zones)
            {
                AddZoneToDateGrid(zone);
            }
        }

        private void AddZoneToDateGrid(Zone zone)
        {
            dataGridViewZones.Rows.Add(
                zone.Name, 
                zone.Increase, 
                zone.StartPosition, 
                zone.EndPosition);
        }

        private void AddZone()
        {
            AddEditZoneForm addZoneForm = new AddEditZoneForm(stage, null);
            addZoneForm.ShowDialog();

            if (addZoneForm.GetIsValid())
            {
                stage = addZoneForm.GetStage();
            }
        }

        private void EditZone()
        {
            int index = dataGridViewZones.CurrentRow.Index;

            AddEditZoneForm editZoneForm = new AddEditZoneForm(stage, index);
            editZoneForm.ShowDialog();

            if (editZoneForm.GetIsValid())
            {
                stage = editZoneForm.GetStage();
            }
        }

        private void SaveStage()
        {
            stage.Name = textBoxStageName.Text;
        }

        private bool ValidateOfStage()
        {
            if(!ValidateOfStageName()) return false;

            return true;
        }

        private bool ValidateOfStageName()
        {
            if (!ParametersValidator.NameValidator(textBoxStageName.Text))
            {
                MessageBox.Show(
                                "There was an error in the name of the stage: the name must be more than two characters long",
                                "Name stage error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxStageName.Focus();
                return false;
            }

            return true;
        }

        private void DisableEditAndRemoveZone()
        {
            if (dataGridViewZones.CurrentRow != null)
            {
                editZoneToolStripMenuItem.Enabled = true;
                removeZoneToolStripMenuItem.Enabled = true;
            }
            else
            {
                editZoneToolStripMenuItem.Enabled = false;
                removeZoneToolStripMenuItem.Enabled = false;
            }
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public Stage GetStage()
        {
            return stage;
        }
    }
}
