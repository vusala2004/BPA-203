using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Models
{
    public abstract class Person
    {
        public  string Name{ get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name; Age = age;
        }
        public virtual void  DisplayInfo()
        {
            Console.WriteLine($"Ad:{Name}, Yas{Age}");
        }
        
            
        
    }
}
