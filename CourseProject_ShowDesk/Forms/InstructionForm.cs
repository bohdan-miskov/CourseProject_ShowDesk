using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseProject_ShowDesk.Forms
{
    public partial class InstructionForm : MetroFramework.Forms.MetroForm
    {
        private readonly TabControlController tabControlController;

        public InstructionForm()
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            tabControlController = new TabControlController(tabControlInstruction);
            comboBoxLanguage.SelectedIndex = 1;
        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeHelpText();
        }

        private void InstructionForm_KeyDown(object sender, KeyEventArgs e)
        {
            tabControlController.TabControlNavigation(e);
        }

        private void ChangeHelpText()
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();

            if (selectedLanguage == "UA") LoadHelpText("ua");
            else if (selectedLanguage == "EN") LoadHelpText("en");
        }

        private void LoadHelpText(string languageCode)
        {
            string filePath = $"help_{languageCode}.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Instruction file 'help_{languageCode}.txt' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fullText = File.ReadAllText(filePath);

            string[] sections = Regex.Split(fullText,
                @"(?=^ВСТУП|^SETUP|^НАЛАШТУВАННЯ ПРОГРАМИ|^SETTINGS|^РОЛІ КОРИСТУВАЧІВ|^USER ROLES|^РОБОТА З ПОДІЯМИ|^WORKING WITH EVENTS|^ПРОДАЖ КВИТКІВ|^TICKET SALES|^СТАТИСТИКА І ЗВІТНІСТЬ|^STATISTICS AND REPORTS)", 
                RegexOptions.Multiline);

            PopulateFields(sections);
        }

        private void PopulateFields(string[] sections)
        {
            string entry = "";
            string startSettings = "";
            string roles = "";
            string events = "";
            string sales = "";
            string statistics = "";

            foreach (string section in sections)
            {
                if (section.StartsWith("ВСТУП") || section.StartsWith("INTRODUCTION"))
                    entry = section.Trim();
                else if (section.StartsWith("НАЛАШТУВАННЯ ПРОГРАМИ") || section.StartsWith("SETTINGS"))
                    startSettings = section.Trim();
                else if (section.StartsWith("РОЛІ КОРИСТУВАЧІВ") || section.StartsWith("USER ROLES"))
                    roles = section.Trim();
                else if (section.StartsWith("РОБОТА З ПОДІЯМИ") || section.StartsWith("WORKING WITH EVENTS"))
                    events = section.Trim();
                else if (section.StartsWith("ПРОДАЖ КВИТКІВ") || section.StartsWith("TICKET SALES"))
                    sales = section.Trim();
                else if (section.StartsWith("СТАТИСТИКА І ЗВІТНІСТЬ") || section.StartsWith("STATISTICS AND REPORTS"))
                    statistics = section.Trim();
            }

            richTextBoxEntry.Text = entry;
            richTextBoxStartSettings.Text = startSettings;
            richTextBoxRoles.Text = roles;
            richTextBoxWorkingWithEvents.Text=events;
            richTextBoxTicketSales.Text = sales;
            richTextBoxStatisticsAndReports.Text = statistics;
        }
    }
}
