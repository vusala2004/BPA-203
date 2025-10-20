using _08.Object_Class_constructor;
using System;

namespace MyUniversity
{
        internal class Teacher : person
        {
            public string Department;
            public string MainSubject;
            public decimal BaseSalary;
            public int ExperienceYears;
            public void TeacherInfo()
            {
                Console.WriteLine("------------------------");
                BasicInfo();
                Console.WriteLine($"Kafedra: {Department}");
                Console.WriteLine($"Esas fenn: {MainSubject}");
                Console.WriteLine($"Baza maaş: {BaseSalary}");
                Console.WriteLine($"Tecrübe ili: {ExperienceYears}");
            }

            public decimal CalculateSalary()
            {
                return BaseSalary + (ExperienceYears * 50);
            }
        }
}

	

