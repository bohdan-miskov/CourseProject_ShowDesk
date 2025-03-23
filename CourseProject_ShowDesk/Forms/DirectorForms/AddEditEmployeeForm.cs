using CourseProject_ShowDesk.Scripts.Utilities.Validators;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class AddEditEmployeeForm : MetroFramework.Forms.MetroForm
    {
        private readonly List<Employee> employees;

        //private Employee newEmployee;
        private readonly Employee currentEmployee;

        private bool isValid;

        public AddEditEmployeeForm(List<Employee> employees, Employee currentEmployee=null)
        {
            InitializeComponent();

            this.employees = employees;

            isValid = false;

            PopulateProfessionsGroup();

            if (currentEmployee != null)
            {
                this.currentEmployee = currentEmployee;
                PopulateFields();
            }
            else
            {
                this.currentEmployee = new Employee();
            }
        }

        private void TextBoxFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxLogin.Focus();
            }
        }

        private void TextBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxDirector.Focus();
            }
        }

        private void CheckBoxDirector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxAdministrator.Focus();
            }
        }

        private void CheckBoxAdministrator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxCashier.Focus();
            }
        }

        private void CheckBoxCashier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddEmployee.Focus();
            }
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

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            CreateEmployee();
            EmployeeValidator validator = new EmployeeValidator(employees);
            if (validator.Validate(currentEmployee, out string errorMessage))
            {
                isValid = true;

                this.Close();
            }
            MessageBox.Show(
                errorMessage,
                "Employee error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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
            {
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[0]);
            }

            if (checkBoxAdministrator.Checked)
            {
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[1]);
            }

            if (checkBoxCashier.Checked)
            {
                currentEmployee.AddProfession(AppConstants.ListOfProfessions[2]);
            }
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
