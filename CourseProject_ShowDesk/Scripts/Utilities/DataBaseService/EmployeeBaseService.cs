using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService
{
    public class EmployeeBaseService
    {
        private readonly IMongoCollection<Employee> employeeCollection;

        public EmployeeBaseService()
        {
            try
            {
                var client = new MongoClient(AppConstants.ConnectionString);
                var db = client.GetDatabase(AppConstants.GeneralCollectionName);
                var test = db.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Result;

                employeeCollection = db.GetCollection<Employee>(AppConstants.EmployeesCollectionName);
            }
            catch
            {
                throw new DatabaseConnectionException("Could not connect to the database.");
            }

        }
        public async Task<List<Employee>> GetAllEmployeesAsync(bool sortByName = true)
        {
            var employees = await employeeCollection.Find(_ => true).ToListAsync();
            if (sortByName)
            {
                employees.Sort((p1, p2) => p1.FullName.CompareTo(p2.FullName));
            }
            return employees;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await employeeCollection.InsertOneAsync(employee);
        }

        public async Task RemoveEmployeeAsync(Guid id)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", id);
            await employeeCollection.DeleteOneAsync(filter);
        }

        public async Task UpdateEmployeeAsync(Employee updatedEmployee)
        {
            var filter = Builders<Employee>.Filter.Eq(p => p.Id, updatedEmployee.Id);
            await employeeCollection.ReplaceOneAsync(filter, updatedEmployee);
        }
    }
}
