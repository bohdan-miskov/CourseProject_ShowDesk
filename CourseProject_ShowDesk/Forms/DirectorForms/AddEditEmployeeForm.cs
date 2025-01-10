using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts
{
    public partial class AddEditEmployeeForm : MetroFramework.Forms.MetroForm
    {
        private List<Employee> employees;

        private Employee newEmployee;
        private Employee currentEmployee;

        private bool isValid;

        public AddEditEmployeeForm(List<Employee> employees, int? index)
        {
            this.employees = employees;

            isValid = false;

            if (index != null)
            {
                this.currentEmployee = employees[Convert.ToInt32(index)];
                PopulateFields();
            }

            InitializeComponent();
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
            if(ValidateOfEmployee())
            {
                AddEmployee();

                isValid = true;

                this.Close();
            }
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

        private void AddEmployee()
        {
            string fullName = textBoxFullName.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            newEmployee = new Employee(fullName, login, password);

            if (checkBoxDirector.Checked)
            {
                newEmployee.AddProfession(AppConstants.ListOfProfessions[0]);
            }

            if (checkBoxAdministrator.Checked)
            {
                newEmployee.AddProfession(AppConstants.ListOfProfessions[1]);
            }

            if (checkBoxCashier.Checked)
            {
                newEmployee.AddProfession(AppConstants.ListOfProfessions[2]);
            }
        }

        private bool ValidateOfEmployee()
        {
            if (!ValidateOfEmployeeName()) return false;
            if (!ValidateOfEmployeeLogin()) return false;
            if (!ValidateOfEmployeePassword()) return false;
            if (!ValidateOfEmployeeProfessions()) return false;

            return true;
        }

        private bool ValidateOfEmployeeName()
        {
            if (!(ParametersValidator.NameValidator(textBoxFullName.Text)))
            {
                MessageBox.Show(
                                "There was an error in the full name of the employee: the full name must be more than two characters long",
                                "Full name employee error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfEmployeeLogin()
        {
            if (!(ParametersValidator.NameValidator(textBoxLogin.Text)))
            {
                MessageBox.Show(
                                "There was an error in the login of the employee: the login must be more than two characters long",
                                "Login employee error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxLogin.Focus();
                return false;
            }

            if (LoginIsRepeat())
            {
                MessageBox.Show(
                                "There was an error in the login of the employee: the login must not be repeat",
                                "Login employee error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxLogin.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfEmployeePassword()
        {
            if (!(ParametersValidator.PasswordValidator(textBoxPassword.Text)))
            {

                MessageBox.Show(
                                "There was an error in the password of the employee: the password must be more than seven characters long",
                                "Password employee error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOfEmployeeProfessions()
        {
            if (!(checkBoxDirector.Checked || checkBoxAdministrator.Checked || checkBoxCashier.Checked))
            {
                MessageBox.Show(this,
                                "There was an error in the check boxes professions of the employee: at least one profession must be chosen",
                                "СheckBoxProfession employee error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                checkBoxCashier.Focus();
                return false;
            }

            return true;
        }

        private bool LoginIsRepeat()
        {
            foreach (Employee employee in employees)
            {
                if (textBoxLogin.Text == employee.Login)
                {
                    return true;
                }
            }

            return false;
        }

        public bool GetIsValid()
        {
            return isValid;
        }

        public Employee GetEmployee()
        {
            return newEmployee;
        }

    }
}
