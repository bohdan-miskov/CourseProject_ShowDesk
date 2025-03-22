using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Forms.CashierForms;
using CourseProject_ShowDesk.Forms.DirectorForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CourseProject_ShowDesk.Forms
{
    public partial class AuthenticateForm : MetroFramework.Forms.MetroForm
    {
        private EmployeeManager employeeManager;

        public AuthenticateForm()
        {
            InitializeComponent();

            employeeManager = new EmployeeManager(new EmployeeBaseService());

            //LoadEmployeesFromFile();

            PopulateComboBox();

            comboBoxUser.SelectedIndex = 2;
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
                comboBoxUser.Focus();
            }
        }

        private void comboBoxUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAuthentificate.Focus();
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeOfImage();
        }

        private void buttonAuthentificate_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void AuthenticateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void LoadEmployeesFromFile()
        //{
        //    if (File.Exists(AppConstants.EmployeesFileName))
        //    {
        //        employees = FileHandler.LoadListFromJson<Employee>(AppConstants.EmployeesFileName);
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //                        $"File {AppConstants.EmployeesFileName} not found",
        //                        "Load employees error",
        //                        MessageBoxButtons.OK,
        //                        MessageBoxIcon.Error);
        //    }
        //}

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
            {
                pictureBoxAvatar.Image = Properties.Resources.Director;
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                pictureBoxAvatar.Image = Properties.Resources.Administrator;
            }
            else if (comboBoxUser.SelectedIndex == 2)
            {
                pictureBoxAvatar.Image = Properties.Resources.Cashier;
            }
        }

        private void Authenticate()
        {
            string accountName;

            if (comboBoxUser.SelectedIndex == 0)
            {
                accountName = CheckAccountAndGetName(AppConstants.ListOfProfessions[0]);

                if (accountName!=null)
                {
                    ManageEmployeesForm manageEmployeesForm = new ManageEmployeesForm(accountName);
                    manageEmployeesForm.Show();
                    this.Hide();
                    //ClearLogInField();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                accountName = CheckAccountAndGetName(AppConstants.ListOfProfessions[1]);

                if (accountName!=null)
                {
                    ManageStagesForm manageStagesForm = new ManageStagesForm(accountName);
                    manageStagesForm.Show();
                    this.Hide();
                    //ClearLogInField();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 2)
            {
                accountName = CheckAccountAndGetName(AppConstants.ListOfProfessions[2]);

                if (accountName!=null)
                {
                    ManagePerformancesForm managePerformancesForm = new ManagePerformancesForm(accountName);
                    managePerformancesForm.Show();
                    this.Hide();
                    //ClearLogInField();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
        }

        private string CheckAccountAndGetName(string currentProfession)
        {
            foreach (Employee employee in employeeManager.Employees)
            {
                if (employee.Login == textBoxLogin.Text &&
                    employee.Password == textBoxPassword.Text &&
                    employee.ProfessionList.Contains(currentProfession))
                {
                    return employee.FullName;
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
    }
}
