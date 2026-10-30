using Npgsql;
using PraktikumWinforms.Models;
using PraktikumWinForms.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace PraktikumWinforms.Repositories
{
    public class UserRepository
    {
        DatabaseHelper db;

        public UserRepository()
        {
            db = new DatabaseHelper();
        }

        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using var conn = db.getConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                ));
            }
            return list;
        }


        // CREATE
        public void AddUser(User user)
        {
            using var conn = db.getConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();


        }


        // UPDATE
        public void UpdateUser(User user)
        {
            using var conn = db.getConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);
            cmd.ExecuteNonQuery();
        }


        // DELETE
        public void DeleteUser(int id)
        {
            using var conn = db.getConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM users WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
