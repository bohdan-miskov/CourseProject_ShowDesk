using CourseProject_ShowDesk.Scripts.Constants;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class DecorativeElement
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string hexColor;
        public Point Location;
        public Size Size = new Size(50, 50);

        public DecorativeElement(Point location)
        {
            Location = location;
        }

        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public string HexColor
        {
            get
            {
                return hexColor;
            }
            set
            {
                hexColor = value;
            }
        }

        public Panel ToPanel()
        {
            Panel panel = new Panel
            {
                Name = this.Id.ToString(),
                Size = this.Size,
                Location = this.Location,
                BackColor = GetColor(),
                BorderStyle = BorderStyle.FixedSingle,
                Enabled = false,
                MinimumSize = new Size(10,10)
            };

            return panel;
        }
        public void SetColor(Color color)
        {
            HexColor = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        public Color GetColor()
        {
            if (HexColor == null) SetColor(AppConstants.SeatBaseColor);
            return ColorTranslator.FromHtml(HexColor);
        }
    }
}
