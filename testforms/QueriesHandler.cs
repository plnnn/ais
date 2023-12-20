using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Tls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace bebra
{
    public class QueriesHandler
    {
        public QueriesHandler() { }

        public void AddLecturerQuery(Lecturer lecturer)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO lecturers (username, password, name, surname) " +
                "VALUES (@username, @password, @name, @surname)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", lecturer.getUsername());
            cmd.Parameters.AddWithValue("@password", lecturer.getPassword());
            cmd.Parameters.AddWithValue("@name", lecturer.getName());
            cmd.Parameters.AddWithValue("@surname", lecturer.getSurname());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordInserted();
                feedbacker.PasswordIsSurname();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToInsertRecord();
            }

            con.Close();
        }

        public void AddGroupQuery(Group group)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO groups (code) VALUES (@code)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@code", group.getCode());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordInserted();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToInsertRecord();
            }

            con.Close();
        }

        public void AddStudentQuery(Student student)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO students (username, password, name, surname, groupID) " +
                "VALUES (@username, @password, @name, @surname, @groupID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", student.getUsername());
            cmd.Parameters.AddWithValue("@password", student.getPassword());
            cmd.Parameters.AddWithValue("@name", student.getName());
            cmd.Parameters.AddWithValue("@surname", student.getSurname());
            cmd.Parameters.AddWithValue("@groupID", student.getGroupID());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordInserted();
                feedbacker.PasswordIsSurname();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToInsertRecord();
            }

            con.Close();
        }

        public void AddCourseQuery(Course course)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO courses (name, lecturerID) " +
                "VALUES (@name, @lecturerID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", course.getName());
            cmd.Parameters.AddWithValue("@lecturerID", course.getlecturerID());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordInserted();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToInsertRecord();
            }

            con.Close();
        }

        private void DelRecordByID(string table, string ID)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM " + table + " WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ID", ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordDeleted();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToDeleteRecord();
            }

            con.Close();
        }

        public void DelStudentsGradesQuery(Student student)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM grades WHERE studentID = @studentID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@studentID", student.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            feedbacker.StudentGradesWereDeleted(student);
            con.Close();
        }

        public void DelStudentQuery(Student student)
        {
            DelRecordByID("students", student.ID);
        }

        public int GetNumberOfLecturersCoursesQuery(Lecturer lecturer)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM courses WHERE lecturerID = @lecturerID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@lecturerID", lecturer.ID);

            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }

            con.Close();
            return cnt;
        }

        public void DelLecturerQuery(Lecturer lecturer)
        {
            DelRecordByID("lecturers", lecturer.ID);
        }

        public void DelCourseFromGroupsQuery(Course course)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM courses_groups WHERE courseID = @courseID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", course.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            feedbacker.CourseWasDeletedFromGroups(course);
            con.Close();
        }

        public void DelCourseFromGradesQuery(Course course)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM grades WHERE courseID = @courseID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", course.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            feedbacker.CourseGradesWereDeleted(course);

            con.Close();
        }

        public void DelCourseQuery(Course course)
        {
            DelRecordByID("courses", course.ID);
        }

        public int GetNumberOfStudentsInGroupQuery(Group group)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM students WHERE groupID = @groupID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@groupID", group.ID);

            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }

            con.Close();
            return cnt;
        }

        public void DelGroupCoursesQuery(Group group)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM courses_groups WHERE groupID = @groupID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@groupID", group.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            feedbacker.GroupCoursesWereDeleted(group);
            con.Close();
        }

        public void DelGroupQuery(Group group)
        {
            DelRecordByID("groups", group.ID);
        }

        public void UpdateCourseLecturerIDQuery(Lecturer lecturer, Course course)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "UPDATE courses " +
                "SET lecturerID = @lecturerID " +
                "WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@lecturerID", lecturer.ID);
            cmd.Parameters.AddWithValue("@ID", course.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            if (rowsAffected > 0)
            {
                feedbacker.LecturerAssignedToCourse(lecturer, course);
            }
            else
            {
                feedbacker.FailedToAssignLecturerToCourse(lecturer, course);
            }

            con.Close();
        }

        public void UpdateStudentGroupIDQuery(Group group, Student student)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "UPDATE students " +
                "SET groupID = @groupID " +
                "WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@groupID", group.ID);
            cmd.Parameters.AddWithValue("@ID", student.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            if (rowsAffected > 0)
            {
                feedbacker.GroupAssignedToStudent(group, student);
            }
            else
            {
                feedbacker.FailedToAssignGroupToStudent(group, student);
            }

            con.Close();
        }

        public void AssignCourseToGroupQuery(Course course, Group group)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO courses_groups (courseID, groupID) " +
                "VALUES (@courseID, @groupID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", course.ID);
            cmd.Parameters.AddWithValue("@groupID", group.ID);

            int rowsAffected = cmd.ExecuteNonQuery();
            Feedbacker feedbacker = new();
            if (rowsAffected > 0)
            {
                feedbacker.CourseAssignedToGroup(course, group);
            }
            else
            {
                feedbacker.FailedToAssignCourseToGroup(course, group);
            }

            con.Close();
        }

        public string GetGradeQuery(string courseID, string studentID)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT grades.grade FROM grades " +
                "WHERE (courseID = @courseID AND studentID = @studentID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", courseID);
            cmd.Parameters.AddWithValue("@studentID", studentID);

            string grade = null;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                grade = Convert.ToString(result);
            }

            con.Close();
            return grade;
        }

        public bool GradeAlreadyExistsQuery(Grade grade)
        {
            return (GetGradeQuery(grade.getCourseID(), grade.getStudentID()) != null);
        }

        private void DelGradeQuery(Grade grade)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "DELETE FROM grades WHERE (studentID = @studentID AND courseID = @courseID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@studentID", grade.getStudentID());
            cmd.Parameters.AddWithValue("@courseID", grade.getCourseID());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddGradeQuery(Grade grade)
        {
            if (GradeAlreadyExistsQuery(grade))
            {
                DelGradeQuery(grade);
            }

            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "INSERT INTO grades (studentID, courseID, grade) " +
                "VALUES (@studentID, @courseID, @grade)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@studentID", grade.getStudentID());
            cmd.Parameters.AddWithValue("@courseID", grade.getCourseID());
            cmd.Parameters.AddWithValue("@grade", grade.getGrade());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordInserted();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToInsertRecord();
            }

            con.Close();
        }

        public void EditGradeQuery(Grade newGrade)
        {
            if (!GradeAlreadyExistsQuery(newGrade))
            {
                Feedbacker errorHandler = new();
                errorHandler.NoGradeForStudentForCourse(newGrade.getStudentID(), newGrade.getCourseID());
                return;
            }

            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "UPDATE grades " +
                "SET grade = @newGrade " +
                "WHERE (studentID = @studentID AND courseID = @courseID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@newGrade", newGrade.getGrade());
            cmd.Parameters.AddWithValue("@studentID", newGrade.getStudentID());
            cmd.Parameters.AddWithValue("@courseID", newGrade.getCourseID());

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Feedbacker feedbacker = new();
                feedbacker.RecordUpdated();
            }
            else
            {
                Feedbacker errorHandler = new();
                errorHandler.FailedToUpdateRecord();
            }

            con.Close();
        }
    }
}
