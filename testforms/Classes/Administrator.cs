using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes
{
    public class Administrator : User
    {
        public Administrator(string ID, string username, string password, string name, string surname)
            : base(ID, username, password, name, surname) { }

        public void AddStudent(Student student)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddStudentQuery(student);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddLecturerQuery(lecturer);
        }

        public void AddCourse(Course course)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddCourseQuery(course);
        }

        public void AddGroup(Group group)
        {
            QueriesHandler queriesHandler = new();
            queriesHandler.AddGroupQuery(group);
        }

        public void DelStudent(Student student)
        {
            QueriesHandler QueriesHandler = new();
            QueriesHandler.DelStudentsGradesQuery(student);
            QueriesHandler.DelStudentQuery(student);
        }

        public void DelLecturer(Lecturer lecturer)
        {
            QueriesHandler QueriesHandler = new();
            if (QueriesHandler.GetNumberOfLecturersCoursesQuery(lecturer) == 0)
            {
                QueriesHandler.DelLecturerQuery(lecturer);
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.DeletingLecturerWithCourses(lecturer);
            }
        }

        public void DelCourse(Course course)
        {
            QueriesHandler QueriesHandler = new();
            QueriesHandler.DelCourseFromGroupsQuery(course);
            QueriesHandler.DelCourseFromGradesQuery(course);
            QueriesHandler.DelCourseQuery(course);
        }

        public void DelGroup(Group group)
        {
            QueriesHandler QueriesHandler = new();
            if (QueriesHandler.GetNumberOfStudentsInGroupQuery(group) == 0)
            {
                QueriesHandler.DelGroupCoursesQuery(group);
                QueriesHandler.DelGroupQuery(group);
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.DeletingGroupWithStudents(group);
            }
        }

        public void AssignLecturerToCourse(Lecturer lecturer, Course course)
        {
            QueriesHandler QueriesHandler = new();
            QueriesHandler.UpdateCourseLecturerIDQuery(lecturer, course);
        }

        public void AssignGroupToStudent(Group group, Student student)
        {
            QueriesHandler QueriesHandler = new();
            QueriesHandler.UpdateStudentGroupIDQuery(group, student);
        }

        public void AssignCourseToGroup(Course course, Group group)
        {
            Validator validator = new Validator();
            if (validator.IsThereCourseGroupRecord(course, group))
            {
                Feedbacker feedbacker = new();
                feedbacker.CourseIsAlreadyAssignedToGroup(course, group);
            }
            else
            {
                QueriesHandler QueriesHandler = new();
                QueriesHandler.AssignCourseToGroupQuery(course, group);
            }

        }
    }
}
