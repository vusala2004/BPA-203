using System;
using System.Xml.Linq;

namespace _08.Object_Class_constructor
{
    public class person
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Email;
            public string Id;


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual void BasicInfo()
        {
            Console.WriteLine($"Ad: {FirstName}");
            Console.WriteLine($"Soyad: {LastName}");
            Console.WriteLine($"Yaş: {Age}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"ID: {Id}");
        }
    }
}


