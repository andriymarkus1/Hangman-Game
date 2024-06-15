using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Markup;

namespace Шибениця_2._0
{
    class DataBaseHangman
    {
        private string connectionString;
        public string login { get; set; }
        public UserDataBaseManager UserManager { get; private set; }
        public GameDataBaseManager GameManager { get; private set; }
        public ShopDataBaseManager ShopManager { get; private set; }

        public DataBaseHangman(string login)
        {
            this.login = login;
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataBaseHangman.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\Desktop\\Шибеницяu\\Шибениця 2.0\\DataBaseHangman.mdf\";Integrated Security=True";
            UserManager = new UserDataBaseManager(connectionString, login);
            GameManager = new GameDataBaseManager(connectionString, login);
            ShopManager = new ShopDataBaseManager(connectionString, login);
        }
    }

}