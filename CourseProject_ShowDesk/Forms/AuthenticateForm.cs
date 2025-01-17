
using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CourseProject_ShowDesk
{
    public partial class AuthenticateForm : MetroFramework.Forms.MetroForm
    {
        private List<Employee> employees;

        public AuthenticateForm()
        {
            InitializeComponent();

            employees = new List<Employee>();

            LoadEmployeesFromFile();

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

        private void LoadEmployeesFromFile()
        {
            if (File.Exists(AppConstants.EmployeesFileName))
            {
                employees = FileHandler.LoadListFromJson<Employee>(AppConstants.EmployeesFileName);
            }
            else
            {
                MessageBox.Show(
                                $"File {AppConstants.EmployeesFileName} not found",
                                "Load employees error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
                    new ManageEmployeesForm(accountName).ShowDialog();
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
                    new ManageStagesForm(accountName).ShowDialog();
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
                    new ManagePerformancesForm(accountName).ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
        }

        private string CheckAccountAndGetName(string currentProfession)
        {
            foreach (Employee employee in employees)
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
