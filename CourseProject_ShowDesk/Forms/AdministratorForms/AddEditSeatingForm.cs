using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;

//using System.Web.UI;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditSeatingForm : MetroFramework.Forms.MetroForm
    {
        private float zoomFactor = 1.0f;
        private bool isResizing = false;
        private Point resizeStart;
        private Size originalSize;
        private bool isDragging = false;
        private Point startLocation; 
        private Point dragStart;
        private List<Control> selectedControls = new List<Control>();
        private bool isValid = false;
        private List<Seat> seatList = new List<Seat>();
        private List<DecorativeElement> decorList = new List<DecorativeElement>();
        private bool isPanning = false;
        private Point lastMousePos;
        //private Point lastMouseLeftPos;

        //private Point panStartPoint;
        //private Point panStartPointLast;


        private SeatingManager seatingManager;
        private CanvasController canvasController;
        private SelectionManager selectionManager;


        public AddEditSeatingForm(Employee userAccount,Stage stage=null)
        {
            InitializeComponent();

            this.MouseWheel += PanelSeating_MouseWheel;

            lastMousePos = new Point(100, 100);

            labelAccountName.Text = userAccount.FullName;

            if (stage!=null)
            {
                //seatList = stage.SeatList;
                //decorList = stage.DecorList;

                //PopulateSeating();

                Seat lastSeat = seatList[seatList.Count - 1];

                //panelViewport.AutoScrollPosition = new Point(lastSeat.Location.X, lastSeat.Location.Y);
            }

            seatingManager = new SeatingManager(panelSeating, colorDialog, stage?.SeatList,stage?.DecorList);
            canvasController = new CanvasController(panelSeating, panelViewport);
            selectionManager = new SelectionManager();

            seatingManager.PopulateSeating();
        }

        private void ButtonDeleteSeat_Click(object sender, EventArgs e)
        {
            seatingManager.DeleteSelectedSeat();
        }

        private void ButtonAddSeat_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonInsertSeat_Click(object sender, EventArgs e)
        {
            InsertSeat();
        }

        private void ButtonSetUnavailable_Click(object sender, EventArgs e)
        {
            SetUnavailable();
        }

        private void ButtonAddDecor_Click(object sender, EventArgs e)
        {
            AddDecorativeElement();
        }

        private void ButtonDeleteDecor_Click(object sender, EventArgs e)
        {
            DeleteSelectedDecor();
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void PanelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMousePos = e.Location;
            }

            
            //FormMouseDown(sender, e);
            ViewportMouseDown(sender, e);
        }

        private void PanelSeating_MouseMove(object sender, MouseEventArgs e)
        {
            FormMouseMove(sender, e);
            ViewportMouseMove(sender, e);
        }

        private void PanelSeating_MouseUp(object sender, MouseEventArgs e)
        {
            FormMouseUp();
            ViewportMouseUp(sender, e);
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ValidateOfSeating())
            {
                isValid = true;

                this.Close();
            }
        }

        //private void PopulateSeating()
        //{
        //    foreach(Seat seat in seatList)
        //    {
        //        panelSeating.Controls.Add(seat.ToLabel());
        //    }
        //    foreach(DecorativeElement decor in decorList)
        //    {
        //        panelSeating.Controls.Add(decor.ToPanel());
        //    }
        //}

        //private void AddSeat()
        //{
        //    Seat seat = new Seat(seatList.Count+1, new Point(lastMousePos.X, lastMousePos.Y));
        //    seatList.Add(seat);
        //    panelSeating.Controls.Add(seat.ToLabel());
        //}

        //private void AddDecorativeElement()
        //{
        //    DecorativeElement decor = new DecorativeElement(new Point(120, 50));
        //    decorList.Add(decor);
        //    panelSeating.Controls.Add(decor.ToPanel());
        //}

        //private void ChangeColor()
        //{
        //    if (!selectedControls.Any()) return;
        //    if (colorDialog.ShowDialog() != DialogResult.OK) return;

        //    foreach (var control in selectedControls)
        //    {
        //        control.BackColor = colorDialog.Color;
        //        int decorIndex = GetCurrentDecorIndex(control);
        //        if (decorIndex != -1) decorList[decorIndex].SetColor(colorDialog.Color);
        //    }
        //}

        //private void SetUnavailable()
        //{
        //    foreach (Control control in selectedControls.OfType<Label>())
        //    {
        //        int seatIndex = GetCurrentSeatIndex(control);
        //        if (seatIndex != -1) seatList[seatIndex].IsAvailable = false;
        //    }
        //    UpdateSeatNumbers();
        //}

        //private void DeleteSelectedSeat()
        //{
        //    foreach (Control control in selectedControls.OfType<Label>().ToList())
        //    {
        //        int seatIndex=GetCurrentSeatIndex(control);

        //        if (seatIndex!=-1) seatList.RemoveAt(seatIndex);                
        //    }
        //    UpdateSeatNumbers();
        //}

        //private void InsertSeat()
        //{
        //    if (selectedControls.Count != 1 || !(selectedControls[0] is Label selectedLabel)) return;
        //    int seatIndex = GetCurrentSeatIndex(selectedLabel);
        //    if (seatIndex == -1) return;

        //    Seat newSeat = new Seat(seatIndex + 2, new Point(selectedLabel.Location.X + 10, selectedLabel.Location.Y + 10));
        //    seatList.Insert(seatIndex + 1, newSeat);
        //    UpdateSeatNumbers();
        //}

        //private void DeleteSelectedDecor()
        //{
        //    foreach (Control control in selectedControls.OfType<Panel>().ToList())
        //    {
        //        int decorIndex = GetCurrentDecorIndex(control);
        //        if (decorIndex == -1) continue;
        //        decorList.RemoveAt(decorIndex);
        //        panelSeating.Controls.Remove(control);
        //    }

        //}

        //private void UpdateSeatNumbers()
        //{
        //    for (int i = 0; i < seatList.Count; i++)
        //    {
        //        seatList[i].SeatNumber = i + 1;
        //    }

        //    RepopulateSeating();

        //}

        //private void FormMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button != MouseButtons.Left) return;

        //    lastMousePos = e.Location;

        //    Control selectedControl = FindControlAtLocation(e.Location);

        //    if (selectedControl != null && IsInResizeZone(selectedControl, e.Location))
        //    {
        //        isResizing = true;
        //        resizeStart = e.Location;
        //        originalSize = selectedControl.Size;
        //        return;
        //    }

        //    if (ModifierKeys == Keys.Control)
        //    {
        //        AddToSelection(selectedControl);
        //    }
        //    else
        //    {
        //        ClearSelection();
        //        SetSelection(selectedControl);
        //    }

        //    if (selectedControl != null)
        //    {
        //        isDragging = true;
        //        dragStart = new Point(e.Location.X - selectedControl.Left, e.Location.Y - selectedControl.Top);
        //    }
        //}

        //private void FormMouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isResizing)
        //    {
        //        ResizeSelectedControls(e.Location);
        //    }
        //    else if (isDragging)
        //    {
        //        MoveSelectedControls(e.Location);
        //    }
        //}

        //private void FormMouseUp()
        //{
        //    StopDraggingOrResizing();
        //}

        //private Control FindControlAtLocation(Point location)
        //{
        //    return panelSeating.Controls.Cast<Control>().FirstOrDefault(c => c.Bounds.Contains(location));
        //}

        //private void AddToSelection(Control control)
        //{
        //    if (control != null && !selectedControls.Contains(control))
        //    {
        //        selectedControls.Add(control);
        //        control.BackColor = Color.Yellow;
        //    }
        //}

        //private void ClearSelection()
        //{
        //    foreach (var control in selectedControls)
        //    {
        //        control.BackColor = GetOriginalColor(control);
        //    }
        //    selectedControls.Clear();
        //}

        //private void SetSelection(Control control)
        //{
        //    if (control == null) return;
        //    selectedControls.Add(control);
        //    control.BackColor = Color.Yellow;
        //}

        //private void StopDraggingOrResizing()
        //{
        //    isDragging = false;
        //    isResizing = false;
        //}

        //private void ResizeSelectedControls(Point location)
        //{
        //    int deltaX = location.X - resizeStart.X;
        //    int deltaY = location.Y - resizeStart.Y;

        //    foreach (var control in selectedControls)
        //    {
        //        control.Size = new Size(
        //            Math.Max(20, originalSize.Width + deltaX),
        //            Math.Max(20, originalSize.Height + deltaY)
        //        );
        //        ScaleControl(control);
        //    }
        //}

        //private void MoveSelectedControls(Point location)
        //{
        //    foreach (var control in selectedControls)
        //    {
        //        int xMove = location.X - dragStart.X;
        //        int yMove = location.Y - dragStart.Y;

        //        if (IsWithinBounds(xMove, yMove, control))
        //        {
        //            control.Location = new Point(xMove, yMove);
        //            UpdateControlLocation(control);
        //        }
        //    }
        //}

        //private bool IsWithinBounds(int x, int y, Control control)
        //{
        //    return x > 0 && y > 0 && x + control.Width < panelSeating.Width && y + control.Height < panelSeating.Height;
        //}

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

        //private bool ValidateOfSeating()
        //{
        //    if (seatList.Count > 0) return true;

        //    MessageBox.Show("The stage must have at least one seat", "Stage seating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    buttonAddSeat.Focus();
        //    return false;
        //}

        public bool GetIsValid()
        {
            return isValid;
        }

        public List<Seat> GetSeatList()
        {
            return seatList;
        }

        public List<DecorativeElement> GetDecorList()
        {
            return decorList;
        }
        

        private void PanelSeating_MouseWheel(object sender, MouseEventArgs e)
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

            panelSeating.Location=new Point((int)(panelSeating.Location.X/scaleFactor),
                (int)(panelSeating.Location.Y/scaleFactor));
        }

        private void panelViewport_MouseDown(object sender, MouseEventArgs e)
        {
            ViewportMouseDown(sender, e);
        }
        private void ViewportMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle || (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control))
            {
                startLocation = e.Location; ;
                isPanning = true;
                panelViewport.Cursor = Cursors.Hand;
            }
        }
        private void ViewportMouseMove(object sender, MouseEventArgs e)
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
        private void ViewportMouseUp(object sender, MouseEventArgs e)
        {
            isPanning = false;
            panelViewport.Cursor = Cursors.Default;
        }

        private void panelViewport_MouseMove(object sender, MouseEventArgs e)
        {
            ViewportMouseMove(sender, e);
        }

        private void panelViewport_MouseUp(object sender, MouseEventArgs e)
        {
            ViewportMouseUp(sender, e);
        }


    }
}

