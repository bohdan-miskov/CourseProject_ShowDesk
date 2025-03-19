using System;
using System.Windows.Forms;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class ParametersValidator
    {
        public static void ValidatorIntDigit(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!(IsDigitOrBackspace(symbol)))
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

            if (!(IsLetterOrBackspace(symbol) || symbol==' '))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorLoginAndPassword(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!(IsLetterOrBackspace(symbol) || IsDigitOrBackspace(symbol)))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorFileName(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!(IsLetterOrBackspace(symbol) || IsDigitOrBackspace(symbol)))
            {
                e.Handled = true;
            }
        }

        public static void ValidatorSymbol(object senderm, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (!IsSymbolOrBackspace(symbol))
            {
                e.Handled = true;
            }
        }

        public static bool NameValidator(string name)
        {
            return name.Length > 2 && !string.IsNullOrWhiteSpace(name);
        }

        public static bool PasswordValidator(string password)
        {
            return password.Length>=8 && !string.IsNullOrWhiteSpace(password);
        }

        public static bool DoubleValidator(string value)
        {
            return double.TryParse(value, out double currentValue) && currentValue >= 0;
        }

        public static bool IntValidator(string value)
        {
            return int.TryParse(value, out int currentValue) && currentValue >= 0;
        }

        public static bool FileNameValidator(string fileName)
        {
            return fileName.Length > 3 && !string.IsNullOrWhiteSpace(fileName);
        }

        private static bool IsDigitOrBackspace(char symbol)
        {
            return (Char.IsDigit(symbol) || symbol == '\b');
        }

        private static bool IsLetterOrBackspace(char symbol)
        {
            return (Char.IsLetter(symbol) || symbol == '\b');
        }

        private static bool IsSymbolOrBackspace(char symbol)
        {
            return (Char.IsSymbol(symbol) || symbol == '\b');
        }
    }
}
