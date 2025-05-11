using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class ElementsMover
    {
        private readonly Panel panelSeating;
        private readonly Panel panelViewport;
        private List<Control> selectedControls;
        private List<Point> dragOffsetList;
        private bool isDragging;

        public ElementsMover(Panel panelSeating, Panel panelViewport)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
            selectedControls = new List<Control>();
            dragOffsetList = new List<Point>();
        }

        public void StartDragging(List<Control> controls, Point location)
        {
            if (controls.Count == 0) return;
            selectedControls = new List<Control>(controls);
            isDragging = true;
            dragOffsetList.Clear();
            foreach (Control control in selectedControls)
            {
                dragOffsetList.Add(new Point(location.X - control.Left, location.Y - control.Top));
            }
        }

        public void Move(Point location)
        {
            if (!isDragging || selectedControls.Count == 0) return;

            for (int i = 0; i < selectedControls.Count; i++)
            {
                selectedControls[i].Location = new Point(
               location.X - dragOffsetList[i].X,
               location.Y - dragOffsetList[i].Y
               );
            }
        }

        public void Stop()
        {
            isDragging = false;
            selectedControls.Clear();
            dragOffsetList.Clear();
            if (panelViewport != null) panelViewport.Cursor = Cursors.Default;
        }
    }
}
