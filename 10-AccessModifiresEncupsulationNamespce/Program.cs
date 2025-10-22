namespace _10_AccessModifiresEncupsulationNamespce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GET get=new GET();
            get.HorsePower = 200;
            Console.WriteLine(get.HorsePower);
        }
    }
}
