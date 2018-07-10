using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite egzamino rezultata");
            var rezultatas = Convert.ToInt32(Console.ReadLine());
            if (rezultatas == 100)
            {
            Console.WriteLine("rezultatas lygus 100");
            }
            else if (rezultatas >= 80)
            {
            Console.WriteLine("rezultatas lygus arba didesnis uz 80");
            }
            else if (rezultatas >= 50)
            {
            Console.WriteLine("rezultatas lygus arba didesnis uz 50");
            }
            else if (rezultatas >= 20)
            {
            Console.WriteLine("rezultatas lygus arba didesnis uz 20");
            }
            else if (rezultatas < 20)
            {
            Console.WriteLine("rezultatas mazesnis uz 20");
            }
        }
    }
}
