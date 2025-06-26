using CourseProject_ShowDesk.Scripts.Utilities.DataBaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities
{
    public class EmployeeManager
    {
        private List<Employee> employees;
        private readonly EmployeeBaseService database;

        public EmployeeManager(EmployeeBaseService databaseService)
        {
            database = databaseService;
        }

        public List<Employee> Employees
        {
            get
            {
                return employees;
            }
        }

        public async Task LoadFromDatabaseAsync()
        {
            employees = await database.GetAllEmployeesAsync();
        }

        public Employee GetById(Guid id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            employees.Add(employee);
            await database.AddEmployeeAsync(employee);
        }

        public async Task RemoveEmployeeAsync(Guid id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                employees.Remove(emp);
                await database.RemoveEmployeeAsync(id);
            }
        }

        public async Task UpdateEmployeeAsync(Employee updatedEmployee)
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

            await database.UpdateEmployeeAsync(updatedEmployee);
        }
    }

}
