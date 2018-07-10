using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda ir amziu");
            var vardas = (Console.ReadLine());
            var amziu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("jusu vardas " + vardas + ", o amzius " +amziu);

        }
    }
}
