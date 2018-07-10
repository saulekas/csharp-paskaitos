using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius");
            var laipsniai = Convert.ToInt32(Console.ReadLine());
            var kelvinas = (laipsniai + 273.15);
            var farengeitai = (laipsniai * 1.8 + 32);
            Console.WriteLine(laipsniai);
            Console.WriteLine(kelvinas);
            Console.WriteLine(farengeitai);
        }
    }
}
