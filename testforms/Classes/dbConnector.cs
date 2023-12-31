﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes
{
    public class dbConnector
    {
        private string server;
        private string database;
        private string username;
        private string password;

        public dbConnector()
        {
            server = "localhost";
            database = "ais";
            username = "root";
            password = "";
        }

        public string GetConString()
        {
            string constring =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            return constring;
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection(GetConString());
            return con;
        }
    }
}
