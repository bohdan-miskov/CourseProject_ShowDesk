using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class CanvasController
    {
        private Panel panelSeating;
        private Panel panelViewport;
        private float zoomFactor = 1.0f;
        private Point startLocation;
        private bool isPanning;

        public CanvasController(Panel panelSeating, Panel panelViewport)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
        }

        public void HandleMouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys != Keys.Control) return;

            float scaleFactor = e.Delta > 0 ? 1.1f : 0.9f;
            zoomFactor *= scaleFactor;

            panelSeating.Scale(new SizeF(scaleFactor, scaleFactor));

            foreach (Control control in panelSeating.Controls)
            {
                control.Scale(new SizeF(scaleFactor, scaleFactor));
                control.Location = new Point((int)(control.Location.X * scaleFactor),
                    (int)(control.Location.Y * scaleFactor));
            }

            panelSeating.Location = new Point((int)(panelSeating.Location.X / scaleFactor),
                (int)(panelSeating.Location.Y / scaleFactor));
        }

        public void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle || (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control))
            {
                startLocation = e.Location;
                isPanning = true;
                panelViewport.Cursor = Cursors.Hand;
            }
        }

        public void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (isPanning)
            {
                Point newLocation = new Point(panelSeating.Left + (e.X - startLocation.X), panelSeating.Top + (e.Y - startLocation.Y));
                if (newLocation.X <= 0 && newLocation.X + panelSeating.Width >= panelViewport.Width)
                {
                    panelSeating.Left = newLocation.X;
                }
                if (newLocation.Y <= 0 && newLocation.Y + panelSeating.Height >= panelViewport.Height)
                {
                    panelSeating.Top = newLocation.Y;
                }
            }
        }

        public void HandleMouseUp(object sender, MouseEventArgs e)
        {
            isPanning = false;
            panelViewport.Cursor = Cursors.Default;
        }
    }
}
