using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DoAn.DAL
{
    class DataHelper
    {
        // Example of class Secret.cs
        // Remember to create the class in DAL Folder
        //        using System;
        //using System.Collections.Generic;
        //using System.Linq;
        //using System.Text;
        //using System.Threading.Tasks;

        //namespace DoAn.DAL
        //    {
        //        public class Secret
        //        {

        //            public string connectionString;

        //            public Secret()
        //            {
        //                connectionString = "server=IP;database=ThuVienDB;user=User;password=Password;";
        //            }
        //        }
        //    }





        Secret secret = new Secret();
        private string connectionString ;
        public DataHelper()
        {
            connectionString = secret.connectionString;
        }
        
        public MySqlConnection GetConnection() 
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
