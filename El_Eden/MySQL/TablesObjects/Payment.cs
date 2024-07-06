using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden.MySQL.TablesObjects
{
    internal class Payment
    {
        int payment_id { get; set; }
        double amount { get; set; }
        DateTime payment_date { get; set; }
        int client_id { get; set; }
        int user_id { get; set; }
        string pay_way { get; set; }
    }
}
