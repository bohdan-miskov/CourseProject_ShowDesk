using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CourseProject_ShowDesk
{

    [Serializable]
    public class Stage 
    {
        private int index;        
        private string name;        
        private List<Zone> zones;  

        public Stage()
        {
            index = 0;
            name = "";
            zones = new List<Zone>();
        }
        public Stage(int index, string name)
        {
            this.index = index;
            this.name = name;
            zones = new List<Zone>();
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value < 0 || value > int.MaxValue)
                {
                    throw new ArgumentOutOfRangeException($"The Stage ID value must be between 0 and {int.MaxValue}");
                }
                index = value;
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
                name = (value.Length > 0) ? value : "Undefined";
            }
        }
        public List<Zone> Zones
        {
            get
            {
                return zones;
            }
            set
            {
                zones = value;
            }
        }

        public bool AddZone(Zone newZone)
        {

            if (newZone.StartPosition < 0 || newZone.EndPosition < 0)
            {
                return false;
            }

            if (zones.Count == 0)
            {
                zones.Add(newZone);
                return true;
            }

            for (int i = 0; i < zones.Count; i++)
            {
                if ((newZone.StartPosition < zones[i].StartPosition && newZone.EndPosition < zones[i].StartPosition) ||
                    (newZone.StartPosition > zones[i].EndPosition && newZone.EndPosition > zones[i].EndPosition))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            zones.Add(newZone);

            return true;
        }

        public Zone GetZone(int index)
        {
            if (index < 0 || index >= zones.Count)
            {
                return null;
            }

            return zones[index];
        }

        public bool SetZone(Zone newZone, int zoneIndex)
        {
            if (newZone.StartPosition < 0 || newZone.EndPosition < 0)
            {
                return false;
            }

            if (zones.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < zones.Count; i++)
            {
                if (i == zoneIndex)
                {
                    continue;
                }

                if ((newZone.StartPosition < zones[i].StartPosition && newZone.EndPosition < zones[i].StartPosition) ||
                    (newZone.StartPosition > zones[i].EndPosition && newZone.EndPosition > zones[i].EndPosition))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            zones[zoneIndex] = newZone;

            return true;
        }

        public bool removeZone(int index)
        {
            if (index < 0 || index >= zones.Count)
            {
                return false;
            }

            zones.RemoveAt(index);

            return true;
        }

        public int GetTotalPositions()
        {
            int counter = 0;
            for (int i = 0; i < zones.Count; i++)
            {
                counter += zones[i].EndPosition - zones[i].StartPosition + 1;
            }
            return counter;
        }

        public List<int> GetPositions()
        {
            List<int> temp = new List<int>();

            foreach (Zone zone in zones)
            {
                for (int i = zone.StartPosition; i <= zone.EndPosition; i++)
                {
                    temp.Add(i);
                }
            }

            temp.Sort();

            return temp;
        }
    }
}
