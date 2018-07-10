using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var vienas = Convert.ToInt32(Console.ReadLine());
            var du = Convert.ToInt32(Console.ReadLine());
            var trys = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double)(vienas + du + trys) / 3;
            Console.WriteLine();
            Console.WriteLine("Skaiciu {0}, {1}, {2} vidurkis: {3}", vienas, du, trys, vidurkis);



        }
    }
}
