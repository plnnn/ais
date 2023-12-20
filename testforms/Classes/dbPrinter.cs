using testforms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Web;

namespace kotyk.Classes
{
    public class dbPrinter
    {
        public dbPrinter() { }

        public List<Group> PrintGroups()
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM groups";
            MySqlCommand cmd = new MySqlCommand(query, con);

            List<Group> groups = new List<Group>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string code = Convert.ToString(reader["code"]);
                groups.Add(new(ID, code));
            }
            con.Close();

            return groups;
        }

        public List<Group> PrintGroupsByCourse(Course course)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT groups.ID AS groupID, groups.code AS groupCode " +
                "FROM groups, courses, courses_groups " +
                "WHERE (courses.ID = @courseID AND courses.ID = courses_groups.courseID " +
                "AND courses_groups.groupID = groups.ID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", course.getID());

            List<Group> groups = new List<Group>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["groupID"]);
                string code = Convert.ToString(reader["groupCode"]);
                groups.Add(new(ID, code));
            }
            con.Close();

            return groups;
        }

        public List<Lecturer> PrintLecturers()
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM lecturers";
            MySqlCommand cmd = new MySqlCommand(query, con);

            List<Lecturer> lecturers = new List<Lecturer>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string username = Convert.ToString(reader["username"]);
                string password = Convert.ToString(reader["password"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);
                lecturers.Add(new(ID, username, password, name, surname));
            }
            con.Close();

            return lecturers;
        }

        public List<Student> PrintStudents()
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(query, con);

            List<Student> students = new List<Student>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string username = Convert.ToString(reader["username"]);
                string password = Convert.ToString(reader["password"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);
                string groupID = Convert.ToString(reader["groupID"]);
                students.Add(new Student(ID, username, password, name, surname, groupID));
            }
            con.Close();

            return students;
        }

        public List<Course> PrintCourses()
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM courses";
            MySqlCommand cmd = new MySqlCommand(query, con);

            List<Course> courses = new List<Course>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string name = Convert.ToString(reader["name"]);
                string lecturerID = Convert.ToString(reader["lecturerID"]);
                courses.Add(new(ID, name, lecturerID));
            }
            con.Close();

            return courses;
        }

        private void PrintStudentSetGrades(Student student, DataTable table)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT courses.name AS courseName, grades.grade AS grade " +
                "FROM grades, courses " +
                "WHERE (grades.studentID = @studentID AND grades.courseID = courses.ID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@studentID", student.getID());

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add(reader["courseName"], reader["grade"]);
            }

            con.Close();
        }

        private void PrintStudentEmptyGrades(Student student, DataTable table)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT courses.name AS courseName " +
               "FROM courses " +
               "JOIN courses_groups ON courses.ID = courses_groups.courseID " +
               "JOIN students ON students.groupID = courses_groups.groupID " +
               "LEFT JOIN grades ON courses.ID = grades.courseID AND students.ID = grades.studentID " +
               "WHERE students.ID = @studentID AND grades.studentID IS NULL;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@studentID", student.getID());

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add(reader["courseName"], "");
            }

            con.Close();
        }

        public DataTable PrintStudentGrades(Student student)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Grade");

            PrintStudentSetGrades(student, table);
            PrintStudentEmptyGrades(student, table);

            return table;
        }

        public List<Course> PrintLecturersCourses(Lecturer lecturer)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM courses WHERE lecturerID = @lecturerID";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@lecturerID", lecturer.getID());

            List<Course> courses = new List<Course>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string name = Convert.ToString(reader["name"]);
                string lecturerID = Convert.ToString(reader["lecturerID"]);

                Course course = new(ID, name, lecturerID);
                courses.Add(course);
            }
            con.Close();

            return courses;
        }

        private void PrintSetGradesByCourseAndGroup(Course course, Group group, DataTable table)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT students.ID AS studentID, students.name AS studentName, " +
                "students.surname AS studentSurname, grades.grade AS grade " +
                "FROM students, grades, courses " +
                "WHERE (@groupID = students.groupID AND students.ID = grades.studentID " +
                "AND grades.courseID = courses.ID AND courses.ID = @courseID)";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@groupID", group.ID);
            cmd.Parameters.AddWithValue("@courseID", course.ID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add(reader["studentID"], reader["studentName"], reader["studentSurname"], reader["grade"]);
            }
            con.Close();
        }

        private void PrintEmptyGradesByCourseAndGroup(Course course, Group group, DataTable table)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT students.ID AS studentID, students.name AS studentName, " +
                "students.surname AS studentSurname " +
                "FROM students " +
                "WHERE students.groupID = @groupID " +
                "AND NOT EXISTS ( " +
                "        SELECT 1 FROM grades " +
                "        WHERE grades.studentID = students.ID " +
                "        AND grades.courseID = @courseID " +
                ")";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@groupID", group.ID);
            cmd.Parameters.AddWithValue("@courseID", course.ID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add(reader["studentID"], reader["studentName"], reader["studentSurname"], "");
            }
            con.Close();
        }

        public DataTable PrintGradesByCourseAndGroup(Course course, Group group)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Surname");
            table.Columns.Add("Grade");

            PrintSetGradesByCourseAndGroup(course, group, table);
            PrintEmptyGradesByCourseAndGroup(course, group, table);

            return table;
        }
    }
}
