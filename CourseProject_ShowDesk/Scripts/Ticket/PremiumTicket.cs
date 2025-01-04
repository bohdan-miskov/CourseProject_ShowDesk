using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts
{
    public class PremiumTicket : StandardPlusTicket
    {
        private string souvenir;

        public PremiumTicket()
        {
            souvenir = "Poster";
            typeIncrease = 3;
            type = "Premium";
        }

        public PremiumTicket(int index, int position, bool reserved, string drink, string souvenir) : base(index, position, reserved, drink)
        {
            Souvenir = souvenir;
            typeIncrease = 3;
            type = "Premium";
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
