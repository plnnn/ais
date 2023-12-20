using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes
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
