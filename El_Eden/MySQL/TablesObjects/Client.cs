using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class Client
    {
        public int client_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string tel_number { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string neighborhood { get; set; }
        public double total_sales { get; set; }
        public int enabled { get; set; }

        public Client(){}
        public Client(int client_id, string first_name, string last_name, string tel_number, string email, string address, string neighborhood, int enabled)
        {
            this.client_id = client_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.tel_number = tel_number;
            this.email = email;
            this.address = address;
            this.neighborhood = neighborhood;
            this.enabled = enabled;
        }
    }
}
