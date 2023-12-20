using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace bebra
{
    public class Validator
    {
        public Validator() { }

        public bool IsUsernameValid(string table, string username)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM " + table + " WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", username);
            
            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }
            con.Close();

            return (cnt == 0);
        }

        public bool IsCourseNameValid(string name)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM courses WHERE name = @name";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", name);

            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }
            con.Close();

            return (cnt == 0);
        }

        public bool IsGroupCodeValid(string code)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM groups WHERE code = @code";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@code", code);

            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }
            con.Close();

            return (cnt == 0);
        }

        public bool IsThereCourseGroupRecord(Course course, Group group)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT COUNT(*) FROM courses_groups WHERE (courseID = @courseID AND groupID = @groupID)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@courseID", course.ID);
            cmd.Parameters.AddWithValue("@groupID", group.ID);

            int cnt = 0;
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                cnt = Convert.ToInt32(result);
            }
            con.Close();

            return (cnt > 0);
        }
    }
}
