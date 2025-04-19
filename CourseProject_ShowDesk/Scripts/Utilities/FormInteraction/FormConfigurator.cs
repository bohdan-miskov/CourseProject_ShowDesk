using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public static class FormConfigurator
    {
        public static void ConfigureForm(Form form, bool isFixedForm = false)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Font = new Font("Modern No. 20", 14);

            if (isFixedForm)
            {
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
            }
        }

        public static void SetActivePictureBoxUpdate(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.loading_gif;
        }
        public static void RemoveActivePictureBoxUpdate(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.restart_icon;
        }
        public static void SetAutoCompleteForTextBox(TextBox textBox, string[] source)
        {
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(source);

            textBox.AutoCompleteCustomSource = autoComplete;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }

}
