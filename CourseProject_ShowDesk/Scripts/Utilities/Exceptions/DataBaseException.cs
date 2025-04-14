using System;

namespace CourseProject_ShowDesk.Scripts.Utilities.Exceptions
{
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message) : base(message) { }
    }

}
