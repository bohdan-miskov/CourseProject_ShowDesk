
using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public partial class AuthenticateForm : MetroFramework.Forms.MetroForm
    {

        public AuthenticateForm()
        {
            InitializeComponent();

            comboBoxUser.SelectedIndex = 0;

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
                new ManageStagesForm().ShowDialog(this);
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                new ManagePerformancesForm().ShowDialog(this);
            }
        }
    }
}
