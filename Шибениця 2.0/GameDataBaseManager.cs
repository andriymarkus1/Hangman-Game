using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шибениця_2._0
{
    class GameDataBaseManager : DataBaseManager
    {

        public GameDataBaseManager(string connectionString, string login) : base(connectionString, login)
        {
        }

        public (string word, string topic) GetRandomWord()
        {
            string word = string.Empty;
            string topic = string.Empty;
            int length = DifficultyLevel.GetNumbOfLetters();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT TOP 1 Word, Topic 
                             FROM Words 
                             WHERE Numb_Of_Letters = @Length 
                             ORDER BY NEWID()";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Length", length);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            word = reader["Word"].ToString();
                            topic = reader["Topic"].ToString();
                        }
                    }
                }
            }

            return (word, topic);
        }


    }
}
