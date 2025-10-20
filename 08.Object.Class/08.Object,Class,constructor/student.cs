using System;
using _08.Object_Class_constructor;


namespace MyUniversity
{
    public class Student : person
    {
        public string StudentNumber;
        public string Faculty;
        public double GPA;
        public int Year;

        public void StudentInfo()
        {
            Console.WriteLine("-----------------------------");
            BasicInfo();
            Console.WriteLine($"T3lebe nömresi: {StudentNumber}");
            Console.WriteLine($"Fakülte: {Faculty}");
            Console.WriteLine($"Kurs: {Year}");
            Console.WriteLine($"GPA: {GPA}");
        }

        public double CalculateScholarship()
        {
            if (GPA >= 90) return 500;
            else if (GPA >= 80) return 350;
            else if (GPA >= 70) return 200;
            else return 0;
        }
    }
}
