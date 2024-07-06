using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class UserDao
    {
        private MySQLConnection mySQLConnection;
        private List<User> users = new List<User>();

        public UserDao()
        {
            mySQLConnection = new MySQLConnection();
        }
        
        public List<User> getUsers(string QUERY)
        {
            string query = "";
            MySqlDataReader reader = null;

            try
            {
                if (QUERY != "")
                {
                    query += $"SELECT {QUERY};";
                }
                else
                {
                    query += "SELECT * FROM user;";
                }
                MySqlCommand command = new MySqlCommand(query);
                command.Connection = mySQLConnection.GetConnection();
                reader = command.ExecuteReader();

                User user;
                while (reader.Read())
                {
                    user = new User();
                    user.user_id = reader.GetInt32("user_id");
                    user.password = reader.GetString("password");
                    user.name = reader.GetString("name");
                    user.type = reader.GetString("type");
                    user.active = reader.GetBoolean("active");
                    users.Add(user);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return users;
        }
    }
}
