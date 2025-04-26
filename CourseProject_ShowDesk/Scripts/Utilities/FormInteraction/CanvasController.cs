using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.FormInteraction
{
    public class CanvasController
    {
        //private const int MinControlSize= 20;

        private readonly Panel panelSeating;
        private readonly Panel panelViewport;
        private float zoomFactor = 1.0f;
        private bool isPanning;
        private Point startLocation;

        private readonly ElementsMover mover;
        private readonly ElementsResizer resizer;

        public CanvasController(Panel panelSeating, Panel panelViewport)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
            mover = new ElementsMover(panelSeating, panelViewport);
            resizer = new ElementsResizer(panelSeating);
        }
        public CanvasController(Panel panelSeating, Panel panelViewport, Point location,Size size)
        {
            this.panelSeating = panelSeating;
            this.panelViewport = panelViewport;
            //this.zoomFactor = zoomFactor;
            //ScaleCanvas(zoomFactor);
            panelSeating.Size = size;
            panelSeating.Location = location;
            mover = new ElementsMover(panelSeating, panelViewport);
            resizer = new ElementsResizer(panelSeating);
        }
        public ElementsResizer Resizer
        {
            get
            {
                return resizer;
            }
        }
        public float ZoomFactor
        {
            get
            {
                return zoomFactor;
            }
        }
        public void StartScaleCanvas(MouseEventArgs e, bool useControl)
        {
            if (!useControl) return;

            float scaleFactor = e.Delta > 0 ? 1.05f : 0.95f;

            if(!CheckOfAvailableMinSize(scaleFactor)) return;

            zoomFactor *= scaleFactor;
            ScaleCanvas(scaleFactor);
        }

        private bool CheckOfAvailableMinSize(float scaleFactor)
        {
            foreach (Control control in panelSeating.Controls)
            {
                int newWidth = (int)(control.Width * scaleFactor);
                int newHeight = (int)(control.Height * scaleFactor);
                if (
                    ((newWidth < control.MinimumSize.Width || newHeight < control.MinimumSize.Height) && scaleFactor<1)
                    )
                    return false;
            }
            return true;
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

        public void StartResizing(List<Control> selectedControls,MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            //Control selectedControl = FindControlAtLocation(e.Location);
            if (selectedControls.Count != 0 && selectedControls.Any(control => resizer.IsInResizeZone(control, e.Location)))
            {
                resizer.StartResizing(selectedControls, e.Location);
            }
        }

        public void StartDragging(List<Control> selectedControls, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Control selectedControl = FindControlAtLocation(e.Location);
            if (selectedControl != null && !resizer.IsInResizeZone(selectedControl, e.Location))
            {
                mover.StartDragging(selectedControls, e.Location);
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
