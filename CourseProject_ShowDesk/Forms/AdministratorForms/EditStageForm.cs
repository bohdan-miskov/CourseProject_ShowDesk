using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class EditStageForm : MetroFramework.Forms.MetroForm
    {
        private bool logOut;
        private bool isValid;

        private readonly Stage stage;
        private readonly Employee userAccount;
        private readonly StageValidator validator;


        public EditStageForm(Employee userAccount, Stage stage, List<Stage> stages, List<Performance> performances)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.stage = stage;
            this.userAccount = userAccount;
            labelAccountName.Text = userAccount.FullName;
            validator = new StageValidator(stages, performances);

            PopulateStage();

            UpdateDataGridZones();

            DisableEditAndRemoveZone();

            isValid = false;
            logOut = false;
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
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void PopulateStage()
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
            AddEditZoneForm addZoneForm = new AddEditZoneForm(userAccount, stage);
            this.Hide();
            addZoneForm.ShowDialog();

            if (addZoneForm.GetLogOut())
            {
                LogOut();
                return;
            }

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

            AddEditZoneForm editZoneForm = new AddEditZoneForm(userAccount, stage, stage.GetZoneById(zoneId));
            this.Hide();
            editZoneForm.ShowDialog();

            if (editZoneForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (editZoneForm.GetIsValid())
            {
                stage.UpdateZone(editZoneForm.GetZone());
            }
        }

        private void EditSeating()
        {
            AddEditSeatingForm editSeatingForm = new AddEditSeatingForm(userAccount, stage);
            this.Hide();
            editSeatingForm.ShowDialog();

            if (editSeatingForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (editSeatingForm.GetIsValid())
            {
                stage.SeatList = editSeatingForm.GetSeatList();
                stage.DecorList = editSeatingForm.GetDecorList();
                stage.StageLocation = editSeatingForm.GetCanvasLocation();
                stage.StageSize = editSeatingForm.GetCanvasSize();
            }
        }

        private void CreateStage()
        {
            stage.Name = textBoxStageName.Text;
        }

        private void SaveStage()
        {
            CreateStage();
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
        private void LogOut()
        {
            logOut = true;
            this.Close();
        }

        public bool GetLogOut()
        {
            return logOut;
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
