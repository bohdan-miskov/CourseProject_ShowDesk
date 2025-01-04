using System;

namespace CourseProject_ShowDesk.Scripts
{
    public class StandardPlusTicket : StandardTicket
    {
        protected string drink;

        public StandardPlusTicket()
        {
            typeIncrease = 1.5;
            type = "Standard Plus";
            drink = "Сoffee";
        }

        public StandardPlusTicket(int index, int position, bool reserved, string drink) : base(index, position, reserved)
        {
            Drink = drink;
            typeIncrease = 1.5;
            type = "Standard Plus";
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
