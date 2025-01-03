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
            typeIncrease = 3;
            type = "Premium";
        }

        public PremiumTicket(int index, int position, bool reserved, string drink, string souvenir) : base(index, position, reserved, drink)
        {
            this.souvenir = souvenir;
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
                souvenir = value;
            }
        }

        public override string GetAdditionalServices()
        {
            return base.GetAdditionalServices() + $"\nSouvenir: {souvenir}";
        }


    }
}
