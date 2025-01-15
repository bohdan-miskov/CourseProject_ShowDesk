using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        private AppConstantsData appConstantsData;

        private readonly string typeOfFile = ".json";

        public SettingsForm()
        {
            InitializeComponent();

            appConstantsData = AppConstants.CloneConstants();

            PopulateAllField();
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
                textBoxCurrencySymbol.Focus();
            }
        }

        private void textBoxCurrencySymbol_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSaveChanges.Focus();
            }
        }

        private void textBoxItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLetter(sender, e);
        }

        private void textBoxEmployeesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }

        private void textBoxStagesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }

        private void textBoxPerformancesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }

        private void textBoxCurrencySymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorSymbol(sender, e);
        }

        private void comboBoxListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListBoxName();
            listBoxViewNames.SelectedIndex = 0;
            PopulateTextBoxName();
        }

        private void listBoxViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTextBoxName();
        }

        private void buttonSaveName_Click(object sender, EventArgs e)
        {
            if (ValidateNamesGroup())
            {
                SaveItem();

                PopulateListBoxName();
                listBoxViewNames.SelectedIndex = 0;

                PopulateTextBoxName();
            }
        }

        private void buttonCancelName_Click(object sender, EventArgs e)
        {
            PopulateTextBoxName();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateSettings())
            {
                SaveAllField();

                AppCostantsManager.SaveAppConstantsToFile(appConstantsData);

                Close();
            }
        }

        private void buttonCancelChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PopulateAllField()
        {
            PopulateFileNameGroup();
            PopulateIncreaseGroup();
            PopuLateDurationGroup();
            PopulateNamesGroup();
            PopulateOtherGroup();
        }

        private void PopulateFileNameGroup()
        {
            textBoxEmployeesFileName.Text = appConstantsData.EmployeesFileName.Split('.')[0];
            textBoxStagesFileName.Text = appConstantsData.StagesFileName.Split('.')[0];
            textBoxPerformancesFileName.Text = appConstantsData.PerformancesFileName.Split('.')[0];
        }

        private void PopulateIncreaseGroup()
        {
            numericUpDownStandardIncrease.Value =Convert.ToDecimal(appConstantsData.StandardIncrease);
            numericUpDownStandardPlusIncrease.Value = Convert.ToDecimal(appConstantsData.StandardPlusIncrease);
            numericUpDownPremiumIncrease.Value = Convert.ToDecimal(appConstantsData.PremiumIncrease);
        }

        private void PopuLateDurationGroup()
        {
            dateTimePickerMinBreak.Value = DateTime.Today + appConstantsData.MinBreakBetweenPerformance;
            dateTimePickerInitialDuration.Value = DateTime.Today + appConstantsData.InitialPerformanceDuration;
            dateTimePickerMaxDuration.Value = DateTime.Today + appConstantsData.MaxDuration;
        }

        private void PopulateNamesGroup()
        {
            PopulateComboBoxName();
            comboBoxListName.SelectedIndex = 0;
            
            PopulateListBoxName();
            listBoxViewNames.SelectedIndex = 0;

            PopulateTextBoxName();
        }


        private void PopulateOtherGroup()
        {
            numericUpDownRangeDateOfPastPerformances.Value = Convert.ToDecimal(appConstantsData.RangeDateOfPastPerformances);
            textBoxCurrencySymbol.Text = appConstantsData.CurrencySymbol.ToString();
        }

        private void PopulateComboBoxName()
        {
            comboBoxListName.Items.Clear();
            comboBoxListName.Items.Add("List of professions");
            comboBoxListName.Items.Add("List of ticket types");
            comboBoxListName.Items.Add("List of souvenirs");
            comboBoxListName.Items.Add("List of drinks");
        }

        private List<string> FindListByIndex(int index)
        {
            if (index == 0) return appConstantsData.ListOfProfessions;
            if (index == 1) return appConstantsData.ListOfTicketTypes;
            if (index == 2) return appConstantsData.ListOfSouvenirs;
            if (index == 3) return appConstantsData.ListOfDrinks;

            return null;
        }

        private void PopulateListBoxName()
        {
            listBoxViewNames.Items.Clear();
            int indexList = comboBoxListName.SelectedIndex;

            List<string> currentList = FindListByIndex(indexList);

            foreach (string item in currentList)
            {
                listBoxViewNames.Items.Add(item);
            }
        }


        private void PopulateTextBoxName()
        {
            textBoxItemName.Text = listBoxViewNames.SelectedItem.ToString();
        }

        private void SaveItem()
        {
            int indexList = comboBoxListName.SelectedIndex;
            int indexItem = listBoxViewNames.SelectedIndex;

            string newName = textBoxItemName.Text;

            if (indexList == 0)
            {
                appConstantsData.ListOfProfessions[indexItem] = newName;
            }
            if (indexList == 1)
            {
                appConstantsData.ListOfTicketTypes[indexItem] = newName;
            }
            if (indexList == 2)
            {
                appConstantsData.ListOfSouvenirs[indexItem] = newName;
            }
            if (indexList == 3)
            {
                appConstantsData.ListOfDrinks[indexItem] = newName;
            }
        }

        private bool ValidateSettings()
        {
            if (!ValidateFileNameGroup()) return false;
            if (!ValidateIncreaseGroup()) return false;
            if (!ValidateDurationGroup()) return false;
            if (!ValidateOtherGroup()) return false;

            return true;
        }

        private bool ValidateFileNameGroup()
        {
            if (!ParametersValidator.FileNameValidator(textBoxEmployeesFileName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxStagesFileName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxPerformancesFileName.Text))
            {
                MessageBox.Show(
                    "There was an error in the name of the file: the file name must be more than four characters long",
                    "File Name Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxFileName.Focus();

                return false;
            }
            return true;
        }

        private bool ValidateIncreaseGroup()
        {
            if (numericUpDownStandardIncrease.Value < 1 ||
                numericUpDownStandardPlusIncrease.Value < 1 ||
                numericUpDownPremiumIncrease.Value < 1)
            {
                MessageBox.Show(
                    "Increases cannot be less than zero.",
                    "Increase Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxTicketIncrease.Focus();

                return false;
            }
            return true;
        }

        private bool ValidateDurationGroup()
        {
            TimeSpan minBreak = new TimeSpan(dateTimePickerMinBreak.Value.Hour, dateTimePickerMinBreak.Value.Minute, 0);
            TimeSpan initialDuration = new TimeSpan(dateTimePickerInitialDuration.Value.Hour, dateTimePickerInitialDuration.Value.Minute, 0);
            TimeSpan maxDuration = new TimeSpan(dateTimePickerMaxDuration.Value.Hour, dateTimePickerMaxDuration.Value.Minute, 0);

            if (minBreak <= TimeSpan.Zero || initialDuration <= TimeSpan.Zero || maxDuration <= TimeSpan.Zero)
            {
                MessageBox.Show(
                    "Durations must be greater than zero.",
                    "Duration Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxPerformanceDuration.Focus();

                return false;
            }

            if (initialDuration > maxDuration)
            {
                MessageBox.Show(
                    "Initial duration cannot exceed maximum duration.",
                    "Duration Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                dateTimePickerInitialDuration.Focus();

                return false;
            }

            return true;
        }

        private bool ValidateOtherGroup()
        {
            if (numericUpDownRangeDateOfPastPerformances.Value < 0)
            {
                MessageBox.Show(
                    "Range date of past performances must be non-negative.",
                    "Other Group Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                numericUpDownRangeDateOfPastPerformances.Focus();

                return false;
            }

            if (textBoxCurrencySymbol.Text.Length == 0)
            {
                MessageBox.Show(
                    "Currency symbol must have 1 symbol",
                    "Other Group Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxCurrencySymbol.Focus();

                return false;
            }

            return true;
        }

        private bool ValidateNamesGroup()
        {
            if(!ParametersValidator.NameValidator(textBoxItemName.Text))
            {
                MessageBox.Show(
                    "There was an error in the name: the name must be more than two characters long",
                    "Name Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxItemName.Focus();
                return false;
            }

            return true;
        }
        private void SaveAllField()
        {
            SaveFileNameGroup();
            SaveIncreaseGroup();
            SaveDurationGroup();
            SaveOtherGroup();
        }

        private void SaveFileNameGroup()
        {
            appConstantsData.EmployeesFileName = textBoxEmployeesFileName.Text+typeOfFile;
            appConstantsData.StagesFileName = textBoxStagesFileName.Text+typeOfFile;
            appConstantsData.PerformancesFileName = textBoxPerformancesFileName.Text + typeOfFile;
        }

        private void SaveIncreaseGroup()
        {
            appConstantsData.StandardIncrease = Convert.ToDouble(numericUpDownStandardIncrease.Value);
            appConstantsData.StandardPlusIncrease = Convert.ToDouble(numericUpDownStandardPlusIncrease.Value);
            appConstantsData.PremiumIncrease = Convert.ToDouble(numericUpDownPremiumIncrease.Value);
        }

        private void SaveDurationGroup()
        {
            appConstantsData.MinBreakBetweenPerformance = new TimeSpan(dateTimePickerMinBreak.Value.Hour, dateTimePickerMinBreak.Value.Minute, 0);
            appConstantsData.InitialPerformanceDuration = new TimeSpan(dateTimePickerInitialDuration.Value.Hour, dateTimePickerInitialDuration.Value.Minute, 0);
            appConstantsData.MaxDuration = new TimeSpan(dateTimePickerMaxDuration.Value.Hour, dateTimePickerMaxDuration.Value.Minute, 0);
        }

        private void SaveOtherGroup()
        {
            appConstantsData.RangeDateOfPastPerformances = Convert.ToInt32(numericUpDownRangeDateOfPastPerformances.Value);
            appConstantsData.CurrencySymbol = Convert.ToChar(textBoxCurrencySymbol.Text);
        }

    }
}
