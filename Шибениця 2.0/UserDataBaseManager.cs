using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шибениця_2._0
{
    class UserDataBaseManager : DataBaseManager
    {
        public UserDataBaseManager(string connectionString, string login) : base(connectionString, login)
        {
        }

        public bool ValidateLogin(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Login = @Login AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
            }
        }
        private bool ValidateRegister(string login)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Login = @Login";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
            }
        }
        public bool RegisterUser(string login, string password)
        {
            if (!ValidateRegister(login))
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Login, Password) VALUES (@Login, @Password)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            command.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException)
                        {
                            return false;
                        }
                    }
                }
            return false;
        }

        public void UpdateLastLogInInfo(string login, bool value)
        {
            int userId = GetUserIdByLogin(login);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"UPDATE Users
                             SET Is_Last_Login_in = @Value
                             WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetLastLogin()
        {
            string username = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Login
                             FROM Users 
                             WHERE Is_Last_Login_in = @value";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", true);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["Login"].ToString();
                        }
                    }
                }
            }
            return username;
        }
    }
}
