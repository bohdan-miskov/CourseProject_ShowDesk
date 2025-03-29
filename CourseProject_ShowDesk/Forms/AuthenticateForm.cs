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
        private readonly EmployeeManager employeeManager;

        public AuthenticateForm()
        {
            InitializeComponent();

            employeeManager = new EmployeeManager(new EmployeeBaseService());

            PopulateComboBox();

            comboBoxUser.SelectedIndex = 2;
        }

        private void TextBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxPassword.Focus();

        }

        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) comboBoxUser.Focus();
        }

        private void ComboBoxUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAuthentificate.Focus();
        }

        private void ComboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeOfImage();
        }

        private void ButtonAuthentificate_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void AuthenticateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                pictureBoxAvatar.Image = Properties.Resources.Director;

            else if (comboBoxUser.SelectedIndex == 1)
                pictureBoxAvatar.Image = Properties.Resources.Administrator;

            else if (comboBoxUser.SelectedIndex == 2)
                pictureBoxAvatar.Image = Properties.Resources.Cashier;
        }

        private void Authenticate()
        {
            if (comboBoxUser.SelectedIndex == 0) AuthenticateDirector();
            else if (comboBoxUser.SelectedIndex == 1) AuthenticateAdministrator();
            else if (comboBoxUser.SelectedIndex == 2) AuthenticateCashier();
        }

        private void AuthenticateDirector()
        {
            Employee account = CheckAccountAndGetName(AppConstants.ListOfProfessions[0]);

            if (account == null)
            {
                ShowErrorMessage();
                return;
            }

            ManageEmployeesForm manageEmployeesForm = new ManageEmployeesForm(account);
            this.Hide();
            DialogResult result = manageEmployeesForm.ShowDialog();

            if (result != DialogResult.OK) Application.Exit();

            this.Show();
            //ClearLogInField();
        }

        private void AuthenticateAdministrator()
        {
            Employee account = CheckAccountAndGetName(AppConstants.ListOfProfessions[1]);

            if (account == null)
            {
                ShowErrorMessage();
                return;  
            }

            ManageStagesForm manageStagesForm = new ManageStagesForm(account);
            this.Hide();
            DialogResult result = manageStagesForm.ShowDialog();

            if (result != DialogResult.OK) Application.Exit();

            this.Show();
            //ClearLogInField();
        }

        private void AuthenticateCashier()
        {
            Employee account = CheckAccountAndGetName(AppConstants.ListOfProfessions[2]) ??
                    CheckAccountAndGetName(AppConstants.ListOfProfessions[1]);

            if (account == null)
            {
                ShowErrorMessage();
                return;
            }

            ManagePerformancesForm managePerformancesForm = new ManagePerformancesForm(account);
            this.Hide();
            DialogResult result = managePerformancesForm.ShowDialog();

            if (result != DialogResult.OK) Application.Exit();

            this.Show();
            //ClearLogInField();
        }

        private Employee CheckAccountAndGetName(string currentProfession)
        {
            foreach (Employee employee in employeeManager.Employees)
            {
                if (employee.Login == textBoxLogin.Text &&
                    employee.Password == textBoxPassword.Text &&
                    employee.ProfessionList.Contains(currentProfession))
                {
                    return employee;
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
