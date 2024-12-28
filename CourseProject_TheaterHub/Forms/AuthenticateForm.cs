
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_TheaterHub
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

        private void buttonAuthentificate_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedIndex == 0)
            {
                new ManageStagesForm().Show(this);
                this.Hide();
            }
            else if (comboBoxUser.SelectedIndex == 1)
            {
                new ManagePerformancesForm().Show(this);
                this.Hide();
            }
        }
    }
}
