using CourseProject_ShowDesk.Scripts.Constants;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class SeatingManager
    {
        private Panel panelSeating;
        private List<Seat> seatList;
        private List<DecorativeElement> decorList;
        private List<Control> selectedControls;
        private ColorDialog colorDialog;

        public SeatingManager(Panel seatingPanel, List<Seat> seatList = null, List<DecorativeElement> decorList = null, ColorDialog colorDialog = null, List<Control> selectedControls=null)
        {
            this.panelSeating = seatingPanel;
            this.colorDialog = colorDialog;
            this.seatList = seatList ?? new List<Seat>();
            this.decorList = decorList ?? new List<DecorativeElement>();
            this.selectedControls = selectedControls;
        }

        public List<Seat> SeatList
        {
            get
            {
                return seatList;
            }
        }
        public List<DecorativeElement> DecorList
        {
            get
            {
                return decorList;
            }
        }

        public void PopulateSeating()
        {
            panelSeating.Controls.Clear();
            foreach (Seat seat in seatList)
            {
                panelSeating.Controls.Add(seat.ToLabel());
            }
            foreach (DecorativeElement decor in decorList)
            {
                panelSeating.Controls.Add(decor.ToPanel());
            }
        }

        public void AddSeat(Point location)
        {
            Seat seat = new Seat(seatList.Count + 1, location);

            if (selectedControls.Count > 0 && (selectedControls[selectedControls.Count - 1] is Label selectedLabel))
                seat.Size = selectedLabel.Size;
            
            seatList.Add(seat);
            panelSeating.Controls.Add(seat.ToLabel());
        }

        public void AddDecorativeElement(Point location)
        {
            DecorativeElement decor = new DecorativeElement(location);
            
            if (selectedControls.Count > 0 && (selectedControls[selectedControls.Count - 1] is Panel selectedPanel))
            {
                decor.Size = selectedPanel.Size;
                decor.SetColor(selectedPanel.BackColor);
            }

            decorList.Add(decor);
            panelSeating.Controls.Add(decor.ToPanel());
        }

        public void ChangeColor()
        {
            if (!selectedControls.Any()) return;
            if (colorDialog.ShowDialog() != DialogResult.OK) return;

            foreach (var control in selectedControls.OfType<Panel>().ToList())
            {
                control.BackColor = colorDialog.Color;
                int decorIndex = GetCurrentDecorIndex(control);
                if (decorIndex != -1) decorList[decorIndex].SetColor(colorDialog.Color);
            }
        }

        public void DeleteSelectedSeat()
        {
            foreach (Control control in selectedControls.OfType<Label>().ToList())
            {
                int seatIndex = GetCurrentSeatIndex(control);
                if (seatIndex != -1) seatList.RemoveAt(seatIndex);
            }
            UpdateSeatNumbers();
        }

        public void DeleteSelectedDecor()
        {
            foreach (Control control in selectedControls.OfType<Panel>().ToList())
            {
                int decorIndex = GetCurrentDecorIndex(control);
                if (decorIndex == -1) continue;
                decorList.RemoveAt(decorIndex);
                panelSeating.Controls.Remove(control);
            }
        }

        public void UpdateSeatNumbers()
        {
            for (int i = 0; i < seatList.Count; i++)
            {
                seatList[i].SeatNumber = i + 1;
            }
            PopulateSeating();
        }
        public void UpdateComponents()
        {
            foreach (Control control in panelSeating.Controls)
            {
                if (control is Label) UpdateSeat(control);
                else if(control is Panel) UpdateDecor(control);
            }
        }
        public void UpdateSeat(Control label)
        {
            int seatIndex = GetCurrentSeatIndex(label);
            if (seatIndex >= 0 && seatIndex < seatList.Count)
            {
                seatList[seatIndex].Location = label.Location;
                seatList[seatIndex].Size = label.Size;
            }
        }

        public void UpdateDecor(Control panel)
        {
            int decorIndex = GetCurrentDecorIndex(panel);
            if (decorIndex >= 0 && decorIndex < decorList.Count)
            {
                decorList[decorIndex].Location = panel.Location;
                decorList[decorIndex].Size = panel.Size;
            }
        }

        public int GetCurrentSeatPosition(Control control)
        {
            return control is Label && int.TryParse(control.Text, out int result) ? result : -1;
        }
        public int GetCurrentSeatIndex(Control control)
        {
            return control is Label && int.TryParse(control.Text, out int result) ? result - 1 : -1;
        }

        private int GetCurrentDecorIndex(Control control)
        {
            if (control is Panel panel)
            {
                return decorList.FindIndex(decor => panel.Name == decor.Id.ToString());
            }
            return -1;
        }

        public void InsertSeat()
        {
            if (selectedControls.Count ==0 || !(selectedControls[selectedControls.Count-1] is Label selectedLabel)) return;
            int seatIndex = GetCurrentSeatIndex(selectedLabel);
            if (seatIndex == -1) return;

            Seat newSeat = new Seat(seatIndex + 2, new Point(selectedLabel.Location.X + 10, selectedLabel.Location.Y + 10));
            seatList.Insert(seatIndex + 1, newSeat);
            UpdateSeatNumbers();
        }

        public void SetUnavailable()
        {
            foreach (Control control in selectedControls.OfType<Label>())
            {
                int seatIndex = GetCurrentSeatIndex(control);
                if (seatIndex != -1) seatList[seatIndex].IsAvailable = false;
            }
            UpdateSeatNumbers();
        }
        public Color GetSeatColorByControl(Control control)
        {
            int seatIndex = GetCurrentSeatIndex(control);
            if (seatIndex != -1) return seatList[seatIndex].CurrentZone?.GetColor() ?? AppConstants.SeatBaseColor;
            return AppConstants.SeatBaseColor;
        }
        public Color GetDecorColorByControl(Control control)
        {
            int decorIndex = GetCurrentDecorIndex(control);
            if (decorIndex != -1) return decorList[decorIndex].GetColor();
            return AppConstants.SeatBaseColor;
        }
    }
}
