using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Model1
{
    internal class Dollar
    {
        public decimal USD { get; set; }
        public Dollar(decimal usd)
        {
            USD=usd;

        }
        public static explicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }
    }
}
