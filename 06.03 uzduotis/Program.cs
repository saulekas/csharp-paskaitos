using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sios dienos oro temperatura");
            var temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura < 0)
            {
                Console.WriteLine("ziauriai slata");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("Labai salta");

            }
            else if (temperatura < 20)
            {
                Console.WriteLine("salta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("normali temperatura");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("karsta");
            }
            else if (temperatura > 40)
            {
                Console.WriteLine("visiskai degina");
            }
        }
    }
}
