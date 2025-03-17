using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
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
            Guid zoneId = Guid.Parse(dataGridViewZones.CurrentRow.Cells[0].Value.ToString());

            stage.RemoveZone(zoneId);

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void buttonEditSeating_Click(object sender, EventArgs e)
        {
            EditSeating();
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

        private void EditStageForm_FormClosed(object sender, FormClosedEventArgs e)
        {

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
                zone.Id,
                zone.Name, 
                zone.Increase, 
                zone.StartPosition, 
                zone.EndPosition);
        }

        private void AddZone()
        {
            AddEditZoneForm addZoneForm = new AddEditZoneForm(stage, null);
            this.Hide();
            addZoneForm.ShowDialog();
            this.Show();

            if (addZoneForm.GetIsValid())
            {
                stage.AddZone(addZoneForm.GetZone());
            }
        }

        private void EditZone()
        {
            Guid zoneId = Guid.Parse(dataGridViewZones.CurrentRow.Cells[0].Value.ToString());
            
            AddEditZoneForm editZoneForm = new AddEditZoneForm(stage, stage.GetZone(zoneId));
            this.Hide();
            editZoneForm.ShowDialog();
            this.Show();

            if (editZoneForm.GetIsValid())
            {
                stage.UpdateZone(editZoneForm.GetZone());
            }
        }
        
        private void EditSeating()
        {
            AddEditSeatingForm addSeatingForm = new AddEditSeatingForm(stage);
            this.Hide();
            addSeatingForm.ShowDialog();
            this.Show();

            if (addSeatingForm.GetIsValid())
            {
                stage.SeatList = addSeatingForm.GetSeatList();
                stage.DecorList = addSeatingForm.GetDecorList();
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
                editZoneToolStripMenuItem1.Enabled = true;
                removeZoneToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editZoneToolStripMenuItem.Enabled = false;
                removeZoneToolStripMenuItem.Enabled = false;
                editZoneToolStripMenuItem1.Enabled = false;
                removeZoneToolStripMenuItem1.Enabled = false;
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
