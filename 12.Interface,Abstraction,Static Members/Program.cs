using _12.Interface_Abstraction_Static_Members.Interface;
using System.Security.Cryptography.X509Certificates;

namespace _12.Interface_Abstraction_Static_Members
{
    public class  Program
    {
        public static void Main(string[] args)
        {



     
            {
                ICalculation calc = new Calculation();
                Console.Write("Birinci ededi daxil edin:");
                double x=Convert.ToDouble(Console.ReadLine());

                Console.Write("ikinci ededi daxil edin:");
                double y=Convert.ToDouble(Console.ReadLine());

                Console.Write("emeliyyat daxil edin:");
                string op=Console.ReadLine();

                double result=calc.Calculate(x, y,op);
                Console.WriteLine($"netice: {result}");

               
            }
        }




    }
}
    
 

            



        
   

