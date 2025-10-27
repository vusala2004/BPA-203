

using _12.Interface_Abstraction_Static_Members.Interface;

namespace _12.Interface_Abstraction_Static_Members
{
    internal  class Calculation : ICalculation
    {
      

        public double Calculate(double X,double Y,string operation)
        {
            switch (operation)
            {
                case "+": return X + Y;   // toplama
                case "-": return X - Y;   // çıxma
                case "*": return X * Y;   // vurma
                case "/":
                    if (Y == 0)
                    {
                        Console.WriteLine("xeta 0-a bolme yoxdur"); return 0;
                    }
                    return Y != 0 ? X / Y : 0;  // bölmə
                default:
                    Console.WriteLine ("Düzgün əməl daxil edilməyib!");
                    return 0;
            }


        }

    }
}


            

        
    

