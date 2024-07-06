using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class User
    {
        public int user_id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public bool active { get; set; }
    }
}
