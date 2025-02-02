using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Enities
{
    public class DecorativeElement
    {
        private int decorId;
        private Color color = Color.LightGray;
        public Point Location;
        public Size Size = new Size(50, 50);
        public BorderStyle BorderStyle = BorderStyle.FixedSingle;
        public bool Enabled = false;

        // Конструктор
        public DecorativeElement(Point location)
        {

            Location = location;
            decorId =(int)(DateTime.Now.Ticks%1000000) *new Random().Next(1, 10)/10;
        }

        public int DecorId
        {
            get
            {
                return decorId;
            }
            set
            {
                decorId = value;
            }

        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        // Метод для масштабування
        public void Scale(Size newSize)
        {
            Size = newSize;
        }

        // Метод для створення Panel з візуалізацією
        public Panel ToPanel()
        {
            Panel panel = new Panel
            {
                Name = this.DecorId.ToString(),
                Size = this.Size,
                Location = this.Location,
                BackColor = this.Color,
                BorderStyle = this.BorderStyle,
                Enabled = this.Enabled
            };

            return panel;
        }

        //public string Serialize()
        //{
        //    return $"{Location.X},{Location.Y}|{Size.Width},{Size.Height}|{Color.ToArgb()}";
        //}

        //public static DecorativeElement Deserialize(string data)
        //{
        //    var parts = data.Split('|');
        //    var locationParts = parts[0].Split(',');
        //    var location = new Point(int.Parse(locationParts[0]), int.Parse(locationParts[1]));
        //    var sizeParts = parts[1].Split(',');
        //    var size = new Size(int.Parse(sizeParts[0]), int.Parse(sizeParts[1]));
        //    var color = Color.FromArgb(int.Parse(parts[2]));

        //    DecorativeElement decor = new DecorativeElement(location)
        //    {
        //        Size = size,
        //        Color = color
        //    };

        //    decor.BackColor = color;
        //    return decor;
        //}
    }
}
