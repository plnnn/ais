using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes.dbObjects
{
    public class Grade
    {
        private string studentID;
        private string courseID;
        private string grade;

        public Grade(string studentID, string courseID, string grade)
        {
            this.studentID = studentID;
            this.courseID = courseID;
            this.grade = grade;
        }

        public string getStudentID() { return studentID; }

        public string getCourseID() { return courseID; }

        public string getGrade() { return grade; }
    }
}
