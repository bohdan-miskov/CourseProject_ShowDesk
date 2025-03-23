using System;
using System.Collections.Generic;
using System.Linq;
using CourseProject_ShowDesk.Scripts.Enities;
using CourseProject_ShowDesk.Scripts.Utilities;
using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using MongoDB.Bson.Serialization.Attributes;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{

    [Serializable]
    public class Stage
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
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
        public Guid Id
        {
            get
            {
                return id;
            }
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
                zones = value ?? throw new ArgumentNullException(nameof(zones), "Zones list cannot be null.");
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
            UpdateZoneSeats(zone);
        }

        public bool CheckZonePositions(int startPosition, int endPosition, Zone currentZone)
        {

            if (startPosition < 0 || endPosition < 0)
            {
                return false;
            }

            if (zones.Count > 0)
            {
                foreach(Zone zone in zones) 
                {
                    if (!(
                        (startPosition < zone.StartPosition && endPosition < zone.StartPosition) ||
                        (startPosition > zone.EndPosition && endPosition > zone.EndPosition))
                        )
                    {
                        if (currentZone.Id!=zone.Id)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public Zone GetZone(Guid zoneId)
        {
            var zone = zones.FirstOrDefault(z => z.Id == zoneId)
                ?? throw new ArgumentException("Zone with the given id does not exist.", nameof(zoneId));
                
            return zone;
        }


        public void RemoveZone(Guid zoneId)
        {
            var zoneToRemove = zones.FirstOrDefault(z => z.Id == zoneId)
                ?? throw new ArgumentException("Zone with the given id does not exist.", nameof(zoneId));

            zones.Remove(zoneToRemove);
        }

        private void UpdateZoneSeats(Zone zone)
        {
            for (int i = zone.StartPosition-1; i <= zone.EndPosition-1; i++)
            {
                seatList[i].CurrentZone = zone;
            }
        }

        public void UpdateZone(Zone newZone)
        {
            var zoneToUpdate = zones.FirstOrDefault(z => z.Id == newZone.Id)
    ?? throw new ArgumentException("Zone with the given id does not exist.", nameof(newZone.Id));

            var index = zones.IndexOf(zoneToUpdate);
            zones[index] = newZone;
            UpdateZoneSeats(newZone);
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
