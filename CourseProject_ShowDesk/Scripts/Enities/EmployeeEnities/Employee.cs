using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace CourseProject_ShowDesk.Scripts.Enities.EmployeeEnities
{
    [Serializable]
    public class Employee
    {
        [BsonId]
        private Guid id = Guid.NewGuid();
        private string fullName;
        private string login;
        private string password;
        private List<string> professionList;

        public Employee()
        {
            this.FullName = "Guest";
            professionList = new List<string>();
        }

        public Employee(string fullName, string login, string password)
        {
            this.fullName = fullName;
            this.login = login;
            this.password = password;
            this.professionList = new List<string>();
        }
        public Guid Id
        {
            get
            {
                return id;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }

        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public List<string> ProfessionList
        {
            get
            {
                return professionList;
            }

            set
            {
                professionList = value;
            }
        }

        public void AddProfession(string profession)
        {
            if (profession == null)
            {
                throw new ArgumentNullException(nameof(profession), "Profession cannot be null.");
            }
            professionList.Add(profession);
        }

        public void RemoveProfession(int index)
        {
            if (index < 0 || index >= professionList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Profession index is out of range.");
            }

            professionList.RemoveAt(index);
        }

        public string GetStringOfProfessionList()
        {
            string result = "";

            for (int i = 0; i < professionList.Count; i++)
            {
                if (i != 0)
                {
                    result += " ,";
                }
                result += professionList[i];
            }

            return result;
        }
    }
}
