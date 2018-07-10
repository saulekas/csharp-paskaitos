using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)

            {
                Console.WriteLine(" skaicius vienas didziausias");
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("skaicius2 didziausias");
            }
            else if (skaicius3 > skaicius2 && skaicius3 > skaicius1)
            {
                Console.WriteLine("skaicius3 didziausias");
            }
            else
                Console.WriteLine("visi skaiciai lygus");



        }
    }
}
