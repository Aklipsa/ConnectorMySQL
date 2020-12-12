using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace DataBase
{
    class  ConnectS
    {
        public static MySqlConnection Connection;
        MySqlConnectionStringBuilder ConnBuilder;        

        public void openConnection()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
                       
        }

        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();                
        }

        public void ServerConnect(Tuple<string, string, string, string> User) {

            ConnBuilder = new MySqlConnectionStringBuilder();

            ConnBuilder.Server   = User.Item1;
            ConnBuilder.UserID   = User.Item2;
            ConnBuilder.Database = User.Item3;
            ConnBuilder.Password = User.Item4;

            ConnBuilder.OldGuids = true;
            ConnBuilder.CharacterSet = "utf8";

            Connection = new MySqlConnection(ConnBuilder.ConnectionString);
        }

        public MySqlConnection ServerConnect()
        {   
            return Connection;
        }
               
        public uint getPort()
        {
            return ConnBuilder.Port;
        }
    } 
}
