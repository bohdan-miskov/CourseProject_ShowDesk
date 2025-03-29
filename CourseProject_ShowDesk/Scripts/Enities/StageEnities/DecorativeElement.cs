using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{
    public class DecorativeElement
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string hexColor = "#D3D3D3";
        public Point Location;
        public Size Size = new Size(50, 50);
        public BorderStyle BorderStyle = BorderStyle.FixedSingle;
        public bool Enabled = false;

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

        public void Scale(Size newSize)
        {
            Size = newSize;
        }

        public Panel ToPanel()
        {
            Panel panel = new Panel
            {
                Name = this.Id.ToString(),
                Size = this.Size,
                Location = this.Location,
                BackColor = GetColor(),
                BorderStyle = this.BorderStyle,
                Enabled = this.Enabled
            };

            return panel;
        }
        public void SetColor(Color color)
        {
            HexColor = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        public Color GetColor()
        {
            return ColorTranslator.FromHtml(HexColor);
        }
    }
}
