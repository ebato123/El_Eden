using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL
{
    internal class MySQLConnection : ConnectionData
    {
        string connectionString;
        private MySqlConnection connection;

        public MySQLConnection()
        {
            connectionString = $"Database={dataBase}" +
                               $"; DataSource={server}" +
                               $"; User Id={user}" +
                               $"; Password={password}";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            try 
            {
                if(connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(),"ERROR: al intentar conectar con la Base de Datos.");
            }
            return connection; 
        }
        public MySqlConnection CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR: al intentar cerrar la conexión con la Base de Datos.");
            }
            return connection;
        }
    }
}
