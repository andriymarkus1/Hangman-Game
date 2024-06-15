using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шибениця_2._0
{
    class DataBaseManager
    {
        protected string connectionString;
        public string login { get; set; }
        protected int userId;
        public DataBaseManager(string connectionString, string login)
        {
            this.connectionString = connectionString;
            this.login = login;
            if (!string.IsNullOrEmpty(login))
            {
                userId = GetUserIdByLogin(login);
            }
        }

        protected int GetUserIdByLogin(string login)
        {
            int userId = 1;
            if (!string.IsNullOrEmpty(login))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT Id FROM Users WHERE Login = @Login";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            return userId;
        }
        public int GetNumbOfDashes()
        {
            int dashes = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Numb_Of_Dashes
                             FROM Users 
                             WHERE Id = @userId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dashes = Convert.ToInt32(reader["Numb_Of_Dashes"]);
                        }
                    }
                }
            }
            return dashes;
        }
        public void UpdateUserDashesBalance(int value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"UPDATE Users
                             SET Numb_Of_Dashes = @Value
                             WHERE Login = @Login";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
