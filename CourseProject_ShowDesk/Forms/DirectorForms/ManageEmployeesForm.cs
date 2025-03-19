using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CourseProject_ShowDesk.Forms;
using System.Reflection;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class ManageEmployeesForm : MetroFramework.Forms.MetroForm
    {
        private List<Employee> employees;

        private string cipher = new string('*', 12);

        public ManageEmployeesForm(string accountName)
        {
            InitializeComponent();

            employees = new List<Employee>();

            labelAccountName.Text = accountName;

            LoadEmployeesFromFile();

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();

            ShowGreetings(accountName);
        }

        private void dataGridViewEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void dataGridViewEmployees_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee();

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployee();

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }

        private void removeEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridViewEmployees.CurrentRow.Index;

            employees.RemoveAt(index);

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void toolStripMenuItemShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void toolStripMenuItemHidePassword_Click(object sender, EventArgs e)
        {
            HidePassword();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
            }

            this.Close();
        }

        private void ManageEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployeesToFile();
        }

        private void ManageEmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowGreetings(string name)
        {
            MessageBox.Show(
                $"{name} Welcome to our program! You entered under the profession of {AppConstants.ListOfProfessions[0]}",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateDataGridEmployees()
        {
            dataGridViewEmployees.Rows.Clear();

            foreach (Employee employee in employees)
            {
                AddEmployeeToDataGrid(employee);
            }
        }

        private void AddEmployeeToDataGrid(Employee employee)
        {
            dataGridViewEmployees.Rows.Add(
                    employee.FullName,
                    employee.Login,
                    cipher,
                    employee.GetStringOfProfessionList()
                    );
        }

        private void SaveEmployeesToFile()
        {
            FileHandler.SaveListToJson(AppConstants.EmployeesFileName, employees);
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

        private void DisableEditAndRemoveEmployees()
        {
            if (dataGridViewEmployees.CurrentRow != null)
            {
                editEmployeeToolStripMenuItem.Enabled = true;
                removeEmployeeToolStripMenuItem.Enabled = true;
                editEmployeeToolStripMenuItem1.Enabled = true;
                removeEmployeeToolStripMenuItem1.Enabled = true;
            }
            else
            {
                editEmployeeToolStripMenuItem.Enabled = false;
                removeEmployeeToolStripMenuItem.Enabled = false;
                editEmployeeToolStripMenuItem1.Enabled = false;
                removeEmployeeToolStripMenuItem1.Enabled = false;
            }
        }

        private void AddEmployee()
        {
            AddEditEmployeeForm addEmployeeForm = new AddEditEmployeeForm(employees, null);
            this.Hide();
            addEmployeeForm.ShowDialog();
            this.Show();

            if (addEmployeeForm.GetIsValid())
            {
                employees.Add(addEmployeeForm.GetEmployee());
            }
        }

        private void EditEmployee()
        {
            int index = dataGridViewEmployees.CurrentRow.Index;

            AddEditEmployeeForm editEmployeeForm = new AddEditEmployeeForm(employees, index);
            this.Hide();
            editEmployeeForm.ShowDialog();
            this.Show();

            if (editEmployeeForm.GetIsValid())
            {
                employees[index] = editEmployeeForm.GetEmployee();
            }

        }

        private void OpenSettings()
        {
            SettingsForm settingsForm = new SettingsForm();
            this.Hide();
            settingsForm.ShowDialog();
            this.Show();
        }

        private void ShowPassword()
        {
            int index = dataGridViewEmployees.CurrentRow.Index;

            dataGridViewEmployees.CurrentRow.Cells[2].Value=employees[index].Password;
        }

        private void HidePassword()
        {
            dataGridViewEmployees.CurrentRow.Cells[2].Value = cipher;
        }
    }
}
