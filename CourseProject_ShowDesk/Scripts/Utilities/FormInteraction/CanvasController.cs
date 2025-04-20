using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //public void HandleMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Middle || (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control))
        //    {
        //        mover.StartPanning(e.Location, panelViewport);
        //    }
        //    else if (e.Button == MouseButtons.Left)
        //    {
        //        Control selectedControl = FindControlAtLocation(e.Location);

        //        if (selectedControl != null && resizer.IsInResizeZone(selectedControl, e.Location))
        //        {
        //            resizer.StartResizing(selectedControl, e.Location);
        //        }
        //        else
        //        {
        //            if (ModifierKeys == Keys.Control)
        //            {
        //                selectionManager.AddToSelection(selectedControl);
        //            }
        //            else
        //            {
        //                selectionManager.SetSelection(selectedControl);
        //            }
        //            mover.StartDragging(selectedControl, e.Location);
        //        }
        //    }
        //}
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
            if (isPanning)
            {
                Point newLocation = new Point(panelSeating.Left + (location.X - startLocation.X), panelSeating.Top + (location.Y - startLocation.Y));
                if (newLocation.X <= 0 && newLocation.X + panelSeating.Width >= panelViewport.Width)
                {
                    panelSeating.Left = newLocation.X;
                }
                if (newLocation.Y <= 0 && newLocation.Y + panelSeating.Height >= panelViewport.Height)
                {
                    panelSeating.Top = newLocation.Y;
                }
                //panelSeating.Left += location.X - startLocation.X;
                //panelSeating.Top += location.Y - startLocation.Y;
            }
        }

        public void StartResizing(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control selectedControl = FindControlAtLocation(e.Location);
                if (selectedControl != null && resizer.IsInResizeZone(selectedControl, e.Location))
                {
                    resizer.StartResizing(selectedControl, e.Location);
                }
            }
        }

        public void StartDragging(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control selectedControl = FindControlAtLocation(e.Location);
                if (selectedControl != null && !resizer.IsInResizeZone(selectedControl, e.Location))
                {
                    mover.StartDragging(selectedControl, e.Location);
                }
            }
        }

        //public void HandleSelectionAndDragging(MouseEventArgs e, bool useControl)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        Control selectedControl = FindControlAtLocation(e.Location);
        //        if (selectedControl != null && !resizer.IsInResizeZone(selectedControl, e.Location))
        //        {
        //            if (ModifierKeys == Keys.Control)
        //            {
        //                selectionManager.AddToSelection(selectedControl);
        //            }
        //            else
        //            {
        //                selectionManager.SetSelection(selectedControl);
        //            }

        //            mover.StartDragging(selectedControl, e.Location);
        //        }
        //    }
        //}

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
                selectedControl.Location = new Point(location.X - dragOffset.X, location.Y - dragOffset.Y);
            }
        }

        public void Stop()
        {
            isDragging = false;
            if (panelViewport != null) panelViewport.Cursor = Cursors.Default;
        }
    }

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
            return mouseLocation.X >= control.Right - resizeMargin && mouseLocation.Y >= control.Bottom - resizeMargin;
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
            resizingControl.Size = new Size(Math.Max(20, originalSize.Width + deltaX), Math.Max(20, originalSize.Height + deltaY));
        }

        public void Stop()
        {
            isResizing = false;
        }
    }

}
