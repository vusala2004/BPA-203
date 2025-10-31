

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Models
{
    internal class Employee:Person
    {
        public  string Company{ get; set; }
        public Employee(string name,int age,string company):base(name,age)
        {
            Company = company;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Company{Company}");
        }

    }
}
