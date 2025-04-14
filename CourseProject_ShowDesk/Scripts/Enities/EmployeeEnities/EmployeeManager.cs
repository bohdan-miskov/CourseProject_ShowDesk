using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities
{
    public class EmployeeManager
    {
        private List<Employee> employees;
        private readonly EmployeeBaseService database;

        public EmployeeManager(EmployeeBaseService databaseService)
        {
            database = databaseService;
            LoadFromDatabase();
        }
        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
        }

        public void LoadFromDatabase()
        {
            employees = database.GetAllEmployees();
        }

        public Employee GetById(Guid id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            database.AddEmployee(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                employees.Remove(emp);
                database.RemoveEmployee(id);
            }
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            var existing = GetById(updatedEmployee.Id);
            if (existing != null)
            {
                int index = employees.IndexOf(existing);
                employees[index] = updatedEmployee;
            }
            else
            {
                employees.Add(updatedEmployee);
            }

            database.UpdateEmployee(updatedEmployee);
        }
    }

}
