using MyUniversity;
using _08.Object_Class_constructor;
using MyUniversity;
class Program
{
    static void Main(string[] args)
    {
        // Tələbələr
        Student student1 = new Student()
        {
            FirstName = "Aysel",
            LastName = "Eliyeva",
            Age = 20,
            Email = "aysel@gmail.com",
            Id = "S001",
            StudentNumber = "TK-101",
            Faculty = "Kibernetika",
            GPA = 88.5,
            Year = 3
        };

        Student student2 = new Student()
        {
            FirstName = "Murad",
            LastName = "Hesenov",
            Age = 22,
            Email = "murad@gmail.com",
            Id = "S002",
            StudentNumber = "TK-102",
            Faculty = "Riyaziyyat",
            GPA = 92.0,
            Year = 4
        };

        Student student3 = new Student()
        {
            FirstName = "Nigar",
            LastName = "Quliyeva",
            Age = 19,
            Email = "nigar@gmail.com",
            Id = "S003",
            StudentNumber = "TK-103",
            Faculty = "İnformasiya texnologiyaları",
            GPA = 68.5,
            Year = 2
        };

        // Müəllimlər
        Teacher teacher1 = new Teacher()
        {
            FirstName="Zaur",
            LastName= "Memmedov",
            Age=45,
            Email="zaur@gmail.com",
           Id= "T001",
            Department="Kibernetika",
           MainSubject= "OOP",
           BaseSalary= 800m,
           ExperienceYears= 15
            };

        Teacher teacher2 = new Teacher()
        {
            FirstName = "Fidan",
            LastName = "Esedova",
            Age = 38,
           Email= "fidan@gmail.com",
           Id= "T002",
            MainSubject="Riyaziyyat",
           Department= "Calculus",
           BaseSalary= 850m,
            ExperienceYears=8
        };

        // İdarəçi
        Administrator admin = new Administrator() {
           FirstName= "Kamran",
           LastName= "Eliyev",
           Age= 50,
            Email="kamran@gmail.com",
           Id= "A001",
           Position= "Dekan",
           Department= "Kompüter Elmləri",
          AccessLevel=  5};

        student1.StudentInfo();
        Console.WriteLine($"Teqaüd: {student1.CalculateScholarship()} ");

        student2.StudentInfo();
        Console.WriteLine($"Teqaüd: {student2.CalculateScholarship()} ");

        student3.StudentInfo();
        Console.WriteLine($"Teqaüd: {student3.CalculateScholarship()} ");

        teacher1.TeacherInfo();
        Console.WriteLine($"Maaş: {teacher1.CalculateSalary()} ");

        teacher2.TeacherInfo();
        Console.WriteLine($"Maaş: {teacher2.CalculateSalary()} ");

        admin.AdminInfo();

        admin.GrantAccess(student1);

        double totalScholarship = student1.CalculateScholarship() + student2.CalculateScholarship() + student3.CalculateScholarship();
        decimal totalSalary = teacher1.CalculateSalary() + teacher2.CalculateSalary();

        Console.WriteLine($"Ümumi teqaüd xerci: {totalScholarship}");
        Console.WriteLine($"Ümumi maaş xerci: {totalSalary}");
    }
}
