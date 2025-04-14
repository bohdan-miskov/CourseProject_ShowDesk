using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class Seat
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private int seatNumber;
        private bool isAvailable = true;
        private Zone currentZone = null;
        private Color color = Color.LightBlue;
        public Point Location;
        public Size Size = new Size(50, 50);
        public bool Enabled = false;


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
                Enabled = this.Enabled,
                Text = this.SeatNumber.ToString(),
                ForeColor = Color.Black,
                Font = new Font("Modern No. 20", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter

            };



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
                $"Location: {Location.X} : {Location.Y}\n" +
                $"Size: {Size.Width} ; {Size.Height}";
        }

        public Color GetColor()
        {
            return (this.CurrentZone ?? new Zone()).GetColor();
        }
    }
}
