using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Utilities.Validators
{
    public class EmployeeValidator
    {
        private readonly List<Employee> employees;

        public EmployeeValidator(List<Employee> employees)
        {
            this.employees = employees;
        }

        public bool Validate(Employee employee, out string errorMessage)
        {
            if (!ValidateName(employee.FullName, out errorMessage))
                return false;

            if (!ValidateLogin(employee.Login, out errorMessage))
                return false;

            if (!ValidatePassword(employee.Password, out errorMessage))
                return false;

            if (!ValidateProfessions(employee, out errorMessage))
                return false;

            errorMessage = null;
            return true;
        }

        private bool ValidateName(string name, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                errorMessage = "Full name must be at least 3 characters long.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateLogin(string login, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(login) || login.Length < 3)
            {
                errorMessage = "Login must be at least 3 characters long.";
                return false;
            }

            if (IsLoginRepeated(login))
            {
                errorMessage = "Login must be unique. This one already exists.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidatePassword(string password, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateProfessions(Employee employee, out string errorMessage)
        {
            if (employee.ProfessionList.Count == 0)
            {
                errorMessage = "At least one profession must be selected.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool IsLoginRepeated(string login)
        {
            return employees.Any(e => e.Login == login);
        }
    }
}
