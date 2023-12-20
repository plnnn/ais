using kotyk.Classes.FunctionClasses;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes.dbObjects
{
    public class Student : User
    {
        private string groupID;

        public Student(string ID, string username, string password, string name, string surname, string groupID)
            : base(ID, username, surname, name, surname)
        {
            this.groupID = groupID;
        }

        public string getGroupID() { return groupID; }

        public DataTable ViewGrades()
        {
            dbPrinter printer = new();
            DataTable grades = printer.PrintStudentGrades(this);
            return grades;
        }
    }
}
