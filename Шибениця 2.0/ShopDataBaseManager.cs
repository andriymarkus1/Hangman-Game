using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шибениця_2._0
{
    class ShopDataBaseManager : DataBaseManager
    {
        public ShopDataBaseManager(string connectionString, string login) : base(connectionString, login)
        {
        }

        public void SetGallow1Bought()
        {
            UpdateUserColumnBool("Is_Gallows_1_Bought", true);
        }

        public void SetGallow2Bought()
        {
            UpdateUserColumnBool("Is_Gallow_2_Bought", true);
        }

        public void SetSkin1Bought()
        {
            UpdateUserColumnBool("Is_Skin_1_Bought", true);
        }

        public void SetSkin2Bought()
        {
            UpdateUserColumnBool("Is_Skin_2_Bought", true);
        }

        public bool IsGallow1Bought()
        {
            return IsBoughtOrSet("Is_Gallows_1_Bought");
        }

        public bool IsGallow2Bought()
        {
            return IsBoughtOrSet("Is_Gallow_2_Bought");
        }

        public bool IsSkin1Bought()
        {
            return IsBoughtOrSet("Is_Skin_1_Bought");
        }

        public bool IsSkin2Bought()
        {
            return IsBoughtOrSet("Is_Skin_2_Bought");
        }

        public void SetSetSkinNumb(int value)
        {
            UpdateUserColumnInt("Skin_Set_Numb", value);
        }

        public void SetSetGallowNumb(int value)
        {
            UpdateUserColumnInt("Gallow_Set_Numb", value);
        }

        public int GetSetSkinNumb()
        {
            return GetUserColumnInt("Skin_Set_Numb");
        }

        public int GetSetGallowNumb()
        {
            return GetUserColumnInt("Gallow_Set_Numb");
        }

        private bool IsBoughtOrSet(string columnName)
        {
            bool isBoughtOrSet = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT {columnName} FROM Users WHERE Id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isBoughtOrSet = Convert.ToBoolean(result);
                    }
                }
            }

            return isBoughtOrSet;
        }
        private void UpdateUserColumnBool(string columnName, bool value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"UPDATE Users
                             SET {columnName} = @Value
                             WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateUserColumnInt(string columnName, int value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"UPDATE Users
                             SET {columnName} = @Value
                             WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Value", value);

                    command.ExecuteNonQuery();
                }
            }
        }

        private int GetUserColumnInt(string columnName)
        {
            int value = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT {columnName} FROM Users WHERE Id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        value = Convert.ToInt32(result);
                    }
                }
            }
            return value;
        }
    }
}
