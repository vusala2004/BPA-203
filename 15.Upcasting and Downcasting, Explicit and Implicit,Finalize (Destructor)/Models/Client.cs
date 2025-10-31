

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Models
{
    internal class Client:Person
    {
        public string Bank { get; set; }
        public Client(string name, int age, string company,string bank):base(name,age)
        {
            Bank = bank;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Bank:{Bank}");
        }
    }
}
