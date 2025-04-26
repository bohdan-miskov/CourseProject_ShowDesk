using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class ElementsResizer
    {
        private readonly Panel panelSeating;
        private List<Control> resizingControls;
        private Point resizeStart;
        private List<Size> originalSizes;
        private bool isResizing;

        public ElementsResizer(Panel panelSeating)
        {
            this.panelSeating = panelSeating;
            resizingControls=new List<Control>();
            originalSizes=new List<Size>();
        }

        public bool IsInResizeZone(Control control, Point mouseLocation)
        {
            const int resizeMargin = 10;
            return mouseLocation.X >= control.Right - resizeMargin && 
                mouseLocation.Y >= control.Bottom - resizeMargin;
        }

        public void StartResizing(List<Control> controls, Point location)
        {
            resizingControls = new List<Control>(controls); 
            isResizing = true;
            resizeStart = location;
            originalSizes.Clear();

            foreach (Control control in resizingControls)
            {    
                originalSizes.Add(control.Size);
            }
        }

        public void Resize(Point location)
        {
            if (!isResizing || resizingControls.Count == 0) return;

            int deltaX = location.X - resizeStart.X;
            int deltaY = location.Y - resizeStart.Y;
            for(int i=0; i<resizingControls.Count; i++)
            {
                resizingControls[i].Size = new Size(
                    originalSizes[i].Width + deltaX, 
                    originalSizes[i].Height + deltaY
                    );
            }
        }

        public void Stop()
        {
            isResizing = false;
            resizingControls.Clear();
            originalSizes.Clear();
        }
    }
}
