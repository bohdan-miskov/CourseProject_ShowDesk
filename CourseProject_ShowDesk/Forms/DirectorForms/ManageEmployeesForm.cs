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

namespace CourseProject_ShowDesk.Scripts
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

            ShowGreetings(accountName);

            LoadEmployeesFromFile();

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }

        private void dataGridViewEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void dataGridViewEmployees_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void ManageEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEmployeesToFile();
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
            }
            else
            {
                editEmployeeToolStripMenuItem.Enabled = false;
                removeEmployeeToolStripMenuItem.Enabled = false;
            }
        }

        private void AddEmployee()
        {
            AddEditEmployeeForm addEmployeeForm = new AddEditEmployeeForm(employees, null);
            addEmployeeForm.ShowDialog();

            if(addEmployeeForm.GetIsValid())
            {
                employees.Add(addEmployeeForm.GetEmployee());
            }
        }

        private void EditEmployee()
        {
            int index = dataGridViewEmployees.CurrentRow.Index;

            AddEditEmployeeForm editEmployeeForm = new AddEditEmployeeForm(employees, index);
            editEmployeeForm.ShowDialog();

            if(editEmployeeForm.GetIsValid())
            {
                employees[index] = editEmployeeForm.GetEmployee();
            }

        }

        private void OpenSettings()
        {
            new SettingsForm().ShowDialog();
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
