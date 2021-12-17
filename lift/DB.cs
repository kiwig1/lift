using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lift
{
    internal class DB
    {
        MySqlConnection connection=new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");
        public void openconnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getconnection()
        {
            return connection;
        }
    }
}
