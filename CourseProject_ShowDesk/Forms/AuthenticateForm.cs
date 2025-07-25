﻿using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Forms.CashierForms;
using CourseProject_ShowDesk.Forms.DirectorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Helpers;
using DotNetEnv;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms
{
    public partial class AuthenticateForm : MetroFramework.Forms.MetroForm
    {
        private readonly EmployeeManager employeeManager;

        public AuthenticateForm()
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            try
            {
                employeeManager = new EmployeeManager(new EmployeeBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee());
                settingsForm.ShowDialog();
                FormConfigurator.RestartApp();
            }

            PopulateComboBox();

            comboBoxUser.SelectedIndex = 2;
        }

        private async void AuthenticateForm_Load(object sender, EventArgs e)
        {
            await employeeManager.LoadFromDatabaseAsync();
        }

        private void TextBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPassword.Focus();
        }

        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBoxUser.Focus();
        }

        private void ComboBoxUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAuthentificate.Focus();
        }

        private void ComboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeOfImage();
        }

        private async void ButtonAuthentificate_Click(object sender, EventArgs e)
        {
            await Authenticate();
        }

        private void ButtonInstruction_Click(object sender, EventArgs e)
        {
            OpenInstruction();
        }


        private void AuthenticateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PopulateComboBox()
        {
            comboBoxUser.Items.Clear();

            foreach (string profession in AppConstants.ListOfProfessions)
            {
                comboBoxUser.Items.Add(profession);
            }
        }

        private void ChangeOfImage()
        {
            if (comboBoxUser.SelectedIndex == 0)
                pictureBoxAvatar.Image = Properties.Resources.Director;

            else if (comboBoxUser.SelectedIndex == 1)
                pictureBoxAvatar.Image = Properties.Resources.Administrator;

            else if (comboBoxUser.SelectedIndex == 2)
                pictureBoxAvatar.Image = Properties.Resources.Cashier;
        }

        private async Task Authenticate()
        {
            DialogResult result;
            if (comboBoxUser.SelectedIndex == 0) result = await AuthenticateDirector();
            else if (comboBoxUser.SelectedIndex == 1) result = await AuthenticateAdministrator();
            else result = await AuthenticateCashier();

            if (result == DialogResult.OK)
            {
                ClearLogInField();
                this.Show();
            }
            else if (result == DialogResult.Abort) ShowErrorMessage();
            else Application.Exit();
        }

        private async Task<DialogResult> AuthenticateDirector()
        {
            Employee account = await CheckAccountAndGetName(AppConstants.ListOfProfessions[0]);

            if (account == null)
            {
                bool directorExist = employeeManager.Employees.Any((employee) => employee.ProfessionList.Contains(AppConstants.ListOfProfessions[0]));
                if (directorExist) return DialogResult.Abort;
                else
                {
                    account = new Employee
                    {
                        FullName = "Visitor"
                    };
                }
            }

            ManageEmployeesForm manageEmployeesForm = new ManageEmployeesForm(account);
            this.Hide();
            return manageEmployeesForm.ShowDialog();
        }

        private async Task<DialogResult> AuthenticateAdministrator()
        {
            Employee account = await CheckAccountAndGetName(AppConstants.ListOfProfessions[1]);

            if (account == null) return DialogResult.Abort;

            ManageStagesForm manageStagesForm = new ManageStagesForm(account);
            this.Hide();
            return manageStagesForm.ShowDialog();


        }

        private async Task<DialogResult> AuthenticateCashier()
        {
            Employee account = await CheckAccountAndGetName(AppConstants.ListOfProfessions[2]) ??
                    await CheckAccountAndGetName(AppConstants.ListOfProfessions[1]);

            if (account == null) return DialogResult.Abort;

            ManagePerformancesForm managePerformancesForm = new ManagePerformancesForm(account);
            this.Hide();
            return managePerformancesForm.ShowDialog();
        }

        private async Task<Employee> CheckAccountAndGetName(string currentProfession)
        {
            foreach (Employee employee in employeeManager.Employees)
            {
                string pass = employee.Password;
                if (employee.Login == textBoxLogin.Text &&
                    await DataHasher.VerifyPassword(textBoxPassword.Text,pass) &&
                    employee.ProfessionList.Contains(currentProfession))
                {
                    return employee;
                }
            }

            return null;
        }

        private void ClearLogInField()
        {
            comboBoxUser.SelectedIndex = 2;
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show(
                            $"Authenticate data is uncorrect",
                            "Authenticate error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void OpenInstruction()
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
        }
    }
}
