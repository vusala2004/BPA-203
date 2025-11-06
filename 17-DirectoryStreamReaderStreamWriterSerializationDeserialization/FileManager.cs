using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization
{
    internal class FileManager
    {
        public string FolderPath { get; set; }
        public string TextFilePath { get; set; }
        public string JsonFilePath { get; set; }
        public FileManager()
        {
            FolderPath = "StudentData";
            TextFilePath = "StudentData/students.txt";
            JsonFilePath = "StudentData/students.json";
        }
        public void CreateDirectory()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine($"qovluq yaradildi:{FolderPath}");
            }
            Console.WriteLine("qovluq movcuddur");
        }
        public void DirectoryDelete()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.Delete(FolderPath, true);
                Console.WriteLine($"Qovluq silindi: {FolderPath}");
            }
            Console.WriteLine("qovluq silinib");
        }
        public bool DirectoryExists()
        {
            return Directory.Exists(FolderPath);
        }
        public void WriteStudent(Student student)
        {
           

            using (StreamWriter writer = new StreamWriter(TextFilePath, true))
            {
                writer.WriteLine(student.ToString());
            }

            Console.WriteLine($"Tələbə fayla yazıldı: {student.Name}");
        }
        public void WriteAllStudentsToFile(List<Student> students)
        {
           
            File.WriteAllText(TextFilePath,"");

            using (StreamWriter writer = new StreamWriter(TextFilePath))
            {
                foreach (Student student in students)
               writer.WriteLine(student.ToString());
            }

            Console.WriteLine($"Ümumi {students.Count} tələbə fayla yazıldı.");
        }
        public List<Student> ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();

            if (!File.Exists(TextFilePath))
            {
                Console.WriteLine("Fayl tapılmadı.");
                return students;
            }

            using (StreamReader reader = new StreamReader(TextFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        Student s = new Student(

                            int.Parse(parts[0]),
                            parts[1],
                            parts[2],
                            int.Parse(parts[3]),
                           double.Parse(parts[4])
                           );
                        
                        students.Add(s);
                    }
                }
            }
            Console.WriteLine($"Fayldan {students.Count} tələbə oxundu.");
            return students;
        }

        public void SaveStudentsToJson(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonFilePath, json);
            Console.WriteLine("Tələbələr JSON formatında yadda saxlanıldı.");
        }

       
        public List<Student> LoadStudentsFromJson()
        {
            List<Student> students = new List<Student>();

            if (!File.Exists(JsonFilePath))
            {
                Console.WriteLine("JSON faylı tapılmadı.");
                return students;
            }

            string json = File.ReadAllText(JsonFilePath);
            students = JsonSerializer.Deserialize<List<Student>>(json);
            Console.WriteLine($"JSON-dan {students.Count} tələbə yükləndi.");

            return students;
        }

    }
}
