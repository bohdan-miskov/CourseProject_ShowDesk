using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Utilities
{
    public static class FormConfigurator
    {
        public static void ConfigureForm(Form form, bool isFixedForm=false)
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
    }

}
