


namespace _16_GenericTypesCollections.Models
{
    internal class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int PageCount { get; set; }
    public Book(int id, string title, string author, int year, int pagecount)
    {
        this.Id = id;
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.PageCount = pagecount;

    }
    public void DisplayInfo()
    {
        Console.WriteLine($"[ID]:{Id} ,Başlıq{Title} - Müəllif{Author} (İl){Year} - Səhifə sayı{PageCount}");
    }
}
}

