using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Collections.Generic;
using System.Drawing;

//using System.Web.UI;

//using System.Web.UI;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditSeatingForm : MetroFramework.Forms.MetroForm
    {
        //private float zoomFactor = 1.0f;
        //private bool isResizing = false;
        //private Point resizeStart;
        //private Size originalSize;
        //private bool isDragging = false;
        //private Point startLocation;
        //private Point dragStart;
        //private List<Control> selectedControls = new List<Control>();
        private bool logOut;
        private bool isValid;
        //private List<Seat> seatList = new List<Seat>();
        //private List<DecorativeElement> decorList = new List<DecorativeElement>();
        //private bool isPanning = false;
        private Point lastMousePos;
        //private Point lastMouseLeftPos;

        //private Point panStartPoint;
        //private Point panStartPointLast;


        private readonly SeatingManager seatingManager;
        private readonly CanvasController canvasController;
        private readonly SelectionManager selectionManager;


        public AddEditSeatingForm(Employee userAccount, Stage stage = null)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this, true);

            this.MouseWheel += PanelSeating_MouseWheel;

            lastMousePos = new Point(100, 100);

            labelAccountName.Text = userAccount.FullName;

            seatingManager = new SeatingManager(panelSeating, stage?.SeatList, stage?.DecorList, colorDialog);
            canvasController = new CanvasController(panelSeating, panelViewport);
            selectionManager = new SelectionManager();

            seatingManager.PopulateSeating();

            if (stage != null)
            {
                //seatList = stage.SeatList;
                //decorList = stage.DecorList;

                //PopulateSeating();

                Seat lastSeat = seatingManager.SeatList[seatingManager.SeatList.Count - 1];

                panelViewport.AutoScrollPosition = new Point(lastSeat.Location.X, lastSeat.Location.Y);
            }

            isValid = false;
            logOut = false;
        }

        private void ButtonDeleteSeat_Click(object sender, EventArgs e)
        {
            seatingManager.DeleteSelectedSeat();
        }

        private void ButtonAddSeat_Click(object sender, EventArgs e)
        {
            seatingManager.AddSeat(lastMousePos);
        }

        private void ButtonInsertSeat_Click(object sender, EventArgs e)
        {
            seatingManager.InsertSeat();
        }

        private void ButtonSetUnavailable_Click(object sender, EventArgs e)
        {
            seatingManager.SetUnavailable();
        }

        private void ButtonAddDecor_Click(object sender, EventArgs e)
        {
            seatingManager.AddDecorativeElement(lastMousePos);
        }

        private void ButtonDeleteDecor_Click(object sender, EventArgs e)
        {
            seatingManager.DeleteSelectedDecor();
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            seatingManager.ChangeColor();
        }
        private void PanelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            CanvasMouseDown(e);
        }


        private void PanelSeating_MouseMove(object sender, MouseEventArgs e)
        {
            CanvasMouseMove(e);
        }

        private void PanelSeating_MouseUp(object sender, MouseEventArgs e)
        {
            CanvasMouseUp();
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void CanvasMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            else lastMousePos = e.Location;

            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartPanning(e, useControl);
            canvasController.StartDragging(e);
            canvasController.StartResizing(e);
            HandleSelection(e, useControl);


            //FormMouseDown(sender, e);
            //ViewportMouseDown(sender, e);
        }
        private void CanvasMouseUp()
        {
            canvasController.StopPanning();
            canvasController.MoveStop();
            canvasController.ResizeStop();
            //ViewportMouseUp(sender, e);
        }
        private void CanvasMouseMove(MouseEventArgs e)
        {
            canvasController.CanvasMove(e.Location);
            canvasController.ElementMove(e);
            canvasController.ElementResize(e);
            //FormMouseMove(sender, e);
            //ViewportMouseMove(sender, e);
        }
        public void HandleSelection(MouseEventArgs e, bool useControl)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control selectedControl = canvasController.FindControlAtLocation(e.Location);
                if (selectedControl != null && !canvasController.Resizer.IsInResizeZone(selectedControl, e.Location))
                {
                    if (useControl) selectionManager.AddToSelection(selectedControl);
                    else
                    {
                        foreach (Control control in selectionManager.SelectedControls)
                        {
                            Color initColor = seatingManager.GetSeatColorByControl(control);
                            selectionManager.RemoveSelection(control, initColor);
                        }
                        selectionManager.AddToSelection(selectedControl);
                    }
                }
            }
        }
        private void Save()
        {
            if (ValidateOfSeating())
            {
                isValid = true;

                this.Close();
            }
        }
        private bool ValidateOfSeating()
        {
            if (seatingManager.SeatList.Count > 0) return true;

            MessageBox.Show("The stage must have at least one seat", "Stage seating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            buttonAddSeat.Focus();
            return false;
        }
        //private void ScaleControl(Control control)
        //{
        //    int seatIndex = GetCurrentSeatIndex(control);
        //    if (seatIndex != -1) seatList[seatIndex].Scale(control.Size);
        //    else ScaleDecor(control);
        //}

        //private void ScaleDecor(Control control)
        //{
        //    int decorIndex = GetCurrentDecorIndex(control);
        //    if (decorIndex != -1) decorList[decorIndex].Scale(control.Size);
        //}

        //private void UpdateControlLocation(Control control)
        //{
        //    int seatIndex = GetCurrentSeatIndex(control);
        //    if (seatIndex != -1) seatList[seatIndex].Location = control.Location;
        //    else UpdateDecorLocation(control);
        //}

        //private void UpdateDecorLocation(Control control)
        //{
        //    int decorIndex = GetCurrentDecorIndex(control);
        //    if (decorIndex != -1) decorList[decorIndex].Location = control.Location;
        //}

        //private Color GetOriginalColor(Control control)
        //{
        //    int decorIndex = GetCurrentDecorIndex(control);
        //    if (decorIndex != -1) return decorList[decorIndex].GetColor();

        //    int seatIndex = GetCurrentSeatIndex(control);
        //    return seatIndex != -1 ? (seatList[seatIndex].CurrentZone ?? new Zone()).GetColor() : Color.LightGray;
        //}
        //private bool IsInResizeZone(Control control, Point mouseLocation)
        //{
        //    const int resizeMargin = 10;
        //    return IsPointInResizeMargin(control.Bounds, mouseLocation, resizeMargin);
        //}

        //private bool IsPointInResizeMargin(Rectangle bounds, Point point, int margin)
        //{
        //    return point.X >= bounds.Right - margin && point.Y >= bounds.Bottom - margin;
        //}

        //private int GetCurrentSeatIndex(Control control)
        //{
        //    return control is Label && int.TryParse(control.Text, out int result) ? result - 1 : -1;
        //}

        //private int GetCurrentDecorIndex(Control control)
        //{
        //    if (control is Panel panel)
        //    {
        //        return decorList.FindIndex(decor => panel.Name == decor.Id.ToString());
        //    }
        //    return -1;
        //}

        //private void RepopulateSeating()
        //{
        //    var labelsToRemove = panelSeating.Controls.OfType<Label>().ToList();
        //    foreach (var label in labelsToRemove)
        //    {
        //        panelSeating.Controls.Remove(label);
        //    }

        //    foreach (Seat seat in seatList)
        //    {
        //        panelSeating.Controls.Add(seat.ToLabel());
        //    }
        //}

        private void LogOut()
        {
            logOut = true;
            this.Close();
        }

        public bool GetLogOut()
        {
            return logOut;
        }
        public bool GetIsValid()
        {
            return isValid;
        }

        public List<Seat> GetSeatList()
        {
            return seatingManager.SeatList;
        }

        public List<DecorativeElement> GetDecorList()
        {
            return seatingManager.DecorList;
        }


        private void PanelSeating_MouseWheel(object sender, MouseEventArgs e)
        {
            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartScaleCanvas(e, useControl);
            //if (ModifierKeys != Keys.Control) return;

            //float scaleFactor = e.Delta > 0 ? 1.1f : 0.9f;
            //zoomFactor *= scaleFactor;

            //panelSeating.Scale(new SizeF(scaleFactor, scaleFactor));

            //foreach (Control control in panelSeating.Controls)
            //{
            //    control.Scale(new SizeF(scaleFactor, scaleFactor));
            //    control.Location = new Point((int)(control.Location.X * scaleFactor),
            //        (int)(control.Location.Y * scaleFactor));
            //}

            //panelSeating.Location=new Point((int)(panelSeating.Location.X/scaleFactor),
            //    (int)(panelSeating.Location.Y/scaleFactor));
        }

        private void panelViewport_MouseDown(object sender, MouseEventArgs e)
        {
            //ViewportMouseDown(sender, e);
        }
        //private void ViewportMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Middle || (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control))
        //    {
        //        startLocation = e.Location; ;
        //        isPanning = true;
        //        panelViewport.Cursor = Cursors.Hand;
        //    }
        //}
        //private void ViewportMouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isPanning)
        //    {
        //        Point newLocation = new Point(panelSeating.Left + (e.X - startLocation.X), panelSeating.Top + (e.Y - startLocation.Y));
        //        if (newLocation.X <= 0 && newLocation.X + panelSeating.Width >= panelViewport.Width)
        //        {
        //            panelSeating.Left = newLocation.X;
        //        }
        //        if (newLocation.Y <= 0 && newLocation.Y + panelSeating.Height >= panelViewport.Height)
        //        {
        //            panelSeating.Top = newLocation.Y;
        //        }
        //    }
        //}
        //private void ViewportMouseUp(object sender, MouseEventArgs e)
        //{
        //    isPanning = false;
        //    panelViewport.Cursor = Cursors.Default;
        //}

        private void panelViewport_MouseMove(object sender, MouseEventArgs e)
        {
            //ViewportMouseMove(sender, e);
        }

        private void panelViewport_MouseUp(object sender, MouseEventArgs e)
        {
            //ViewportMouseUp(sender, e);
        }
    }
}

