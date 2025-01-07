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

namespace CourseProject_ShowDesk.Scripts
{
    public partial class ManageEmployeesForm : MetroFramework.Forms.MetroForm
    {
        private List<Employee> employees;

        public ManageEmployeesForm()
        {
            InitializeComponent();

            employees = new List<Employee>();

            LoadEmployeesFromFile();

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }

        private void UpdateDataGridEmployees()
        {
            dataGridViewEmployees.Rows.Clear();

            foreach (Employee employee in employees)
            {
                dataGridViewEmployees.Rows.Add(
                    employee.FullName,
                    employee.Login,
                    employee.Password,
                    employee.GetStringOfProfessionList()
                    );
            }
        }

        private void SaveEmployeesToFile()
        {
            FileHandler.SaveToJson(AppConstants.EmployeesFileName, employees);
        }

        private void LoadEmployeesFromFile()
        {
            if (File.Exists(AppConstants.EmployeesFileName))
            {
                employees = FileHandler.LoadFromJson<Employee>(AppConstants.EmployeesFileName);
            }
            else
            {
                MessageBox.Show(this,
                                $"File {AppConstants.EmployeesFileName} not found",
                                "Load employees error",
                                MessageBoxButtons.OK);
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
            AddEditEmployeeForm editEmployeeForm = new AddEditEmployeeForm(employees, employees[dataGridViewEmployees.CurrentRow.Index]);
            editEmployeeForm.ShowDialog();

            if(editEmployeeForm.GetIsValid())
            {
                employees[dataGridViewEmployees.CurrentRow.Index] = editEmployeeForm.GetEmployee();
            }

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
            employees.RemoveAt(dataGridViewEmployees.CurrentRow.Index);

            UpdateDataGridEmployees();

            DisableEditAndRemoveEmployees();
        }
    }
}
