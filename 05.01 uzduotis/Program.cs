using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris sveikuosius skaicisu");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());
            if (skaicius1 == skaicius2)
            {
                Console.WriteLine("skaicius1 lygus skaicius2");

            }


            if (skaicius2 == skaicius3)
            {
                Console.WriteLine("skaicius 2 lygus skaicius3");

            }
            if (skaicius1 > skaicius2 )
                Console.WriteLine("skaicius1 didesnis uz skaicius2");

            if (skaicius2 > skaicius3 * 2)
            {
                Console.WriteLine("skaicius2 didesnis uz skaicius3");
            }

            if (skaicius1 % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius lygus 0");
            }
            if (skaicius2 % 2 != 0)
            {
                Console.WriteLine("skaicius2 nera lygus 0");
            }
            if (skaicius3 > 0)
            {
                Console.WriteLine("skaicius3 yra teigiamas");
            }
            if (skaicius3 < 0)
            {
                Console.WriteLine("skaicius3 yra neigiamas");
            }
        }
            
    }
}
