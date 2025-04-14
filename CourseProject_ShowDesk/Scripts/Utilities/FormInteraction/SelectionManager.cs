using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class SelectionManager
    {
        private List<Control> selectedControls = new List<Control>();

        //public IReadOnlyList<Control> SelectedControls => selectedControls.AsReadOnly();
        public List<Control> SelectedControls
        {
            get
            {
                return selectedControls;
            }
        }
        public void AddToSelection(Control control)
        {
            if (control != null && !selectedControls.Contains(control))
            {
                selectedControls.Add(control);
                control.BackColor = Color.Yellow;
            }
        }

        public void RemoveSelection(Control control, Color color)
        {
            control.BackColor = color;
            selectedControls.Remove(control);
        }
    }

}
