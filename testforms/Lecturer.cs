using kotyk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebra
{
    public class Lecturer : User
    {
        public Lecturer(string ID, string username, string password, string name, string surname)
         : base(ID, username, surname, name, surname) { }

        public Lecturer(User user)
         : base(user.getID(), user.getUsername(), user.getPassword(), user.getName(), user.getSurname()) { }

        public void AddGrade(Grade grade)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddGradeQuery(grade);
        }

        public string GetGrade(string courseID, string studentID)
        {
            QueriesHandler queriesHandler = new();
            return queriesHandler.GetGradeQuery(courseID, studentID);
        }

        public void EditGrade(Grade newGrade)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.EditGradeQuery(newGrade);
        }
    }
}
