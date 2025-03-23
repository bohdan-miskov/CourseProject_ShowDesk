using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CourseProject_ShowDesk.Scripts.Enities.PerformanceEnities.Ticket
{
    [Serializable]
    public class StandardPlusTicket : StandardTicket
    {
        [BsonId]
        protected string drink;

        public StandardPlusTicket()
        {
            //typeIncrease = AppConstants.StandardPlusIncrease;
            //type = AppConstants.ListOfTicketTypes[1];
            //drink = AppConstants.ListOfDrinks[0];
        }

        public StandardPlusTicket(int index, int position, bool reserved, string drink) : base(index, position, reserved)
        {
            Drink = drink;
        }

        public string Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Drink cannot be null, empty, or whitespace.", nameof(Drink));
                }
                drink = value;
            }
        }


        public override string GetAdditionalServices()
        {
            return $"Drink: {drink}";
        }

    }
}
