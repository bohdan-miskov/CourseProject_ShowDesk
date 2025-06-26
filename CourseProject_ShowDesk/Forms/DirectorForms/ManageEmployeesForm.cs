using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using CourseProject_ShowDesk.Scripts.Utilities.Helpers;
using DotNetEnv;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FormConfigurator.ConfigureForm(this, true);

            try
            {
                employeeManager = new EmployeeManager(new EmployeeBaseService());
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show(ex.Message + "\nGo to the settings.", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingsForm settingsForm = new SettingsForm(new Employee());
                settingsForm.ShowDialog();
                FormConfigurator.RestartApp();
            }

            labelAccountName.Text = userAccount.FullName;
            this.userAccount = userAccount;

            timerUpdate.Interval = AppConstants.UpdateEmployeesInterval;

            searchData = new SearchDataGrid(dataGridViewEmployees);

            string envPath = "../../.env";
            Env.Load(envPath);
            string masterKey = Environment.GetEnvironmentVariable("MASTER_PASSWORD");
            masterCypher = new MasterCypherAES(masterKey);
        }

        private async void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            await employeeManager.LoadFromDatabaseAsync();
            UpdateDataGridEmployees();
            DisableEditAndRemoveEmployees();
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

        private async void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await AddEmployeeAsync();
            await UpdateDataFromDataBaseAsync();
        }

        private async void EditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await EditEmployeeAsync();
            await UpdateDataFromDataBaseAsync();
        }

        private async void RemoveEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await RemoveEmployeeAsync();
            await UpdateDataFromDataBaseAsync();
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
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
        }

        private async void TimerUpdate_Tick(object sender, EventArgs e)
        {
            await UpdateDataFromDataBaseAsync();
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
        private async Task UpdateDataFromDataBaseAsync()
        {
            FormConfigurator.SetActivePictureBoxUpdate(pictureBoxUpdate);
            await employeeManager.LoadFromDatabaseAsync();
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
                    new String(AppConstants.PasswordChar, masterCypher.Decrypt(employee.Password).Length),
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

        private async Task AddEmployeeAsync()
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
                await employeeManager.AddEmployeeAsync(addEmployeeForm.GetEmployee());
        }

        private async Task EditEmployeeAsync()
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
                await employeeManager.UpdateEmployeeAsync(editEmployeeForm.GetEmployee());
        }

        private async Task RemoveEmployeeAsync()
        {
            Guid id = GetCurrentRowId();
            await employeeManager.RemoveEmployeeAsync(id);
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
