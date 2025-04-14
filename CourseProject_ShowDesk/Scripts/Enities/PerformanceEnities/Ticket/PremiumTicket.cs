using CourseProject_ShowDesk.Scripts.Constants;
using System;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket
{
    [Serializable]
    public class PremiumTicket : StandardPlusTicket
    {
        private string souvenir;

        public PremiumTicket()
        {
            typeIncrease = AppConstants.PremiumIncrease;
            type = AppConstants.ListOfTicketTypes[2];
            drink = AppConstants.ListOfDrinks[0];
        }

        public PremiumTicket(int position, bool reserved, string drink, string souvenir) : base(position, reserved, drink)
        {
            Souvenir = souvenir;
        }

        public string Souvenir
        {
            get
            {
                return souvenir;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Souvenir cannot be null, empty, or whitespace.", nameof(Souvenir));
                }
                souvenir = value;
            }
        }

        public override string GetAdditionalServices()
        {
            return base.GetAdditionalServices() + $"\nSouvenir: {souvenir}";
        }
    }
}
