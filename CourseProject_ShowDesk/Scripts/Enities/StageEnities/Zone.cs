using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{

    [Serializable]
    public class Zone
    {
        [BsonId]
        private Guid id=Guid.NewGuid();
        private string name;
        private double increase;
        private int startPosition;
        private int endPosition;
        private string hexColor;

        public Zone()
        {
            Name = "";
            Increase = 1.0;
            StartPosition = 0;
            EndPosition = 0;
            SetColor(Color.LightBlue);
        }
        public Zone(string name, double increase, int startPosition, int endPosition, Color color)
        {
            Name = name;
            Increase = increase;
            StartPosition = startPosition;
            EndPosition = endPosition;
            SetColor(color);
        }
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //if (string.IsNullOrWhiteSpace(value))
                //{
                //    throw new ArgumentException("Name of zone cannot be empty or whitespace.", nameof(Name));
                //}
                name = value;
            }
        }
        public double Increase
        {
            get
            {
                return increase;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Increase), "Increase value cannot be negative.");
                }
                increase = value;
            }
        }
        public int StartPosition
        {
            get
            {
                return startPosition;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(StartPosition), "StartPosition must be a non-negative integer.");
                }
                startPosition = value;
            }
        }
        public int EndPosition
        {
            get
            {
                return endPosition;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(EndPosition), "EndPosition must be a non-negative integer.");
                }

                if (value < startPosition)
                {
                    throw new ArgumentException("EndPosition cannot be less than StartPosition.", nameof(EndPosition));
                }

                endPosition = value;
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

        public void SetColor(Color color)
        {
            HexColor= $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
        public Color GetColor()
        {
            return ColorTranslator.FromHtml(HexColor);
        }
    }

}
