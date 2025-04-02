using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class SelectionManager
    {
        private List<Control> selectedControls = new List<Control>();

        //public IReadOnlyList<Control> SelectedControls => selectedControls.AsReadOnly();

        public void AddToSelection(Control control)
        {
            if (control != null && !selectedControls.Contains(control))
            {
                selectedControls.Add(control);
                control.BackColor = Color.Yellow;
            }
        }

        public void ClearSelection()
        {
            foreach (var control in selectedControls)
            {
                control.BackColor = Color.LightGray;
            }
            selectedControls.Clear();
        }

        public void SetSelection(Control control)
        {
            if (control == null) return;
            ClearSelection();
            selectedControls.Add(control);
            control.BackColor = Color.Yellow;
        }
    }

}
