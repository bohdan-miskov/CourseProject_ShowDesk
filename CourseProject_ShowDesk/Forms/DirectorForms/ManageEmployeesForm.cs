using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Windows.Forms;
using DotNetEnv;
using CourseProject_ShowDesk.Scripts.Utilities.Helpers;

namespace CourseProject_ShowDesk.Forms.DirectorForms
{
    public partial class ManageEmployeesForm : MetroFramework.Forms.MetroForm
    {
        private readonly EmployeeManager employeeManager;
        private readonly Employee userAccount;

        private readonly SearchDataGrid searchData;
        private readonly MasterCypherAES masterCypher;

        public ManageEmployeesForm(Employee userAccount)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this,true);

            try
            {
                employeeManager = new EmployeeManager(new EmployeeBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee());
                settingsForm.ShowDialog();
                //FormConfigurator.RestartForm<ManageEmployeesForm>(this, userAccount);
                FormConfigurator.RestartApp();
            }

            labelAccountName.Text = userAccount.FullName;
            this.userAccount = userAccount;

            timerUpdate.Interval = AppConstants.UpdateEmployeesInterval;

            UpdateDataGridEmployees();
            DisableEditAndRemoveEmployees();

            searchData = new SearchDataGrid(dataGridViewEmployees);

            Env.Load();
            string masterKey = Environment.GetEnvironmentVariable("MASTER_PASSWORD");
            masterCypher = new MasterCypherAES(masterKey);
        }
        private void ManageEmployeesForm_Shown(object sender, EventArgs e)
        {
            ShowGreetings(userAccount.FullName);

            timerUpdate.Start();
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
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchByFragment();
        }
        private void TextBoxSearchField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchByFragment();
        }
        private void DataGridViewEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            searchData.SearchNavigation(e);
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
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            employeeManager.LoadFromDatabase();
            UpdateDataGridEmployees();
            DisableEditAndRemoveEmployees();
            FormConfigurator.RemoveActivePictureBoxUpdate(pictureBoxUpdate);
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

            if (addEmployeeForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

            if (addEmployeeForm.GetIsValid())
                employeeManager.AddEmployee(addEmployeeForm.GetEmployee());
        }

        private void EditEmployee()
        {
            Guid id = GetCurrentRowId();

            AddEditEmployeeForm editEmployeeForm = new AddEditEmployeeForm(userAccount, employeeManager.Employees, employeeManager.GetById(id));
            this.Hide();
            editEmployeeForm.ShowDialog();

            if (editEmployeeForm.GetLogOut())
            {
                LogOut();
                return;
            }

            this.Show();

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
            string password = masterCypher.Decrypt(employeeManager.GetById(id).Password);
            dataGridViewEmployees.CurrentRow.Cells[3].Value = password;
        }
        private void HidePassword()
        {
            string currentPassword = dataGridViewEmployees.CurrentRow.Cells[3].Value.ToString();
            dataGridViewEmployees.CurrentRow.Cells[3].Value = new String(AppConstants.PasswordChar, currentPassword.Length); ;
        }
        private void SearchByFragment()
        {
            string searchField = textBoxSearchField.Text.Trim();

            searchData.Search(searchField);

            if (searchData.HasResults()) searchData.HighlightCurrentResult();
            else MessageBox.Show(
                                "No results found",
                                "Not found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void LogOut()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }       
    }
}
