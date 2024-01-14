using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adtabekeres_try_catch_Tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adatbekérés két módon");
            int szam1 = adatBeker("Kérek egy számot:");
            Console.WriteLine($"A kapott szám: {szam1}");
            int szam2 = adatBeker_New("Kérek egy számot:");
            Console.WriteLine($"A kapott szám: {szam2}");

            Console.ReadKey();
        }

        private static int adatBeker_New(string v)
        {
            int szam;
            while (true)
            {
                Console.Write(v);
                try
                {
                    szam = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch 
                {

                    Console.WriteLine("Hibás adat bevitel!");
                }
            }
            return szam;
        }

        private static int adatBeker(string v)
        {
            int szam;
            Console.Write(v);
            while(!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("Hibás adat bevitel!");
                Console.Write(v);
            }
            return szam;
        }
    }
}
