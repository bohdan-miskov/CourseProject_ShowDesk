using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.FormInteraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditSeatingForm : MetroFramework.Forms.MetroForm
    {
        private bool logOut;
        private bool isValid;
        private Point canvasLocation;
        private Size canvasSize;
        private Point lastMousePos;

        private readonly SeatingManager seatingManager;
        private readonly CanvasController canvasController;
        private readonly SelectionManager selectionManager;

        public AddEditSeatingForm(Employee userAccount, Stage stage = null)
        {
            InitializeComponent();
            FormConfigurator.ConfigureForm(this);

            this.MouseWheel += PanelSeating_MouseWheel;


            labelAccountName.Text = userAccount.FullName;

            selectionManager = new SelectionManager();
            seatingManager = new SeatingManager(panelSeating, stage?.SeatList, stage?.DecorList, colorDialog, selectionManager.SelectedControls);

            seatingManager.PopulateSeating();

            if (stage != null)
            {
                Seat lastSeat = seatingManager.SeatList[seatingManager.SeatList.Count - 1];
                canvasController = new CanvasController(panelSeating, panelViewport, stage.StageLocation, stage.StageSize);
                lastMousePos = new Point(lastSeat.Location.X, lastSeat.Location.Y);
            }
            else
            {
                canvasController = new CanvasController(panelSeating, panelViewport);
                lastMousePos = GetCanvasCenter();
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
        private Point GetCanvasCenter()
        {
            Point viewportCenter = new Point(panelViewport.Width / 2, panelViewport.Height / 2);

            return panelSeating.PointToClient(panelViewport.PointToScreen(viewportCenter));
        }

        private void CanvasMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            else lastMousePos = e.Location;

            bool useControl = ModifierKeys == Keys.Control;
            HandleSelection(e, useControl);
            canvasController.StartPanning(e, useControl);
            canvasController.StartDragging(selectionManager.SelectedControls, e);
            canvasController.StartResizing(selectionManager.SelectedControls, e);
        }
        private void CanvasMouseUp()
        {
            canvasController.StopPanning();
            canvasController.MoveStop();
            canvasController.ResizeStop();
            seatingManager.UpdateComponents();
        }
        private void CanvasMouseMove(MouseEventArgs e)
        {
            canvasController.CanvasMove(e.Location);
            canvasController.ElementMove(e);
            canvasController.ElementResize(e);
        }
        public void HandleSelection(MouseEventArgs e, bool useControl)
        {
            if (e.Button != MouseButtons.Left)
                return;

            Control selectedControl = canvasController.FindControlAtLocation(e.Location);
            if (selectedControl == null || canvasController.Resizer.IsInResizeZone(selectedControl, e.Location))
                return;

            if (useControl) selectionManager.AddToSelection(selectedControl);
            else
            {
                for (int i = selectionManager.SelectedControls.Count - 1; i >= 0; i--)
                {
                    Control control = selectionManager.SelectedControls[i];
                    Color initColor = AppConstants.SeatBaseColor;

                    if (control is Label)
                        initColor = seatingManager.GetSeatColorByControl(control);
                    else if (control is Panel)
                        initColor = seatingManager.GetDecorColorByControl(control);

                    selectionManager.RemoveSelection(control, initColor);
                }
                selectionManager.AddToSelection(selectedControl);
            }
        }
        private void Save()
        {
            if (ValidateOfSeating())
            {
                isValid = true;
                canvasLocation = new Point(panelSeating.Left, panelSeating.Top);
                canvasSize = panelSeating.Size;

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

        public Point GetCanvasLocation()
        {
            return canvasLocation;
        }
        public Size GetCanvasSize()
        {
            return canvasSize;
        }

        private void PanelSeating_MouseWheel(object sender, MouseEventArgs e)
        {
            bool useControl = ModifierKeys == Keys.Control;
            canvasController.StartScaleCanvas(e, useControl);
        }
    }
}

