using System;
using System.Collections.Generic;
using CourseProject_ShowDesk.Scripts.Enities;

namespace CourseProject_ShowDesk
{

    [Serializable]
    public class Stage
    {
        private int index;
        private string name;
        private List<Zone> zones;
        private List<Seat> seatList;
        private List<DecorativeElement> decorList;

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
                    throw new ArgumentNullException(nameof(zones), "Zones list cannot be null.");
                }
                zones = value;
            }
        }

        public List<Seat> SeatList
        {
            get
            {
                return seatList;
            }
            set
            {
                seatList = value;
            }
        }

        public List<DecorativeElement> DecorList
        {
            get
            {
                return decorList;
            }
            set
            {
                decorList = value;
            }
        }

        public void AddZone(Zone zone)
        { 
            zones.Add(zone);
        }

        public bool CheckZonePositions(int startPosition, int endPosition, int currentZoneIndex)
        {

            if (startPosition < 0 || endPosition < 0)
            {
                return false;
            }

            if (zones.Count > 0)
            {
                for (int i = 0; i < zones.Count; i++)
                {
                    if (!(
                        (startPosition < zones[i].StartPosition && endPosition < zones[i].StartPosition) ||
                        (startPosition > zones[i].EndPosition && endPosition > zones[i].EndPosition))
                        )
                    {
                        if (currentZoneIndex != i)
                        {
                            return false;
                        }
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
