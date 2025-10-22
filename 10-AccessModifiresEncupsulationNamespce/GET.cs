using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiresEncupsulationNamespce
{
    internal class GET
    {
        private int _horsePower;
        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                if (value < 100)
                {
                    Console.WriteLine("pleace set correct power");
                    return;
                }
                _horsePower = value;
            }
        }
    }
}
