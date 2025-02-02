using CourseProject_ShowDesk.Scripts.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Forms.AdministratorForms
{
    public partial class AddEditSeatingForm : MetroFramework.Forms.MetroForm
    {
        private bool isResizing = false;
        private Point resizeStart;
        private Size originalSize;

        private List<Seat> seatList = new List<Seat>();
        private List<DecorativeElement> decorList = new List<DecorativeElement>();

        private bool isDragging = false;
        private Point dragStart;
        private Control selectedControl;
        private List<Control> selectedControls = new List<Control>();

        private bool isValid = false;

        public AddEditSeatingForm(Stage stage)
        {
            InitializeComponent();

            if(stage!=null)
            {
                seatList = stage.SeatList;
                decorList = stage.DecorList;

                PopulateSeating();
            }
        }

        private void PopulateSeating()
        {
            foreach(Seat seat in seatList)
            {
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach(DecorativeElement decor in decorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
        }

        private void AddSeat()
        {
            Seat seat = new Seat(seatList.Count+1, new Point(120, 50));
            seatList.Add(seat);
            panelSeating.Controls.Add(seat.ToLabel());
        }

        private void AddDecorativeElement()
        {
            DecorativeElement decor = new DecorativeElement(new Point(120, 50));
            decorList.Add(decor);
            panelSeating.Controls.Add(decor.ToPanel());
        }

        private void ChangeColor()
        {
            if (selectedControls.Any())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var control in selectedControls)
                    {

                        control.BackColor = colorDialog.Color;

                        int decorIndex = GetCurrentDecorIndex(control);

                        if (decorIndex != -1)
                        {
                            decorList[decorIndex].Color = colorDialog.Color;
                        }
                        
                        //else
                        //{
                        //    int seatIndex = GetCurrentSeatIndex(control);

                        //    if (seatIndex != -1)
                        //    {
                        //        seatList[seatIndex].Color = colorDialog.Color;
                        //    }
                        //}
                    }

                }
            }
        }

        private void SetUnavailable()
        {
            foreach (Control control in selectedControls.OfType<Label>().ToList())
            {
                int seatIndex= GetCurrentSeatIndex(control);

                if(seatIndex!=-1)
                {
                    seatList[seatIndex].IsAvailable = false;
                }
            }

            UpdateSeatNumbers();
        }

        private void DeleteSelectedSeat()
        {
            foreach (Control control in selectedControls.OfType<Label>().ToList())
            {
                int seatIndex=GetCurrentSeatIndex(control);

                if (seatIndex!=-1)
                {
                    seatList.RemoveAt(seatIndex);                
                }
            }

            UpdateSeatNumbers();
        }

        private void InsertSeat()
        {
            if (selectedControls.Count == 1 && selectedControls[0] is Label selectedLabel)
            {
                int seatIndex = GetCurrentSeatIndex(selectedLabel);

                if (seatIndex != -1)
                {
                    Seat selectedSeat = seatList[seatIndex];
                    Seat newSeat = new Seat(seatIndex + 2, new Point(selectedSeat.Location.X + 10, selectedSeat.Location.Y + 10));
                    seatList.Insert(seatIndex + 1, newSeat); 

                    UpdateSeatNumbers(); 
                }
            }

        }

        private void DeleteSelectedDecor()
        {
            foreach (Control control in selectedControls.OfType<Panel>().ToList())
            {
                int decorIndex = GetCurrentDecorIndex(control);

                if (decorIndex != -1)
                {
                    decorList.RemoveAt(decorIndex);
                    panelSeating.Controls.Remove(control);
                }
            }

        }

        private void UpdateSeatNumbers()
        {
            for (int i = 0; i < seatList.Count; i++)
            {
                seatList[i].SeatNumber = i + 1;
            }

            RepopulateSeating();

        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectedControl = null;

                foreach (Control control in panelSeating.Controls)
                {
                    if (control.Bounds.Contains(e.Location))
                    {
                        selectedControl = control;
                        break;
                    }
                }

                if (selectedControl != null && IsInResizeZone(selectedControl, e.Location))
                {
                    isResizing = true;
                    resizeStart = e.Location;
                    originalSize = selectedControl.Size;
                    return;
                }

                if (ModifierKeys == Keys.Control)
                {
                    if (selectedControl != null && !selectedControls.Contains(selectedControl))
                    {
                        selectedControls.Add(selectedControl);
                        selectedControl.BackColor = Color.Yellow; 
                    }
                }
                else
                {

                    foreach (Control control in selectedControls)
                    {
                        int decorIndex = GetCurrentDecorIndex(control);

                        if (decorIndex != -1)
                        {
                            control.BackColor = decorList[decorIndex].Color;
                        }

                        
                        else
                        {
                            int seatIndex = GetCurrentSeatIndex(control);

                            if (seatIndex != -1)
                            {
                                control.BackColor = seatList[seatIndex].CurrentZone.Color;
                            }
                            else
                            {
                                control.BackColor = Color.LightGray;
                            }
                        }
                    }

                    selectedControls.Clear();

                    if (selectedControl != null)
                    {
                        selectedControls.Add(selectedControl);
                        selectedControl.BackColor = Color.Yellow; 
                    }
                }

                if (selectedControl != null)
                {
                    isDragging = true;
                    dragStart = new Point(e.X - selectedControl.Left, e.Y - selectedControl.Top);
                }
            }

        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing && selectedControls.Any())
            {
                int deltaX = e.X - resizeStart.X;
                int deltaY = e.Y - resizeStart.Y;

                foreach (Control control in selectedControls)
                {
                    control.Size = new Size(
                        Math.Max(20, originalSize.Width + deltaX), 
                        Math.Max(20, originalSize.Height + deltaY)
                    );
                   
                    int seatIndex = GetCurrentSeatIndex(control);
                    if (seatIndex != -1)
                    {
                        seatList[seatIndex].Scale(control.Size); 
                    }
                    else
                    {
                        int decorIndex = GetCurrentDecorIndex(control);

                        if (decorIndex != -1)
                        {
                            decorList[decorIndex].Scale(control.Size); 
                        }
                    }
                    
                }

            }
            else if (isDragging && selectedControls.Any())
            {
                foreach (var control in selectedControls)
                {
                    int xMove = e.X - dragStart.X;
                    int yMove = e.Y - dragStart.Y;

                    if (xMove > 0 &&
                        yMove > 0 &&
                        xMove+control.Width  < panelSeating.Width &&
                        yMove+control.Height < panelSeating.Height)
                    {
                        control.Left = xMove;
                        control.Top = yMove;

                        int seatIndex = GetCurrentSeatIndex(control);

                        if(seatIndex!=-1)
                        {
                            seatList[seatIndex].Location = new Point(control.Left, control.Top);
                        }
                        else
                        {
                            int decorIndex = GetCurrentDecorIndex(control);

                            if(decorIndex!=-1)
                            {
                                decorList[decorIndex].Location = new Point(control.Left, control.Top);
                            }
                        }
                    }
                }
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            isResizing = false;
        }

        private bool IsInResizeZone(Control control, Point mouseLocation)
        {
            const int resizeMargin = 10;
            var controlBounds = control.Bounds;

            return mouseLocation.X >= controlBounds.Right - resizeMargin &&
                   mouseLocation.Y >= controlBounds.Bottom - resizeMargin;
        }

        private int GetCurrentSeatIndex(Control control)
        {

            if (control is Label label)
            {
                bool isInteger = int.TryParse(control.Text, out int result);

                if (isInteger)
                {
                    return result - 1;
                }
            }

            return -1;

        }

        private int GetCurrentDecorIndex(Control control)
        {
            if (control is Panel panel)
            {
                for (int i = 0; i < decorList.Count; i++)
                {
                    if (control.Name == decorList[i].DecorId.ToString())
                    {
                        return i;
                    }
                }

            }

            return -1;
        }

        private void RepopulateSeating()
        {
            List<Control> labelsToRemove = new List<Control>();

            foreach (Control control in panelSeating.Controls)
            {
                if (control is Label)
                {
                    labelsToRemove.Add(control);
                }
            }

            foreach (Control label in labelsToRemove)
            {
                panelSeating.Controls.Remove(label);
            }


            foreach (Seat seat in seatList)
            {
                panelSeating.Controls.Add(seat.ToLabel());
            }
        }

        private void buttonDeleteSeat_Click(object sender, EventArgs e)
        {
            DeleteSelectedSeat();
        }

        private void buttonAddSeat_Click(object sender, EventArgs e)
        {
            AddSeat();
        }

        private void buttonInsertSeat_Click(object sender, EventArgs e)
        {
            InsertSeat();
        }

        private void buttonSetUnavailable_Click(object sender, EventArgs e)
        {
            SetUnavailable();
        }

        private void buttonAddDecor_Click(object sender, EventArgs e)
        {
            AddDecorativeElement();
        }

        private void buttonDeleteDecor_Click(object sender, EventArgs e)
        {
            DeleteSelectedDecor();
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void panelSeating_MouseDown(object sender, MouseEventArgs e)
        {
            FormMouseDown(sender, e);
        }

        private void panelSeating_MouseMove(object sender, MouseEventArgs e)
        {
            FormMouseMove(sender, e);
        }

        private void panelSeating_MouseUp(object sender, MouseEventArgs e)
        {
            FormMouseUp(sender, e);
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(ValidateOfSeating())
            {
                isValid = true;

                this.Close();
            }
        }

        private bool ValidateOfSeating()
        {
            if(seatList.Count==0)
            {
                MessageBox.Show(
                                "There was an error in the seat of the stage: the stage must have at least one seat",
                                "Stage seating error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                buttonAddSeat.Focus();
                return false;
            }

            return true;
        }

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

    }
}

