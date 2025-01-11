using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void textBoxEmployeesFileName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxStagesFileName.Focus();
            }
        }

        private void textBoxStagesFileName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPerformancesFileName.Focus();
            }
        }

        private void textBoxPerformancesFileName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownStandardIncrease.Focus();
            }
        }


        private void numericUpDownStandardIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownStandardPlusIncrease.Focus();
            }
        }

        private void numericUpDownStandardPlusIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                numericUpDownPremiumIncrease.Focus();
            }
        }

        private void numericUpDownPremiumIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerMinBreak.Focus();
            }
        }
        private void dateTimePickerMinBreak_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerInitialDuration.Focus();
            }
        }

        private void dateTimePickerInitialDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePickerMaxDuration.Focus();
            }
        }

        private void dateTimePickerMaxDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBoxListName.Focus();
            }
        }

        private void comboBoxListName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxViewNames.Focus();
            }
        }

        private void listBoxViewNames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxItemName.Focus();
            }
        }

        private void textBoxItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSaveName.Focus();
            }
        }

        private void buttonSaveName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxViewNames.Focus();
            }
        }

        private void buttonCancelName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxViewNames.Focus();
            }
        }

        private void numericUpDownRangeDateOfPastPerformances_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSaveChanges.Focus();
            }
        }

        private void comboBoxListName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveName_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {

        }

        private void PopulateListBoxName(int index)
        {
            
        }

        //private List<String> GetList(int index)
        //{
        //    if(index==0) return AppConstants
        //}

    }
}
