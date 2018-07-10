using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaicius");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            
            {
                Console.WriteLine("Neteisingai!!!!!!!");
                
            }
            if (skaicius > 0)
            {
                Console.WriteLine("sveikiname !!!");

            }
            if (skaicius % 2 == 0)
               
            {
                Console.WriteLine("Skaicius lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine("skaicius dalinasi is keturiu");
               
            }
            if (skaicius > 10)
            {
                Console.WriteLine("skaicius didesnis uz 10");

            }


        }
    }
}
