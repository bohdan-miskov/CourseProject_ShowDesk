using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms
{
    public partial class InstructionForm : MetroFramework.Forms.MetroForm
    {
        private readonly TabControlController tabControlController;

        public InstructionForm()
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this, true);

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

            string[] sections = Regex.Split(fullText, @"(?=^ВСТУП|^SETUP|^НАЛАШТУВАННЯ ПРОГРАМИ|^SETTINGS|^РОЛІ КОРИСТУВАЧІВ|^USER ROLES)", RegexOptions.Multiline);

            PopulateFields(sections);
        }

        private void PopulateFields(string[] sections)
        {
            string entry = "";
            string startSettings = "";
            string roles = "";

            foreach (string section in sections)
            {
                if (section.StartsWith("ВСТУП") || section.StartsWith("INTRODUCTION"))
                    entry = section.Trim();
                else if (section.StartsWith("НАЛАШТУВАННЯ ПРОГРАМИ") || section.StartsWith("SETTINGS"))
                    startSettings = section.Trim();
                else if (section.StartsWith("РОЛІ КОРИСТУВАЧІВ") || section.StartsWith("USER ROLES"))
                    roles = section.Trim();
            }


            richTextBoxEntry.Text = entry;
            richTextBoxStartSettings.Text = startSettings;
            richTextBoxRoles.Text = roles;
        }
    }
}
