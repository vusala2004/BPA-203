using _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Model1;
using _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_.Models;
using System.Security.Cryptography.X509Certificates;

namespace _15.Upcasting_and_Downcasting__Explicit_and_Implicit_Finalize__Destructor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region upcasting-downcasting
            //Employee employee = new Employee("Vusala", 21, "Microsoft");
            //Client client = new Client("Vuqar", 23, "beynalxal","ABB");
            ////implicit-Upcasting(employeeni ve clienti persona cevirdik)
            ////Person person = employee;
            ////Person person1 = client;
            ////Console.WriteLine(person.Age);
            ////Console.WriteLine(person.Name);
            ////Console.WriteLine("-------------------------------------------");
            ////Console.WriteLine(person1.Age);
            ////Console.WriteLine(person1.Name);


            ////Explicit-Downcasting(personu employee ve cliente ceviririk)
            ////Employee employee1 =(Employee)person;
            ////Client client1 =(Client)person1;
            ////Console.WriteLine(employee1.Company);
            ////Console.WriteLine(employee1.Age);
            ////Console.WriteLine(employee1.Name);
            ////Console.WriteLine("---------------------------------");
            ////Console.WriteLine(client1.Bank);
            ////Console.WriteLine(client1.Name);
            ////Console.WriteLine(client1.Age);

            ////downcastingin basqa formalari

            //Person[] persons = { employee, client };
            //foreach (Person person in persons)
            //{
            //    //Employee employee1=(Employee) person;
            //    Employee employee1 = person as Employee;
            //    Console.WriteLine(employee1.Company);

            //} 
            #endregion



            Dollar dollar = new(200);
            Manat manat = new(170);

            Manat manat1 = (Manat)dollar;
            Console.WriteLine(manat1.AZN);









            //boxing (value tipi referansa cevirir)*butun tipler objectden miras alir
            //int n = 30;
            //object m = n;

            ////unboxing(referans tipi value tipe cevirir)
            //int c=(int)m;
            //Console.WriteLine(m);

            

        }
        
    } 
    }




//public struct Test:ITestable
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//}
//public interface ITestable
//{
//   public  int X { get; set; }
//}


