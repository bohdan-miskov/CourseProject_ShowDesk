using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class ElementResizer
    {
        private readonly Panel panelSeating;
        private Control resizingControl;
        private Point resizeStart;
        private Size originalSize;
        private bool isResizing;

        public ElementResizer(Panel panelSeating)
        {
            this.panelSeating = panelSeating;
        }

        public bool IsInResizeZone(Control control, Point mouseLocation)
        {
            const int resizeMargin = 10;
            return mouseLocation.X >= control.Right - resizeMargin && 
                mouseLocation.Y >= control.Bottom - resizeMargin;
        }

        public void StartResizing(Control control, Point location)
        {
            resizingControl = control;
            isResizing = true;
            resizeStart = location;
            originalSize = control.Size;
        }

        public void Resize(Point location)
        {
            if (!isResizing || resizingControl == null) return;

            int deltaX = location.X - resizeStart.X;
            int deltaY = location.Y - resizeStart.Y;
            resizingControl.Size = new Size(
                Math.Max(20, originalSize.Width + deltaX), 
                Math.Max(20, originalSize.Height + deltaY)
                );
        }

        public void Stop()
        {
            isResizing = false;
        }
    }
}
