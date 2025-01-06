
using CourseProject_ShowDesk.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CourseProject_ShowDesk
{
    public partial class AuthenticateForm : MetroFramework.Forms.MetroForm
    {
        private string employeesFileName = "employees.json";

        private List<Employee> employees;

        public AuthenticateForm()
        {
            InitializeComponent();

            comboBoxUser.SelectedIndex = 0;

            employees = new List<Employee>();

            LoadEmployeesFromFile();

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
            if (File.Exists(employeesFileName))
            {
                employees = FileHandler.LoadFromJson<Employee>(employeesFileName);
            }
            else
            {
                MessageBox.Show(this,
                                $"File {employeesFileName} not found",
                                "Load employees error",
                                MessageBoxButtons.OK);
            }
        }

        private void ChangeOfImage()
        {
            if (comboBoxUser.SelectedIndex == 0)
            {
                pictureBoxAvatar.Image = Properties.Resources.Administrator;
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                pictureBoxAvatar.Image = Properties.Resources.Cashier;
            }
            else if (comboBoxUser.SelectedIndex == 2)
            {
                pictureBoxAvatar.Image = Properties.Resources.Director;
            }
        }

        private void Authenticate()
        {
            if (comboBoxUser.SelectedIndex == 0)
            {
                if (CheckAccount("Administrator"))
                {
                    new ManageStagesForm().ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                if (CheckAccount("Cashier"))
                {
                    new ManagePerformancesForm().ShowDialog();
                }
                else
                {
                    ShowErrorMessage();
                }
            }
            else if (comboBoxUser.SelectedIndex == 2)
            {
                if (CheckAccount("Cashier"))
                {
                    new ManageEmployeesForm().ShowDialog();
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
            MessageBox.Show($"Authenticate data is uncorrect",
                                "Authenticate error",
                                MessageBoxButtons.OK);
        }
    }
}
