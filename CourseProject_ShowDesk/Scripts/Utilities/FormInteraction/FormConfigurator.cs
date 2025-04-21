using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public static class FormConfigurator
    {
        public static void ConfigureForm(Form form, bool isFullScreenForm = false)
        {
            form.StartPosition = FormStartPosition.CenterScreen;

            if (isFullScreenForm)
            {
                
                form.WindowState = FormWindowState.Maximized;
                
            }
            else form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }

        public static void SetActivePictureBoxUpdate(PictureBox pictureBox)
        {
            //pictureBox.Image = Properties.Resources.loading_gif;
        }
        public static void RemoveActivePictureBoxUpdate(PictureBox pictureBox)
        {
            //pictureBox.Image = Properties.Resources.restart_icon;
        }
        public static void SetAutoCompleteForTextBox(TextBox textBox, string[] source)
        {
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(source);

            textBox.AutoCompleteCustomSource = autoComplete;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static void RestartForm<T>(Form currentForm, params object[] constructorArgs) where T : Form
        {
            Form newForm = (Form)Activator.CreateInstance(typeof(T), constructorArgs);
            newForm.Show();

            currentForm.Close();
        }

        public static void RestartApp()
        {
            Application.Restart();
        }
    }

}
