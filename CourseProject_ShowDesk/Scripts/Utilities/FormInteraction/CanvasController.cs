using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class CanvasController
    {
        private readonly Panel panelSeating;
        private readonly Panel panelViewport;
        private float zoomFactor = 1.0f;
        private bool isPanning;
        private Point startLocation;

        private readonly ElementMover mover;
        private readonly ElementResizer resizer;

        public CanvasController(Panel panelSeating, Panel panelViewport)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
            mover = new ElementMover(panelSeating, panelViewport);
            resizer = new ElementResizer(panelSeating);
        }
        public ElementResizer Resizer
        {
            get
            {
                return resizer;
            }
        }
        public void StartScaleCanvas(MouseEventArgs e, bool useControl)
        {
            if (!useControl) return;

            float scaleFactor = e.Delta > 0 ? 1.05f : 0.95f;
            zoomFactor *= scaleFactor;
            ScaleCanvas(scaleFactor);
        }

        private void ScaleCanvas(float scaleFactor)
        {
            panelSeating.Scale(new SizeF(scaleFactor, scaleFactor));

            foreach (Control control in panelSeating.Controls)
            {
                control.Width = (int)(control.Width * scaleFactor);
                control.Height = (int)(control.Height * scaleFactor);

                control.Left = (int)(control.Left * scaleFactor);
                control.Top = (int)(control.Top * scaleFactor);
            }

            panelSeating.Left = (int)(panelSeating.Left * scaleFactor);
            panelSeating.Top = (int)(panelSeating.Top * scaleFactor);
        }

        public void StartPanning(MouseEventArgs e, bool useControl)
        {
            if (e.Button == MouseButtons.Middle || (e.Button == MouseButtons.Left && useControl))
            {
                isPanning = true;
                startLocation = e.Location;
                panelViewport.Cursor = Cursors.Hand;
            }
        }

        public void StopPanning()
        {
            isPanning = false;
            if (panelViewport != null) panelViewport.Cursor = Cursors.Default;
        }

        public void CanvasMove(Point location)
        {
            if (!isPanning) return;

            Point newLocation = new Point(panelSeating.Left + (location.X - startLocation.X), panelSeating.Top + (location.Y - startLocation.Y));
            if (newLocation.X <= 0 && newLocation.X + panelSeating.Width >= panelViewport.Width)
            {
                panelSeating.Left = newLocation.X;
            }
            if (newLocation.Y <= 0 && newLocation.Y + panelSeating.Height >= panelViewport.Height)
            {
                panelSeating.Top = newLocation.Y;
            }
        }

        public void StartResizing(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Control selectedControl = FindControlAtLocation(e.Location);
            if (selectedControl != null && resizer.IsInResizeZone(selectedControl, e.Location))
            {
                resizer.StartResizing(selectedControl, e.Location);
            }
        }

        public void StartDragging(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Control selectedControl = FindControlAtLocation(e.Location);
            if (selectedControl != null && !resizer.IsInResizeZone(selectedControl, e.Location))
            {
                mover.StartDragging(selectedControl, e.Location);
            }
        }

        public void ElementMove(MouseEventArgs e)
        {
            mover.Move(e.Location);
        }

        public void ElementResize(MouseEventArgs e)
        {
            resizer.Resize(e.Location);
        }

        public void MoveStop()
        {
            mover.Stop();
        }

        public void ResizeStop()
        {
            resizer.Stop();
        }

        public Control FindControlAtLocation(Point location)
        {
            return panelSeating.Controls.Cast<Control>().FirstOrDefault(c => c.Bounds.Contains(location));
        }
    }
}
