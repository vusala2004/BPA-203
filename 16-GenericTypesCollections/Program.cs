using _16_GenericTypesCollections.Models;
using System.Xml.Linq;

namespace _16_GenericTypesCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            Book book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            Book book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            Book book4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Library<Book> millikitabxana = new Library<Book>("Milli Kitabxana");
            millikitabxana.Add(book1);

            millikitabxana.Add(book2);

            millikitabxana.Add(book3);

            millikitabxana.Add(book4);

            millikitabxana.Add(book5);

            Console.WriteLine($"Kitabxana: {millikitabxana.Name}");
            Console.WriteLine($"kitab sayi: {millikitabxana.Count}");
            Console.WriteLine("indeks 0-daki kitab");
            millikitabxana.FindByIndex(0).DisplayInfo();
            Console.WriteLine("indeks 2-deki kitab");
            millikitabxana.FindByIndex(2).DisplayInfo();

            foreach(var book in millikitabxana.GetAll())
            {
                book.DisplayInfo();
            }

            List<Member> members = new List<Member>();
            members.Add(new Member(1, "Ali Məmmədov", "ali@mail.com"));
            members.Add(new Member(2, "Leyla Həsənova", "leyla@mail.com"));
            members.Add(new Member(3, "Vüqar Əliyev", "vuqar@mail.com"));
            members[0].BorrowBook(book1);
            members[1].BorrowBook(book2);
            foreach (var member in members)
            {
                member.DisplayBorrowedBooks();
            }
            members[0].ReturnBook(1);
            members[0].DisplayBorrowedBooks();
            members[0].BorrowBook(book3);
            members[0].BorrowBook(book4);
            members[0].BorrowBook(book5);
            members[0].BorrowBook(book1); // limit xəbərdarlığı

           
            Console.WriteLine("\n=== 4. Müəllifə görə axtarış ===");
            BookManager manager = new BookManager();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            void ShowBooksByAuthor(string author)
            {
                var list = manager.GetBooksByAuthor(author);
                Console.WriteLine($"\nMüəllif: {author} (tapıldı {list.Count} kitab)");
                foreach (var b in list)
                    b.DisplayInfo();
            }

            ShowBooksByAuthor("George Orwell");
            ShowBooksByAuthor("Cingiz Aytmatov");
            ShowBooksByAuthor("Jack London");
            ShowBooksByAuthor("Dostoyevski");

          
            Console.WriteLine("\n=== 5. Gözləmə növbəsi ===");
            manager.AddToWaitingQueue("Nigar");
            manager.AddToWaitingQueue("Rəşad");
            manager.AddToWaitingQueue("Səbinə");
            Console.WriteLine($"Növbədə: {manager.WaitingQueue.Count} nəfər");

            string served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmət edilir: {served}");
            Console.WriteLine($"Qalan: {manager.WaitingQueue.Count}");

           
            Console.WriteLine("\n=== 6. Son qaytarılan kitablar (Stack) ===");
            manager.ReturnBook(book1);
            manager.ReturnBook(book2);
            manager.ReturnBook(book3);
            Console.WriteLine($"Stack-də kitab sayı: {manager.RecentlyReturned.Count}");

            var last = manager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarılan kitab: {last.Title}");

            manager.RecentlyReturned.Pop();
            Console.WriteLine($"Stack-də indi kitab sayı: {manager.RecentlyReturned.Count}");
            last = manager.GetLastReturnedBook();
            Console.WriteLine($"Yeni son qaytarılan kitab: {last.Title}");

         
            Console.WriteLine("\n=== 7. Axtarış testi ===");
            var found = manager.SearchByTitle("1984");
            if (found != null)
                Console.WriteLine($"Tapıldı: {found.Title} - {found.Author}");
            else
                Console.WriteLine("Kitab tapılmadı.");

            var notFound = manager.SearchByTitle("Harry Potter");
            if (notFound == null)
                Console.WriteLine("Harry Potter tapılmadı (null).");

           
            Console.WriteLine("\n=== 8. Statistika ===");
            Console.WriteLine($"Ümumi kitab sayı: {manager.Books.Count}");
            Console.WriteLine($"Ümumi üzv sayı: {members.Count}");
            Console.WriteLine($"Növbədə nəfər sayı: {manager.WaitingQueue.Count}");
            Console.WriteLine($"Stack-də kitab sayı: {manager.RecentlyReturned.Count}");

            int minYear = int.MaxValue;
            int maxYear = int.MinValue;
            foreach (var b in manager.Books)
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }

            Console.WriteLine($"Ən köhnə kitab ili: {minYear}");
            Console.WriteLine($"Ən yeni kitab ili: {maxYear}");
        }
    }
}


        
