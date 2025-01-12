
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
            if (comboBoxUser.SelectedIndex == 0)
            {
                if (CheckAccount(AppConstants.ListOfProfessions[0]))
                {
                    new ManageEmployeesForm().ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                if (CheckAccount(AppConstants.ListOfProfessions[1]))
                {
                    new ManageStagesForm().ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 2)
            {
                if (CheckAccount(AppConstants.ListOfProfessions[2]))
                {
                    new ManagePerformancesForm().ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
        }

        private bool CheckAccount(string currentProfession)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Login == textBoxLogin.Text &&
                    employee.Password == textBoxPassword.Text &&
                    employee.ProfessionList.Contains(currentProfession))
                {
                    return true;
                }
            }

            return false;
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
