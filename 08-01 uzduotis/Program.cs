using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());
            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine(skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    break; 
                default:
                    break;
            }
        }
    }
}
