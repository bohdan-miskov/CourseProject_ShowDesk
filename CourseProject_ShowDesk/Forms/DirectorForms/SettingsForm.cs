using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        private readonly AppConstantsData appConstantsData;
        TabControlController tabControlController;
        private bool logOut;

        public SettingsForm(Employee userAccount)
        {
            InitializeComponent();

            appConstantsData = AppConstants.CloneConstants();
            labelAccountName.Text = userAccount.FullName;
            tabControlController = new TabControlController(tabControlSetting);
            logOut = false;

            PopulateAllField();

            FormConfigurator.ConfigureForm(this, true);
        }
        private void DateTimePickerMinBreak_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerInitialDuration.Focus();
        }

        private void DateTimePickerInitialDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerMaxDuration.Focus();
        }

        private void DateTimePickerMaxDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownStandardIncrease.Focus();
        }
        private void NumericUpDownStandardIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownStandardPlusIncrease.Focus();
        }

        private void NumericUpDownStandardPlusIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) numericUpDownPremiumIncrease.Focus();
        }

        private void NumericUpDownPremiumIncrease_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkBoxReceiptPrint.Focus();
        }
        private void CheckBoxReceiptPrint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxReceiptSavePath.Focus();
        }

        private void TextBoxReceiptSavePath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSavePerformanceSettings.Focus();
        }

        private void TextBoxGeneralCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxEmployeesCollectionName.Focus();
        }
        private void TextBoxEmployeesCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxStagesCollectionName.Focus();
        }

        private void TextBoxStagesCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPerformancesCollectionName.Focus();
        }

        private void TextBoxPerformancesCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPastPerformancesCollectionName.Focus();
        }

        private void TextBoxPastPerformancesCollectionName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerIntervalEmployees.Focus();
        }

        private void DateTimePickerIntervalEmployees_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerIntervalStages.Focus();
        }

        private void DateTimePickerIntervalStages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerIntervalPerformances.Focus();
        }

        private void DateTimePickerIntervalPerformances_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerIntervalTickets.Focus();
        }

        private void DateTimePickerIntervalTickets_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxDataBaseLink.Focus();
        }

        private void TextBoxDataBaseLink_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSaveDatabaseSettings.Focus();
        }

        private void ComboBoxListName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listBoxViewNames.Focus();
        }

        private void ListBoxViewNames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxItemName.Focus();
        }

        private void TextBoxItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSaveName.Focus();
        }

        private void ButtonSaveName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listBoxViewNames.Focus();
        }

        private void ButtonCancelName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) listBoxViewNames.Focus();
        }

        private void TextBoxSeatColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dateTimePickerIntervalPerformances.Focus();
        }

        private void ButtonChangeSeatColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonChangeSeatHoverColor.Focus();
        }

        private void TextBoxSeatHoverColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonChangeSeatHoverColor.Focus();
        }

        private void ButtonChangeSeatHoverColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxCompanyName.Focus();
        }
        private void TextBoxCompanyName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxCurrencySymbol.Focus();
        }
        private void TextBoxCurrencySymbol_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPasswordChar.Focus();
        }

        private void TextBoxPasswordChar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonSaveOtherSettings.Focus();
        }

        private void TextBoxItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLetter(sender, e);
        }

        private void TextBoxEmployeesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }

        private void TextBoxStagesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }

        private void TextBoxPerformancesFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorFileName(sender, e);
        }
        private void TextBoxCurrencySymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorSymbol(sender, e);
        }
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            tabControlController.TabControlNavigation(e);
        }

        private void ComboBoxListName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListBoxName();
            listBoxViewNames.SelectedIndex = 0;
            PopulateTextBoxName();
            DisableAddRemoveListItem();
        }

        private void ListBoxViewNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTextBoxName();
        }

        private void ButtonSelectReceiptFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }
        private void ButtonChangeSeatColor_Click(object sender, EventArgs e)
        {
            SetSeatBaseColor();
        }
        private void ButtonChangeSeatHoverColor_Click(object sender, EventArgs e)
        {
            SetSeatHoverColor();
        }
        private void ButtonSavePerformanceSettings_Click(object sender, EventArgs e)
        {
            SavePerformanceSettings();
        }
        private void ButtonCancelPerformanceSettings_Click(object sender, EventArgs e)
        {
            PopulatePerformancePage();
        }
        private void ButtonSaveDatabaseSettings_Click(object sender, EventArgs e)
        {
            SaveDatabaseSettings();
        }
        private void ButtonCancelDatabaseSettings_Click(object sender, EventArgs e)
        {
            PopulateDatabasePage();
        }
        private void ButtonSaveOtherSettings_Click(object sender, EventArgs e)
        {
            SaveOtherSettings();
        }
        private void ButtonSaveName_Click(object sender, EventArgs e)
        {
            SaveNamesSettings();
        }

        private void ButtonCancelName_Click(object sender, EventArgs e)
        {
            PopulateTextBoxName();
        }

        private void ButtonAddName_Click(object sender, EventArgs e)
        {
            AddNamesSettings();
        }

        private void ButtonRemoveName_Click(object sender, EventArgs e)
        {
            RemoveNamesSettings();
        }
        private void ButtonCancelOtherChanges_Click(object sender, EventArgs e)
        {
            PopulateOtherPage();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void PopulateAllField()
        {
            PopulatePerformancePage();
            PopulateDatabasePage();
            PopulateOtherPage();
        }
        private void PopulatePerformancePage()
        {
            PopuLateDurationGroup();
            PopulateIncreaseGroup();
            PopulateReceiptGroup();
        }
        private void PopulateDatabasePage()
        {
            PopulateCollectionNameGroup();
            PopulateUpdateIntervalGroup();
            PopulateDatabaseLinksGroup();
        }
        private void PopulateOtherPage()
        {
            PopulateNamesGroup();
            PopulateStageGroup();
            PopulateOtherGroup();
        }
        private void PopulateIncreaseGroup()
        {
            numericUpDownStandardIncrease.Value = Convert.ToDecimal(appConstantsData.StandardIncrease);
            numericUpDownStandardPlusIncrease.Value = Convert.ToDecimal(appConstantsData.StandardPlusIncrease);
            numericUpDownPremiumIncrease.Value = Convert.ToDecimal(appConstantsData.PremiumIncrease);
        }
        private void PopuLateDurationGroup()
        {
            dateTimePickerMinBreak.Value = DateTime.Today + appConstantsData.MinBreakBetweenPerformance;
            dateTimePickerInitialDuration.Value = DateTime.Today + appConstantsData.InitialPerformanceDuration;
            dateTimePickerMaxDuration.Value = DateTime.Today + appConstantsData.MaxDuration;
        }
        private void PopulateReceiptGroup()
        {
            checkBoxReceiptPrint.Checked = appConstantsData.IsPrintReceipt;
            textBoxReceiptSavePath.Text = appConstantsData.SavePathReceipt;
        }
        private void PopulateCollectionNameGroup()
        {
            textBoxGeneralCollectionName.Text = appConstantsData.GeneralCollectionName;
            textBoxEmployeesCollectionName.Text = appConstantsData.EmployeesCollectionName;
            textBoxStagesCollectionName.Text = appConstantsData.StagesCollectionName;
            textBoxPerformancesCollectionName.Text = appConstantsData.PerformancesCollectionName;
            textBoxPastPerformancesCollectionName.Text = appConstantsData.PastPerformancesCollectionName;
        }
        private void PopulateUpdateIntervalGroup()
        {
            dateTimePickerIntervalEmployees.Value = DateTime.Today + TimeSpan.FromMilliseconds(appConstantsData.UpdateEmployeesInterval);
            dateTimePickerIntervalStages.Value = DateTime.Today + TimeSpan.FromMilliseconds(appConstantsData.UpdateStagesInterval);
            dateTimePickerIntervalPerformances.Value = DateTime.Today + TimeSpan.FromMilliseconds(appConstantsData.UpdatePerformancesInterval);
            dateTimePickerIntervalTickets.Value = DateTime.Today + TimeSpan.FromMilliseconds(appConstantsData.UpdateTicketsInterval);
        }
        private void PopulateDatabaseLinksGroup()
        {
            textBoxDataBaseLink.Text = appConstantsData.ConnectionString;
        }
        private void PopulateStageGroup()
        {
            textBoxSeatColor.Text = appConstantsData.SeatBaseColor.Name;
            buttonChangeSeatHoverColor.BackColor = appConstantsData.SeatBaseColor;
            textBoxSeatHoverColor.Text = appConstantsData.SeatHoverColor.Name;
            buttonChangeSeatHoverColor.BackColor = appConstantsData.SeatHoverColor;
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
            textBoxCompanyName.Text = appConstantsData.CompanyName;
            textBoxCurrencySymbol.Text = appConstantsData.CurrencySymbol.ToString();
            textBoxPasswordChar.Text = appConstantsData.PasswordChar.ToString();
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
        private void DisableAddRemoveListItem()
        {
            int indexList = comboBoxListName.SelectedIndex;

            if (indexList == 2 || indexList == 2)
            {
                buttonAddName.Enabled = true;
                buttonRemoveName.Enabled = true;
            }
            else
            {
                buttonAddName.Enabled = false;
                buttonRemoveName.Enabled = false;
            }
            if (listBoxViewNames.Items.Count == 0)
            {
                buttonRemoveName.Enabled = false;
                buttonSaveName.Enabled = false;
            }
            else buttonSaveName.Enabled = true;
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
                appConstantsData.ListOfProfessions[indexItem] = newName;

            else if (indexList == 1)
                appConstantsData.ListOfTicketTypes[indexItem] = newName;

            else if (indexList == 2)
                appConstantsData.ListOfSouvenirs[indexItem] = newName;

            else if (indexList == 3)
                appConstantsData.ListOfDrinks[indexItem] = newName;
        }
        private void AddItem()
        {
            int indexList = comboBoxListName.SelectedIndex;

            string newName = textBoxItemName.Text;

            if (indexList == 2)
                appConstantsData.ListOfSouvenirs.Add(newName);

            else if (indexList == 3)
                appConstantsData.ListOfDrinks.Add(newName);
        }
        private void RemoveItem()
        {
            int indexList = comboBoxListName.SelectedIndex;
            int indexItem = listBoxViewNames.SelectedIndex;

            string newName = textBoxItemName.Text;

            if (indexList == 2)
                appConstantsData.ListOfSouvenirs.RemoveAt(indexItem);

            else if (indexList == 3)
                appConstantsData.ListOfDrinks.RemoveAt(indexItem);
        }
        private void SelectFolder()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select folder for save";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxReceiptSavePath.Text = folderDialog.SelectedPath;
                }
            }
        }
        private Color SelectColor()
        {
            if (colorDialogSettings.ShowDialog() == DialogResult.OK)
            {
                return colorDialogSettings.Color;
            }
            return Color.Empty;
        }
        private void SetSeatBaseColor()
        {
            Color newColor = SelectColor();
            if (newColor != Color.Empty)
            {
                buttonChangeSeatColor.BackColor = newColor;
                textBoxSeatColor.Text = newColor.Name;
            }
        }
        private void SetSeatHoverColor()
        {
            Color newColor = SelectColor();
            if (newColor != Color.Empty)
            {
                buttonChangeSeatHoverColor.BackColor = newColor;
                textBoxSeatHoverColor.Text = newColor.Name;
            }
        }
        private bool ValidatePerformanceSettings()
        {
            if (!ValidateIncreaseGroup()) return false;
            if (!ValidateDurationGroup()) return false;
            if (!ValidateReceiptGroup()) return false;
            return true;
        }
        private bool ValidateDatabaseSettings()
        {
            if (!ValidateCollectionNameGroup()) return false;
            if (!ValidateUpdateIntervalGroup()) return false;
            if (!ValidateDatabaseLinksGroup()) return false;
            return true;
        }
        private bool ValidateOtherSettings()
        {
            if (!ValidateStageGroup()) return false;
            if (!ValidateOtherGroup()) return false;
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
        private bool ValidateReceiptGroup()
        {
            if (!Directory.Exists(textBoxReceiptSavePath.Text) && !string.IsNullOrWhiteSpace(textBoxReceiptSavePath.Text))
            {
                MessageBox.Show(
                   "This directory not found",
                   "Receipt directory Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                textBoxReceiptSavePath.Focus();

                return false;
            }
            return true;
        }
        private bool ValidateCollectionNameGroup()
        {
            if (!ParametersValidator.FileNameValidator(textBoxGeneralCollectionName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxEmployeesCollectionName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxStagesCollectionName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxPerformancesCollectionName.Text) ||
                !ParametersValidator.FileNameValidator(textBoxPastPerformancesCollectionName.Text))
            {
                MessageBox.Show(
                    "There was an error in the name of the file: the file name must be more than four characters long",
                    "File Name Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxCollectionName.Focus();

                return false;
            }
            return true;
        }
        private bool ValidateUpdateIntervalGroup()
        {
            TimeSpan updateEmployees = new TimeSpan(0, dateTimePickerIntervalEmployees.Value.Minute, dateTimePickerIntervalEmployees.Value.Second);
            TimeSpan updateStages = new TimeSpan(0, dateTimePickerIntervalStages.Value.Minute, dateTimePickerIntervalStages.Value.Second);
            TimeSpan updatePerformaces = new TimeSpan(0, dateTimePickerIntervalPerformances.Value.Minute, dateTimePickerIntervalPerformances.Value.Second);
            TimeSpan updateTickets = new TimeSpan(0, dateTimePickerIntervalTickets.Value.Minute, dateTimePickerIntervalTickets.Value.Second);


            if (updateEmployees <= TimeSpan.Zero || updateStages <= TimeSpan.Zero || updatePerformaces <= TimeSpan.Zero || updateTickets <= TimeSpan.Zero)
            {
                MessageBox.Show(
                    "Update intervals must be greater than zero.",
                    "Update intervals validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxUpdateInterval.Focus();

                return false;
            }

            return true;
        }
        private bool ValidateDatabaseLinksGroup()
        {
            string connectionString = textBoxDataBaseLink.Text;
            try
            {
                var client = new MongoClient(connectionString);
                var databases = client.ListDatabaseNames().ToList();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"MongoDB connection failed: {ex.Message}",
                    "Database link error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxDataBaseLink.Focus();
                return false;
            }
        }
        private bool ValidateStageGroup()
        {
            if (string.IsNullOrWhiteSpace(textBoxSeatColor.Text) ||
                string.IsNullOrWhiteSpace(textBoxSeatHoverColor.Text))
            {
                MessageBox.Show(
                    "Seat colors cannot be null or empty.",
                    "Seat colors Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                groupBoxStage.Focus();

                return false;
            }

            return true;
        }
        private bool ValidateOtherGroup()
        {
            if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text))
            {
                MessageBox.Show(
                    "Company name cannot be null or empty.",
                    "Company name Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxCompanyName.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxCurrencySymbol.Text))
            {
                MessageBox.Show(
                    "Currency symbol must have 1 symbol",
                    "Other Group Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxCurrencySymbol.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPasswordChar.Text))
            {
                MessageBox.Show(
                    "Password char cannot be null or empty.",
                    "Password char Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxPasswordChar.Focus();

                return false;
            }

            return true;
        }
        private bool ValidateNamesGroup()
        {
            if (!ParametersValidator.NameValidator(textBoxItemName.Text))
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
        private void SavePerformanceSettings()
        {
            if (ValidatePerformanceSettings())
            {
                SavePerformanceFields();

                AppCostantsManager.SaveAppConstantsToFile(appConstantsData);
            }
        }
        private void SaveDatabaseSettings()
        {
            if (ValidateDatabaseSettings())
            {
                SaveDatabaseFields();

                AppCostantsManager.SaveAppConstantsToFile(appConstantsData);
            }
        }
        private void SaveNamesSettings()
        {
            if (!ValidateNamesGroup()) return;

            SaveItem();

            PopulateListBoxName();
            listBoxViewNames.SelectedIndex = 0;

            PopulateTextBoxName();
        }
        private void AddNamesSettings()
        {
            if (!ValidateNamesGroup()) return;

            AddItem();

            PopulateListBoxName();
            PopulateTextBoxName();
        }
        private void RemoveNamesSettings()
        {
            RemoveItem();

            PopulateListBoxName();
            PopulateTextBoxName();
            DisableAddRemoveListItem();
        }
        private void SaveOtherSettings()
        {
            if (ValidateOtherSettings())
            {
                SaveOtherFields();

                AppCostantsManager.SaveAppConstantsToFile(appConstantsData);
            }
        }
        private void SavePerformanceFields()
        {
            SaveIncreaseGroup();
            SaveDurationGroup();
            SaveReceiptGroup();
        }
        private void SaveDatabaseFields()
        {
            SaveCollectionNamesGroup();
            SaveUpdateIntervalGroup();
            SaveDatabaseLinksGroup();
        }
        private void SaveOtherFields()
        {
            SaveStageGroup();
            SaveOtherGroup();
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
        private void SaveReceiptGroup()
        {
            appConstantsData.IsPrintReceipt = checkBoxReceiptPrint.Checked;
            appConstantsData.SavePathReceipt = textBoxReceiptSavePath.Text;
        }
        private void SaveCollectionNamesGroup()
        {
            appConstantsData.GeneralCollectionName = textBoxGeneralCollectionName.Text;
            appConstantsData.EmployeesCollectionName = textBoxEmployeesCollectionName.Text;
            appConstantsData.StagesCollectionName = textBoxStagesCollectionName.Text;
            appConstantsData.PerformancesCollectionName = textBoxPerformancesCollectionName.Text;
            appConstantsData.PastPerformancesCollectionName = textBoxPastPerformancesCollectionName.Text;
        }
        private void SaveUpdateIntervalGroup()
        {
            DateTime performanceValue = dateTimePickerIntervalPerformances.Value;
            TimeSpan performanceInterval = new TimeSpan(0, performanceValue.Minute, performanceValue.Second);
            appConstantsData.UpdatePerformancesInterval = (int)performanceInterval.TotalMilliseconds;

            DateTime employeeValue = dateTimePickerIntervalEmployees.Value;
            TimeSpan employeeInterval = new TimeSpan(0, employeeValue.Minute, employeeValue.Second);
            appConstantsData.UpdateEmployeesInterval = (int)employeeInterval.TotalMilliseconds;

            DateTime stageValue = dateTimePickerIntervalStages.Value;
            TimeSpan stageInterval = new TimeSpan(0, stageValue.Minute, stageValue.Second);
            appConstantsData.UpdateStagesInterval = (int)stageInterval.TotalMilliseconds;

            DateTime ticketValue = dateTimePickerIntervalTickets.Value;
            TimeSpan ticketInterval = new TimeSpan(0, ticketValue.Minute, ticketValue.Second);
            appConstantsData.UpdateTicketsInterval = (int)ticketInterval.TotalMilliseconds;
        }
        private void SaveDatabaseLinksGroup()
        {
            appConstantsData.ConnectionString = textBoxDataBaseLink.Text;
        }
        private void SaveStageGroup()
        {
            appConstantsData.SeatBaseColor = Color.FromName(textBoxSeatColor.Text);
            appConstantsData.SeatHoverColor = Color.FromName(textBoxSeatHoverColor.Text);
        }
        private void SaveOtherGroup()
        {
            appConstantsData.CompanyName = textBoxCompanyName.Text;
            appConstantsData.PasswordChar = Convert.ToChar(textBoxPasswordChar.Text);
            appConstantsData.CurrencySymbol = Convert.ToChar(textBoxCurrencySymbol.Text);
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
    }
}
