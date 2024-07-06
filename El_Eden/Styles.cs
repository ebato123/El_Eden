using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Eden
{
    internal static class Styles
    {
        public static void label_MouseEnter(Label label)
        {
            label.BackColor = Color.LemonChiffon;
            label.ForeColor = Color.Black;
        }
        public static void label_MouseLeave(Label label)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = Color.LemonChiffon;
        }
    }
}
