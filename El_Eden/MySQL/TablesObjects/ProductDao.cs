using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class ProductDao
    {
        private MySQLConnection mySQLConnection;
        private List<Product> products = new List<Product>();

        public ProductDao()
        {
            mySQLConnection = new MySQLConnection();
        }
        
        public List<Product> getProducts(string query)
        {
            string QUERY = "";
            MySqlDataReader reader = null;

            try
            {
                if (query != "")
                {
                    QUERY += $"SELECT {query};";
                }
                else
                {
                    QUERY += "SELECT * FROM product;";
                }
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = mySQLConnection.GetConnection();
                reader = command.ExecuteReader();

                Product product;
                while (reader.Read())
                {
                    product = new Product();
                    product.product_id = reader.GetInt32("product_id");
                    product.name = reader.GetString("name");
                    product.description = reader.GetString("description");
                    product.stock = reader.GetInt32("stock");
                    products.Add(product);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return products;
        }

        internal bool addProduct(Product product)
        {
            string INSERT = "INSERT INTO product (name, description, stock)" +
                            "VALUES (@name, @description, @stock)";

            MySqlCommand command = new MySqlCommand(INSERT, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@name", product.name));
            command.Parameters.Add(new MySqlParameter("@description", product.description));
            command.Parameters.Add(new MySqlParameter("@stock", product.stock));

            return command.ExecuteNonQuery() > 0;
        }

        internal bool modifyProduct(Product product)
        {
            string UPDATE = "UPDATE product SET" +
                            "   name=@name, " +
                            "   description=@description, " +
                            "   stock=@stock" +
                            "WHERE product_id = @product_id;" ;

            MySqlCommand command = new MySqlCommand(UPDATE, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@product_id", product.product_id));
            command.Parameters.Add(new MySqlParameter("@name", product.name));
            command.Parameters.Add(new MySqlParameter("@description", product.description));
            command.Parameters.Add(new MySqlParameter("@stock", product.stock));

            return command.ExecuteNonQuery() > 0;
        }

        internal bool deleteProduct(Product product)
        {
            string DELETE = "DELETE FROM producto WHERE product_id=@product_id";

            MySqlCommand command = new MySqlCommand(DELETE, mySQLConnection.GetConnection());

            command.Parameters.Add(new MySqlParameter("@product_id", product.product_id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
