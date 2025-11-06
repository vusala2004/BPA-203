using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public Student(int id, string name, string surname, int age, double grade)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Grade = grade;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"id:{Id},:{Name},Soyad{Surname},yas:{Age},qiymet:{Grade}");
        }
        public override string ToString()
        {
            return $"id:{Id},:{Name},Soyad{Surname},yas:{Age},qiymet:{Grade}";
        }
    }
}

