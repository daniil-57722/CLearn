using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLearn
{
    public class DBHandler
    {
        public string server = "localhost";
        public string port = "3306";
        public string user = "root";
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=b11");
    
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            connection.Open();
        }


        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
       
        public string getType()
        {
            return "DBHandler";
        }
        public string getServer()
        {
            return server;
        }
        public string getUser()
        {
            return user;
        }
        public string getPort()
        {
            return port;
        }
    }
}
