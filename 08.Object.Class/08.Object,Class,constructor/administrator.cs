using System;
using _08.Object_Class_constructor;

namespace MyUniversity
{
    public class Administrator : person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public void AdminInfo()
        {
            Console.WriteLine("------------------------------");
            BasicInfo();
            Console.WriteLine($"Vezife: {Position}");
            Console.WriteLine($"Şöbe: {Department}");
            Console.WriteLine($"Giriş seviyyesi: {AccessLevel}");
            Console.WriteLine("------------------------------");
        }

        public void GrantAccess(Student student)
        {
            Console.WriteLine($"{student.GetFullName()} adlı telebeye sistem girişi verildi.");
        }
    }
}

