using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace PraktikumWinForms.Database
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            string host = "localhost";
            string port = "5432";
            string db = "db_praktikumwinforms";
            string username = "postgres";
            string password = "passwordcuyyy";

            connectionString = $"Host={host};Port={port};Database={db};Username={username};Password={password}";
        }

        public NpgsqlConnection getConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            return conn;
        }

    }
}
