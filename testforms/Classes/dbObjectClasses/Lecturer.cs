using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kotyk.Classes.FunctionClasses;

namespace kotyk.Classes.dbObjects
{
    public class Lecturer : User
    {
        public Lecturer(string ID, string username, string password, string name, string surname)
         : base(ID, username, surname, name, surname) { }

        public void AddGrade(Grade grade)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddGradeQuery(grade);
        }
    }
}
