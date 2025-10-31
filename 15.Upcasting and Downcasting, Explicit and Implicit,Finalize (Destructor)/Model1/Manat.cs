using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Model1
{
    internal class Manat
    {
        public decimal AZN { get; set; }
        public Manat(decimal azn)
        {
            AZN = azn;
        }
        public static implicit operator Dollar(Manat manat) 
        { 
            return new Dollar(manat.AZN/1.7m);
        }
    }
}
