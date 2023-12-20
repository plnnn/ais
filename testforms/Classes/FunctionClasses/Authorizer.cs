using kotyk.Classes.dbObjects;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes.FunctionClasses
{
    public class Authorizer
    {
        public Authorizer() { }

        private MySqlDataReader Authorization(string table, string username, string password)
        {
            dbConnector dbConnector = new();
            MySqlConnection con = dbConnector.GetConnection();
            con.Open();

            string query = "SELECT * FROM " + table + " " +
                "WHERE (username = @username AND password = @password)";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public Administrator AdministratorAuthorization(string username, string password)
        {
            MySqlDataReader reader = Authorization("administrators", username, password);

            if (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);

                Administrator administrator = new(ID, username, password, name, surname);

                return administrator;
            }
            else
            {
                Feedbacker errorHandler = new Feedbacker();
                errorHandler.WrongCredentials();
                return null;
            }
        }

        public Lecturer LecturerAuthorization(string username, string password)
        {
            MySqlDataReader reader = Authorization("lecturers", username, password);

            if (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);

                Lecturer lecturer = new(ID, username, password, name, surname);

                return lecturer;
            }
            else
            {
                Feedbacker errorHandler = new Feedbacker();
                errorHandler.WrongCredentials();
                return null;
            }
        }

        public Student StudentAuthorization(string username, string password)
        {
            MySqlDataReader reader = Authorization("students", username, password);

            if (reader.Read())
            {
                string ID = Convert.ToString(reader["ID"]);
                string name = Convert.ToString(reader["name"]);
                string surname = Convert.ToString(reader["surname"]);
                string groupID = Convert.ToString(reader["groupID"]);

                Student student = new(ID, username, password, name, surname, groupID);

                return student;
            }
            else
            {
                Feedbacker errorHandler = new Feedbacker();
                errorHandler.WrongCredentials();
                return null;
            }
        }
    }
}
