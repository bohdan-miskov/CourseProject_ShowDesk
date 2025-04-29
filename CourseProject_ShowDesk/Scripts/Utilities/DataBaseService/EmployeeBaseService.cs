using CourseProject_ShowDesk.Scripts.Constants;
using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Enities.StageEnities;
using CourseProject_ShowDesk.Scripts.Utilities.Exceptions;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

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

                var update = Builders<Employee>.Update.Unset("ScaleFactor");
                employeeCollection.UpdateMany(Builders<Employee>.Filter.Empty, update);
            }
            catch
            {
                throw new DatabaseConnectionException("Could not connect to the database.");
            }

        }
        public List<Employee> GetAllEmployees(bool sortByName = true)
        {
            List<Employee> employees = employeeCollection.Find(employee => true).ToList();
            if (sortByName)
            {
                employees.Sort((p1, p2) => p1.FullName.CompareTo(p2.FullName));
            }
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employeeCollection.InsertOne(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", id);
            employeeCollection.DeleteOne(filter);
        }

        public void UpdateEmployee(Employee updatedEmployee)
        {
            var filter = Builders<Employee>.Filter.Eq(p => p.Id, updatedEmployee.Id);
            employeeCollection.ReplaceOne(filter, updatedEmployee);
        }
    }
}
