using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class Product
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
    }
}
