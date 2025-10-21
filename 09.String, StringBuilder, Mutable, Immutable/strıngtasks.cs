
//task1.verilmis string: "I am Backend DEVELOPER I LEARN C#"
//Verilmis string-de sait herflewrin tapilmasi

using System.Security.Cryptography.X509Certificates;

namespace _09string
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //            string[] str = { "I", "am", "Backend", "DEVELOPER", "I", "LEARN", "C#" };//burada cumleni array seklinde yazdim
            //            char[] saitler = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            //            int say = 0;

            //            // arrayleri birlesdirdim cumle yazdim
            //            string cumle = "";
            //            for (int i = 0; i < str.Length; i++)
            //            {
            //                cumle += str[i] + " ";
            //            }


            //            cumle = cumle.ToLower(); // kiçik hərf olsun

            //            //// Hər bir hərfi saitle muqayise
            //            for (int i = 0; i < cumle.Length; i++)
            //            {
            //               for (int j = 0; j < saitler.Length; j++)
            //               {
            //                    if (cumle[i] == saitler[j])
            //                   {
            //                       say++;
            //                    }
            //               }
            //           }

            //            Console.WriteLine("\nSait herflerin sayi: " + say);
            //        }
            //    }
            //}



            //task2 
            //.Verilmish string-de sozlerin bosluga gore sayi.
            //        string cumle = " I am Backend DEVELOPER I LEARN C";

            //            int bosluq=cumle.Split(' ').Length-1;
            //        Console.WriteLine("bosluq sayi=" + bosluq);
            //    }
            //}
            //}


            //task3
            //Verilmiş stringin-in ən uzun sözünü ekrana çıxaran proqram yazın
            //        string cumle = " I am Backend DEVELOPER I LEARN C";
            //        string[]  words=cumle.Split(' ');
            //        string longest=words[0];
            //        foreach (var word in words)
            //        {
            //            if (word.Length > longest.Length)
            //            {
            //                longest = word;
            //            }
            //        }
            //        Console.WriteLine("en uzun söz: " + longest);
            //    }
            //    }
            //}


            //task4
            //Verilmiş string-in bütün hərfləri böyük olan sözün özünü və indeksini çapa çıxaran proqram yazın.
            //            string cumle = " I am Backend DEVELOPER I LEARN C";
            //            string[] words = cumle.Split(' ');
            //            Console.WriteLine(words.Length);
            //            for (int i = 0; i < words.Length; i++)
            //            {
            //                if (words[i] == words[i].ToUpper())
            //                {
            //                    Console.WriteLine($"boyuk herfli soz:{words[i]},indeksi:{i}");
            //                }
            //            }
            //        }
            //    }
            //}


            //task5.
            //Verilmiş string-in 2-dən artıq böyük hərfi olan elementlərini çapa çıxaran proqram yazın
    //        string cumle = " I am Backend DEVELOPER I LEARN C";
    //        string[] words = cumle.Split(' ');
            
    //            foreach (string word in words)
    //            {
    //                int boyuk = 0;
    //                {
    //                    foreach (char ch in word)
    //                    {
    //                        if (char.IsUpper(ch)) boyuk++;
    //                    }
    //                    if (boyuk > 2)
    //                    {
    //                        Console.WriteLine(word);
    //                    }
    //                }

    //            }
    //        }
    //    }
    //}
