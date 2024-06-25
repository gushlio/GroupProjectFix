using System;
using System.Security.Cryptography;
using DataAccessLayer.DTOs;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserDB
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void RegisterUser(UserDTO userDTO)
        {
            byte[] salt = GenerateSalt();
            string saltBase64 = Convert.ToBase64String(salt);
            string hashedPassword = HashPassword(userDTO.Password, salt);

            string query = "INSERT INTO Users (Username, PasswordHash, Salt, RegistrationDate, Role) VALUES (@Username, @PasswordHash, @Salt, @RegistrationDate, @Role)";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", userDTO.Username);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", saltBase64);
                    command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now); 
                    command.Parameters.AddWithValue("@Role", "Customer"); 

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetUserRole(string username)
        {
            string role = null;
            string query = "SELECT Role FROM Users WHERE Username = @Username";

            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                        }
                    }
                }
            }

            return role;
        }


        public bool IsUsernameTaken(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool IsPasswordCorrect(string username, string password)
        {
            string query = "SELECT PasswordHash, Salt FROM Users WHERE Username = @Username";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(0);
                            string storedSaltBase64 = reader.GetString(1);
                            byte[] storedSalt = Convert.FromBase64String(storedSaltBase64);
                            string hashedPassword = HashPassword(password, storedSalt);
                            return storedHash == hashedPassword;
                        }
                    }
                }
            }
            return false;
        }

        private byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        private string HashPassword(string password, byte[] salt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = deriveBytes.GetBytes(20);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
