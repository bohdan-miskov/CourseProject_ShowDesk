using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk
{
    public class ParametersValidator
    {
        public static void ValidatorIntDigit(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (IsDigitOrBackspace(symbol))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorDoubleDigit(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!(IsDigitOrBackspace(symbol) || symbol == ','))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorLetter(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (IsLetterOrBackspace(symbol))
            {
                e.Handled = true;
            }
        }

        public static bool NameValidator(string name)
        {
            return name.Length > 2 && !string.IsNullOrWhiteSpace(name);
        }

        public static bool DoubleValidator(string value)
        {
            return double.TryParse(value, out double currentValue) && currentValue >= 0;
        }

        public static bool IntValidator(string value)
        {
            return int.TryParse(value, out int currentValue) && currentValue >= 0;
        }

        private static bool IsDigitOrBackspace(char symbol)
        {
            return (Char.IsDigit(symbol) || symbol == '\b');
        }

        private static bool IsLetterOrBackspace(char symbol)
        {
            return (Char.IsLetter(symbol) || symbol == '\b');
        }
    }
}
