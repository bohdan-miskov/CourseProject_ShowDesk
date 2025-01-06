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

        public AddEditEmployeeForm(List<Employee> employees, Employee currentEmployee)
        {
            this.employees = employees;

            isValid = false;

            if (currentEmployee != null)
            {
                this.currentEmployee = currentEmployee;
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
            checkBoxDirector.Checked = currentEmployee.ProfessionList.Contains("Director");
            checkBoxAdministrator.Checked = currentEmployee.ProfessionList.Contains("Administrator");
            checkBoxCashier.Checked = currentEmployee.ProfessionList.Contains("Cashier");
        }

        private void AddEmployee()
        {
            string fullName = textBoxFullName.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            newEmployee = new Employee(fullName, login, password);

            if (checkBoxDirector.Checked)
            {
                newEmployee.AddProfession("Director");
            }

            if (checkBoxAdministrator.Checked)
            {
                newEmployee.AddProfession("Administrator");
            }

            if (checkBoxCashier.Checked)
            {
                newEmployee.AddProfession("Cashier");
            }
        }

        private bool ValidateOfEmployee()
        {
            if (!(ParametersValidator.NameValidator(textBoxFullName.Text)))
            {
                MessageBox.Show(this,
                                "There was an error in the full name of the employee: the full name must be more than two characters long",
                                "Full name employee error",
                                MessageBoxButtons.OK);
                textBoxFullName.Focus();
                return false;
            }

            if (!(ParametersValidator.NameValidator(textBoxLogin.Text)))
            {
                MessageBox.Show(this,
                                "There was an error in the login of the employee: the login must be more than two characters long",
                                "Login employee error",
                                MessageBoxButtons.OK);
                textBoxLogin.Focus();
                return false;
            }

            if (LoginIsRepeat())
            {
                MessageBox.Show(this,
                                "There was an error in the login of the employee: the login must not be repeat",
                                "Login employee error",
                                MessageBoxButtons.OK);
                textBoxLogin.Focus();
                return false;
            }

            if (!(ParametersValidator.PasswordValidator(textBoxPassword.Text)))
            {

                MessageBox.Show(this,
                                "There was an error in the password of the employee: the password must be more than seven characters long",
                                "Password employee error",
                                MessageBoxButtons.OK);
                textBoxPassword.Focus();
                return false;
            }

            if (!(checkBoxDirector.Checked || checkBoxAdministrator.Checked || checkBoxCashier.Checked))
            {
                MessageBox.Show(this,
                                "There was an error in the check boxes professions of the employee: at least one profession must be chosen",
                                "СheckBoxProfession employee error",
                                MessageBoxButtons.OK);
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
