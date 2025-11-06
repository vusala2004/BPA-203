using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            List<Student> studentList = new List<Student> {

             new Student(1, "Ali", "Məmmədov", 20, 85.5),
             new Student(2, "Leyla", "Həsənova", 19, 92.0),
             new Student(3, "Vüqar", "Əliyev", 21, 78.5),
             new Student(4, "Nigar", "Əhmədova", 20, 88.0),
             new Student(5, "Rəşad", "Quliyev", 22, 95.5)
            };
            

           
            Console.WriteLine(" Directory əməliyyatları:");

            
            if (fileManager.DirectoryExists())
            {
                fileManager.DirectoryDelete();
            }

            fileManager.CreateDirectory();
            
            if (fileManager.DirectoryExists())
                Console.WriteLine("Qovluq uğurla yaradıldı ");
            else
                Console.WriteLine("Qovluq yaradılmadı ");

            Console.WriteLine("\n──────────────────────────────────────────────\n");


            Console.WriteLine("Tələbələr fayla yazılır...");

            Console.WriteLine("\n— hamsin yazma:");
          
                fileManager.WriteAllStudentsToFile(studentList);

            Console.WriteLine("\n— Toplu yazma:");
            fileManager.WriteAllStudentsToFile(studentList);

            Console.WriteLine("\n──────────────────────────────────────────────\n");

            
            Console.WriteLine(" Fayldan oxuma prosesi:");
            List<Student> readStudents = fileManager.ReadStudentsFromFile();

            Console.WriteLine($"\nFayldan {readStudents.Count} tələbə oxundu.\n");
            foreach (var s in readStudents)
                s.DisplayInfo();

            Console.WriteLine("\n──────────────────────────────────────────────\n");

            Console.WriteLine("JSON Serialization:");
            fileManager.SaveStudentsToJson(studentList);
            Console.WriteLine($"JSON faylı yaradıldı: {fileManager.JsonFilePath}");

            Console.WriteLine("\n──────────────────────────────────────────────\n");

          
            Console.WriteLine(" JSON Deserialization:");
            List<Student> jsonStudents = fileManager.LoadStudentsFromJson();

            Console.WriteLine($"\nJSON-dan {jsonStudents.Count} tələbə yükləndi.\n");
            foreach (var s in jsonStudents)
                s.DisplayInfo();

            Console.WriteLine("\n──────────────────────────────────────────────\n");

            // 🔹 7. Fayl əməliyyatları test
            Console.WriteLine(" Fayl məzmunları:\n");

            Console.WriteLine("— students.txt faylı (CSV formatı):");
            Console.WriteLine(File.ReadAllText(fileManager.TextFilePath));

            Console.WriteLine("\n— students.json faylı (JSON formatı):");
            Console.WriteLine(File.ReadAllText(fileManager.JsonFilePath));

            Console.WriteLine("\n──────────────────────────────────────────────\n");

            // 🔹 8. Statistika
            Console.WriteLine(" Statistika:");
            int total =studentList.Count;
            double avg = 0, max = double.MinValue, min = double.MaxValue;
            int highScoreCount = 0;

            foreach (var s in studentList)
            {
                avg += s.Grade;
                if (s.Grade > max) max = s.Grade;
                if (s.Grade < min) min = s.Grade;
                if (s.Grade >= 90) highScoreCount++;
            }

            avg /= total;

            Console.WriteLine($"Ümumi telebe sayı: {total}");
            Console.WriteLine($"Orta qiymet: {avg:F2}");
            Console.WriteLine($"en yüksək qiymet: {max}");
            Console.WriteLine($"en aşağı qiymet: {min}");
            Console.WriteLine($"90+ qiymet alan telebe sayı: {highScoreCount}");

            FileInfo txtInfo = new FileInfo(fileManager.TextFilePath);
            FileInfo jsonInfo = new FileInfo(fileManager.JsonFilePath);

            Console.WriteLine($"Text fayl ölçüsü: {txtInfo.Length} bayt");
            Console.WriteLine($"JSON fayl ölçüsü: {jsonInfo.Length} bayt");

            Console.WriteLine("\n Proqram uğurla tamamlandı!");
        }
    }
}

