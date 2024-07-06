using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class ClientDao
    {
        private MySQLConnection mySQLConnection;
        private List<Client> clients = new List<Client>();

        public ClientDao()
        {
            mySQLConnection = new MySQLConnection();
        }

        public List<Client> getClients(string select, string joins, string query)
        {
            string QUERY = "";
            MySqlDataReader reader = null;

            try
            {
                if (query != "")
                {
                    QUERY += $"SELECT {select} FROM client {joins} WHERE enabled = 1 {query} ;";
                }
                else
                {
                    QUERY += "SELECT * FROM client WHERE enabled = 1;";
                }
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = mySQLConnection.GetConnection();
                reader = command.ExecuteReader();

                Client client;
                while (reader.Read())
               {
                    client = new Client();
                    client.client_id = reader.GetInt32("client_id");
                    client.first_name = reader.GetString("first_name");
                    client.last_name = reader.GetString("last_name");
                    client.tel_number = reader.GetString("tel_number");
                    client.email = reader.GetString("email");
                    client.address = reader.GetString("address");
                    client.neighborhood = reader.GetString("neighborhood");
                    client.total_sales = reader.GetDouble("total_sales");
                    clients.Add(client);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return clients;
        }

        internal bool addClient(Client client)
        {
            string INSERT = "INSERT INTO client (first_name, last_name, tel_number, email, address, neighborhood)" +
                            "VALUES (@first_name, @last_name, @tel_number, @email, @address, @neighborhood)";

            MySqlCommand command = new MySqlCommand(INSERT, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@first_name", client.first_name));
            command.Parameters.Add(new MySqlParameter("@last_name", client.last_name));
            command.Parameters.Add(new MySqlParameter("@tel_number", client.tel_number));
            command.Parameters.Add(new MySqlParameter("@email", client.email));
            command.Parameters.Add(new MySqlParameter("@address", client.address));
            command.Parameters.Add(new MySqlParameter("@neighborhood", client.neighborhood));

            return command.ExecuteNonQuery() > 0;
        }

        internal bool modifyClient(Client client)
        {
            string UPDATE = "UPDATE client SET " +
                            "   first_name=@first_name, " +
                            "   last_name=@last_name, " +
                            "   tel_number=@tel_number, " +
                            "   email=@email, " +
                            "   address=@address, " +
                            "   neighborhood=@neighborhood, " +
                            "   enabled=@enabled " +
                            "WHERE client_id = @client_id;";

            MySqlCommand command = new MySqlCommand(UPDATE, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@client_id", client.client_id));
            command.Parameters.Add(new MySqlParameter("@first_name", client.first_name));
            command.Parameters.Add(new MySqlParameter("@last_name", client.last_name));
            command.Parameters.Add(new MySqlParameter("@tel_number", client.tel_number));
            command.Parameters.Add(new MySqlParameter("@email", client.email));
            command.Parameters.Add(new MySqlParameter("@address", client.address));
            command.Parameters.Add(new MySqlParameter("@neighborhood", client.neighborhood));
            command.Parameters.Add(new MySqlParameter("@enabled", client.enabled));

            return command.ExecuteNonQuery() > 0;
        }

        internal bool deleteClient(Client client)
        {
            string DELETE = "DELETE FROM client WHERE client_id=@client_id";

            MySqlCommand command = new MySqlCommand(DELETE, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@client_id", client.client_id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
