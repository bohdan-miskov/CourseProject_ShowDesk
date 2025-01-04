using System;
using System.Collections.Generic;

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
            Index = index;
            Name = name;
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
                    throw new ArgumentOutOfRangeException(nameof(Index), $"The Stage ID value must be between 0 and {int.MaxValue}.");
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name of stage cannot be empty or whitespace.", nameof(Name));
                }
                name = value;
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
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Zones), "Zones list cannot be null.");
                }
                zones = value;
            }
        }

        public bool AddZone(Zone zone)
        {
            if (ValidateZone(zone))
            {
                zones.Add(zone);
                return true;
            }

            return false;
        }

        private bool ValidateZone(Zone zone)
        {

            if (zone.StartPosition < 0 || zone.EndPosition < 0)
            {
                return false;
            }

            if (zones.Count > 0)
            {
                for (int i = 0; i < zones.Count; i++)
                {
                    if (!(
                        (zone.StartPosition < zones[i].StartPosition && zone.EndPosition < zones[i].StartPosition) ||
                        (zone.StartPosition > zones[i].EndPosition && zone.EndPosition > zones[i].EndPosition))
                        )
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public Zone GetZone(int index)
        {
            if (index < 0 || index >= zones.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Zone index is out of range.");
            }

            return zones[index];
        }

        public void RemoveZone(int index)
        {
            if (index < 0 || index >= zones.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Zone index is out of range.");
            }

            zones.RemoveAt(index);

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
            List<int> positions = new List<int>();

            foreach (Zone zone in zones)
            {
                for (int i = zone.StartPosition; i <= zone.EndPosition; i++)
                {
                    positions.Add(i);
                }
            }

            positions.Sort();

            return positions;
        }


    }
}
