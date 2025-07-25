﻿using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Helpers;
using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class AddEditEmployeeForm : MetroFramework.Forms.MetroForm
    {
        private readonly List<Employee> employees;

        private readonly Employee currentEmployee;
        private readonly string startedPassword;

        private bool isValid;
        private bool logOut;

        public AddEditEmployeeForm(Employee userAccount, List<Employee> employees, Employee currentEmployee = null)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.employees = employees;

            isValid = false;
            logOut = false;

            labelAccountName.Text = userAccount.FullName;

            PopulateProfessionsGroup();

            if (currentEmployee != null)
            {
                this.currentEmployee = currentEmployee;
                startedPassword = currentEmployee.Password;
                PopulateFields();
            }
            else
            {
                startedPassword = "";
                this.currentEmployee = new Employee();
            }
        }

        private void TextBoxFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxLogin.Focus();
        }

        private void TextBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPassword.Focus();
        }

        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkBoxDirector.Focus();
        }

        private void CheckBoxDirector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkBoxAdministrator.Focus();
        }

        private void CheckBoxAdministrator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) checkBoxCashier.Focus();
        }

        private void CheckBoxCashier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAddEmployee.Focus();
        }

        private void TextBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLetter(sender, e);
        }

        private void TextBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLoginAndPassword(sender, e);
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLoginAndPassword(sender, e);
        }

        private async void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            await SaveEmployee();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void PopulateProfessionsGroup()
        {
            checkBoxDirector.Text = AppConstants.ListOfProfessions[0];
            checkBoxAdministrator.Text = AppConstants.ListOfProfessions[1];
            checkBoxCashier.Text = AppConstants.ListOfProfessions[2];
        }

        private void PopulateFields()
        {
            textBoxFullName.Text = currentEmployee.FullName;
            textBoxLogin.Text = currentEmployee.Login;
            textBoxPassword.Text = currentEmployee.Password;
            checkBoxDirector.Checked = currentEmployee.ProfessionList.Contains(AppConstants.ListOfProfessions[0]);
            checkBoxAdministrator.Checked = currentEmployee.ProfessionList.Contains(AppConstants.ListOfProfessions[1]);
            checkBoxCashier.Checked = currentEmployee.ProfessionList.Contains(AppConstants.ListOfProfessions[2]);
        }

        private void CreateEmployee()
        {
            currentEmployee.FullName = textBoxFullName.Text;
            currentEmployee.Login = textBoxLogin.Text;
            currentEmployee.Password = textBoxPassword.Text;

            if (checkBoxDirector.Checked)
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[0]);

            if (checkBoxAdministrator.Checked)
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[1]);

            if (checkBoxCashier.Checked)
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[2]);
        }
        private async Task SaveEmployee()
        {
            CreateEmployee();
            EmployeeValidator validator = new EmployeeValidator(employees);
            if (validator.Validate(currentEmployee, out string errorMessage))
            {
                if (currentEmployee.Password != startedPassword)
                {
                    currentEmployee.Password = await DataHasher.HashPassword(currentEmployee.Password);
                }
                isValid = true;
                this.Close();
            }
            else MessageBox.Show(
                errorMessage,
                "Employee error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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

        public Employee GetEmployee()
        {
            return currentEmployee;
        }
    }
}
