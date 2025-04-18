using CourseProject_ShowDesk.Forms.AdministratorForms;
using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class ManageEmployeesForm : MetroFramework.Forms.MetroForm
    {
        private readonly EmployeeManager employeeManager;

        private readonly Employee userAccount;

        public ManageEmployeesForm(Employee userAccount)
        {
            InitializeComponent();

            try
            {
                employeeManager = new EmployeeManager(new EmployeeBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee("Guest", "", ""));
                settingsForm.ShowDialog();
            }

            labelAccountName.Text = userAccount.FullName;
            this.userAccount = userAccount;

            timerUpdate.Interval = AppConstants.UpdateEmployeesInterval;

            UpdateDataGridEmployees();
            DisableEditAndRemoveEmployees();
            ShowGreetings(userAccount.FullName);

            timerUpdate.Start();

            FormConfigurator.ConfigureForm(this);
        }

        private void DataGridViewEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void DataGridViewEmployees_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            DisableEditAndRemoveEmployees();
        }

        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee();
            UpdateDataFromDataBase();
        }

        private void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployee();
            UpdateDataFromDataBase();
        }

        private void RemoveEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEmployee();
            UpdateDataFromDataBase();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void ToolStripMenuItemShowPassword_Click(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void ToolStripMenuItemHidePassword_Click(object sender, EventArgs e)
        {
            HidePassword();
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateDataFromDataBase();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void ManageEmployeesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerUpdate.Stop();
        }
        private void ShowGreetings(string name)
        {
            MessageBox.Show(
                $"{name} Welcome to our program! You entered under the profession of {AppConstants.ListOfProfessions[0]}",
                "Welcome",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void UpdateDataFromDataBase()
        {
            employeeManager.LoadFromDatabase();
            UpdateDataGridEmployees();
            DisableEditAndRemoveEmployees();
        }
        private void UpdateDataGridEmployees()
        {
            dataGridViewEmployees.Rows.Clear();

            foreach (Employee employee in employeeManager.Employees)
            {
                AddEmployeeToDataGrid(employee);
            }
        }

        private void AddEmployeeToDataGrid(Employee employee)
        {
            dataGridViewEmployees.Rows.Add(
                    employee.Id,
                    employee.FullName,
                    employee.Login,
                    new String(AppConstants.PasswordChar, employee.Password.Length),
                    employee.GetStringOfProfessionList()
                    );
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

        private Guid GetCurrentRowId()
        {
            return Guid.Parse(dataGridViewEmployees.CurrentRow.Cells[0].Value.ToString());
        }

        private void AddEmployee()
        {
            AddEditEmployeeForm addEmployeeForm = new AddEditEmployeeForm(userAccount, employeeManager.Employees);
            this.Hide();
            addEmployeeForm.ShowDialog();
            this.Show();

            if (addEmployeeForm.GetLogOut())
            {
                LogOut();
                return;
            }

            if (addEmployeeForm.GetIsValid())
                employeeManager.AddEmployee(addEmployeeForm.GetEmployee());
        }

        private void EditEmployee()
        {
            Guid id = GetCurrentRowId();

            AddEditEmployeeForm editEmployeeForm = new AddEditEmployeeForm(userAccount, employeeManager.Employees, employeeManager.GetById(id));
            this.Hide();
            editEmployeeForm.ShowDialog();
            this.Show();

            if (editEmployeeForm.GetLogOut())
            {
                LogOut();
                return;
            }

            if (editEmployeeForm.GetIsValid())
                employeeManager.UpdateEmployee(editEmployeeForm.GetEmployee());
        }

        private void RemoveEmployee()
        {
            Guid id = GetCurrentRowId();
            employeeManager.RemoveEmployee(id);
        }
        private void OpenSettings()
        {
            SettingsForm settingsForm = new SettingsForm(userAccount);
            this.Hide();
            settingsForm.ShowDialog();
            this.Show();

            if (settingsForm.GetLogOut())
            {
                LogOut();
                return;
            }
        }

        private void ShowPassword()
        {
            Guid id = GetCurrentRowId();

            dataGridViewEmployees.CurrentRow.Cells[3].Value = employeeManager.GetById(id).Password;
        }
        private void HidePassword()
        {
            string currentPassword = dataGridViewEmployees.CurrentRow.Cells[3].Value.ToString();
            dataGridViewEmployees.CurrentRow.Cells[3].Value = new String(AppConstants.PasswordChar, currentPassword.Length); ;
        }

        private void LogOut()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
