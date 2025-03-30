using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class EditStageForm : MetroFramework.Forms.MetroForm
    {

        private bool isValid;

        private readonly Stage stage;


        public EditStageForm(Stage stage)
        {
            InitializeComponent();

            this.stage = stage;

            ShowStage();

            UpdateDataGridZones();

            DisableEditAndRemoveZone();

            isValid = false;
        }

        private void TextBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxStageName.Focus();
        }

        private void TextBoxStageName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSave.Focus();
        }

        private void DataGridViewZones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void DataGridViewZones_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void AddZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddZone();

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void EditZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditZone();

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void RemoveZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveZone();

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void ButtonEditSeating_Click(object sender, EventArgs e)
        {
            EditSeating();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveStage();
        }

        private void ShowStage()
        {
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
                zone.GetColor().Name,
                zone.StartPosition, 
                zone.EndPosition);

            dataGridViewZones.Rows[dataGridViewZones.Rows.Count - 1].Cells[3].Style.BackColor = zone.GetColor();
        }

        private void AddZone()
        {
            AddEditZoneForm addZoneForm = new AddEditZoneForm(stage);
            this.Hide();
            addZoneForm.ShowDialog();
            this.Show();

            if (addZoneForm.GetIsValid())
            {
                stage.AddZone(addZoneForm.GetZone());
            }
        }
        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewZones.CurrentRow.Cells[0].Value.ToString());
        }
        private void RemoveZone()
        {
            Guid zoneId = GetCurrentRowId();

            stage.RemoveZone(zoneId);
        }

        private void EditZone()
        {
            Guid zoneId = GetCurrentRowId();

            AddEditZoneForm editZoneForm = new AddEditZoneForm(stage, stage.GetZoneById(zoneId));
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

        private void CreateStage()
        {
            stage.Name = textBoxStageName.Text;
        }

        private void SaveStage()
        {
            CreateStage();
            StageValidator validator = new StageValidator();
            if (validator.Validate(stage, out string errorMessage))
            {
                isValid = true;
                this.Close();
            }
            else MessageBox.Show(
                                errorMessage,
                                "Stage error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
