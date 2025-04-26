using CourseProject_ShowDesk.Scripts.Constants;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class Seat
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private int seatNumber;
        private bool isAvailable = true;
        private Zone currentZone = null;
        public Point Location;
        public Size Size = new Size(50, 50);

        public Seat(int number, Point location)
        {
            SeatNumber = number;
            Location = location;
        }
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        public int SeatNumber
        {
            get
            {
                return seatNumber;
            }
            set
            {
                seatNumber = value;
            }

        }

        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
            set
            {
                isAvailable = value;
            }
        }

        public Zone CurrentZone
        {
            get
            {
                return currentZone;
            }
            set
            {
                currentZone = value;
            }
        }

        public System.Windows.Forms.Label ToLabel()
        {
            
            System.Windows.Forms.Label label = new System.Windows.Forms.Label
            {
                Name = this.SeatNumber.ToString(),
                Size = this.Size,
                Location = this.Location,
                BackColor = GetColor(),
                Enabled = false,
                Text = this.SeatNumber.ToString(),
                ForeColor = Color.Black,
                Font = new Font("Modern No. 20", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Size textSize = TextRenderer.MeasureText(label.Text, label.Font);
            label.MinimumSize = new Size(textSize.Width+6, textSize.Height + 6);

            label.Paint += (s, e) =>
            {
                if (!IsAvailable)
                {
                    e.Graphics.DrawLine(Pens.Red, 0, 0, label.Width, label.Height);
                    e.Graphics.DrawLine(Pens.Red, label.Width, 0, 0, label.Height);
                }
            };

            return label;
        }

        public string GetInfo()
        {
            return $"Seat: {seatNumber}\n" +
                $"Zone: {currentZone.Name} \n" +
                $"Increase: {currentZone.Increase}\n" +
                $"Available: {isAvailable}";
        }

        public Color GetColor()
        {
            return CurrentZone?.GetColor() ?? AppConstants.SeatBaseColor;
        }
    }
}
