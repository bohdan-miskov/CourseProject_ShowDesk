using CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities;
using CourseProject_ShowDesk.Scripts.Constants;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject_ShowDesk.Scripts.Utilities.DataBaseService
{
    public class EmployeeBaseService
    {
        private readonly IMongoCollection<Employee> employeeCollection;

        public EmployeeBaseService(string dbName = "Event")
        {
            var client = new MongoClient(AppConstants.ConnectionString);
            var db = client.GetDatabase(dbName);

            employeeCollection = db.GetCollection<Employee>("Employees");
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeCollection.Find(_ => true).ToList();
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
