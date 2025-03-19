using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class ZoneValidator
    {
        private readonly List<Zone> existingZones;

        public ZoneValidator(List<Zone> zones)
        {
            this.existingZones = zones;
        }

        public bool Validate(Zone zone, out string errorMessage)
        {
            if (!ValidateName(zone.Name, out errorMessage))
                return false;

            if (!ValidateIncrease(zone.Increase, out errorMessage))
                return false;

            if (!ValidatePositionRange(zone.StartPosition, zone.EndPosition, zone,  out errorMessage))
                return false;

            errorMessage = null;
            return true;
        }

        private bool ValidateName(string name, out string errorMessage)
        {
            if (!ParametersValidator.NameValidator(name))
            {
                errorMessage = "The name must be more than two characters long.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateIncrease(double increase, out string errorMessage)
        {
            if (increase < 0)
            {
                errorMessage = "The surcharge must be positive.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidatePositionRange(int startPosition, int endPosition, Zone currentZone, out string errorMessage)
        {
            if (startPosition > endPosition)
            {
                errorMessage = "The starting position cannot be larger than the ending position.";
                return false;
            }

            if (!CheckZonePositions(startPosition, endPosition, currentZone))
            {
                errorMessage = "The range of positions in the new sector cannot intersect with any range of positions in another sector of the hall.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool CheckZonePositions(int startPosition, int endPosition, Zone currentZone)
        {
            foreach (var zone in existingZones)
            {
                if (zone == currentZone) continue;

                if (ZonesIntersect(startPosition, endPosition, zone.StartPosition, zone.EndPosition))
                    return false;
            }

            return true;
        }

        private bool ZonesIntersect(int start1, int end1, int start2, int end2)
        {
            return start1 <= end2 && start2 <= end1;
        }
    }
}
