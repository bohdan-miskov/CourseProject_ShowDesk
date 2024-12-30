using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace CourseProject_TheaterHub
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

        private void ShowStage()
        {
            textBoxIndex.Text = Convert.ToString(stage.Index);
            textBoxName.Text = stage.Name;
        }

        private void UpdateDataGridZones()
        {
            dataGridViewZones.Rows.Clear();

            foreach (Zone seсtor in stage.Zones)
            {
                dataGridViewZones.Rows.Add(seсtor.Name, seсtor.Increase, seсtor.StartPosition, seсtor.EndPosition);
            }
        }

        private void textBoxIndex_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxName.Focus();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSave.Focus();
            }
        }

        private void addZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditZoneForm addZoneForm = new AddEditZoneForm(stage, null);
            addZoneForm.ShowDialog(this);

            if (addZoneForm.GetIsValid())
            {
                stage = addZoneForm.GetStage();
            }

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void editZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditZoneForm editZoneForm = new AddEditZoneForm(stage, dataGridViewZones.CurrentRow.Index);
            editZoneForm.ShowDialog(this);

            if (editZoneForm.GetIsValid())
            {
                stage = editZoneForm.GetStage();
            }

            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void removeZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stage.removeZone(dataGridViewZones.CurrentRow.Index);
            UpdateDataGridZones();
            DisableEditAndRemoveZone();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ParametersValidator.NameValidator(textBoxName.Text))
            {
                MessageBox.Show(this,
                                "There was an error in the name of the stage: the name must be more than two characters long",
                                "Name stage error",
                                MessageBoxButtons.OK);
                textBoxName.Focus();
                return;
            }

            isValid = true;
            stage.Name = textBoxName.Text;

            this.Close();
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

        private void dataGridViewZones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
        }

        private void dataGridViewZones_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveZone();
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
