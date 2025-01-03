using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public class ParametersValidator
    {
        public static void ValidatorIntDigit(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!(Char.IsDigit(number) || number == '\b'))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorDoubleDigit(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!(Char.IsDigit(number) || number == '\b' || number == ','))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorLetter(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((Char.IsDigit(number) ||  number == ','))
            {
                e.Handled = true;
            }
        }

        public static bool NameValidator(string name)
        {
            if (name.Length > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoubleValidator(string value)
        {
            double currentValue;

            if (value.Length == 0)
            {
                return false;
            }

            try
            {
                currentValue = Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }

            if (currentValue < 0)
            {
                return false;
            }

            return true;
        }


    }
}
