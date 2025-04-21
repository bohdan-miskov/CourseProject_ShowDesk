using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class ElementMover
    {
        private readonly Panel panelSeating;
        private readonly Panel panelViewport;
        private Control selectedControl;
        private Point dragOffset;
        private bool isDragging;

        public ElementMover(Panel panelSeating, Panel panelViewport)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
        }

        public void StartDragging(Control control, Point location)
        {
            if (control == null) return;
            selectedControl = control;
            isDragging = true;
            dragOffset = new Point(location.X - control.Left, location.Y - control.Top);
        }

        public void Move(Point location)
        {
            if (isDragging && selectedControl != null)
            {
                selectedControl.Location = new Point(
                    location.X - dragOffset.X, 
                    location.Y - dragOffset.Y
                    );
            }
        }

        public void Stop()
        {
            isDragging = false;
            if (panelViewport != null) panelViewport.Cursor = Cursors.Default;
        }
    }
}
