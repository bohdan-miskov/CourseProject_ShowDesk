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
        private List<Employee> employees;

        //private Employee newEmployee;
        private Employee currentEmployee;

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

        private void textBoxFullName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxLogin.Focus();
            }
        }

        private void textBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxDirector.Focus();
            }
        }

        private void checkBoxDirector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxAdministrator.Focus();
            }
        }

        private void checkBoxAdministrator_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBoxCashier.Focus();
            }
        }

        private void checkBoxCashier_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddEmployee.Focus();
            }
        }

        private void textBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLetter(sender, e);
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLoginAndPassword(sender, e);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ParametersValidator.ValidatorLoginAndPassword(sender, e);
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
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

        private void AddEditEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

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
