using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_TheaterHub
{

    [Serializable]
    public class Zone
    {
        private string name;     
        private double increase;   
        private int startPosition;    
        private int endPosition;    

        public Zone()
        {
            name = "";
            increase = 1.0;
            startPosition = 0;
            endPosition = 0;
        }
        public Zone(string name, double increase, int startPosition, int endPosition)
        {
            this.name = name;
            this.increase = increase;
            this.startPosition = startPosition;
            this.endPosition = endPosition;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value.Length > 0) ? value : "Undefined";
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
                increase = (value < 0) ? 0 : value;
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
                endPosition = value;
            }
        }
    }

}
