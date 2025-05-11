using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Enities.StageEnities
{

    [Serializable]
    public class Stage
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string name;
        private Point stageLocation = new Point(-1000, -1000);
        private Size stageSize;
        private List<Zone> zones;
        private List<Seat> seatList;
        private List<DecorativeElement> decorList;

        public Stage()
        {
            zones = new List<Zone>();
        }
        public Stage(string name)
        {
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Point StageLocation
        {
            get
            {
                return stageLocation;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(stageLocation), "Stage location cannot be null.");
                stageLocation = value;
            }
        }
        public Size StageSize
        {
            get
            {
                return stageSize;
            }
            set
            {
                if (value.Height <= 0 || value.Width <= 0)
                    throw new ArgumentOutOfRangeException(nameof(stageSize), "Stage size must be greater than 0.");
                stageSize = value;
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

        public void AddZone(Zone zone, bool sortByName = true)
        {
            zones.Add(zone);
            if (sortByName)
            {
                zones.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            }
            UpdateZoneSeats(zone);
        }

        public Zone GetZoneById(Guid zoneId)
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
            for (int i = zone.StartPosition - 1; i <= zone.EndPosition - 1; i++)
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
