using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigiama skaicius");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius <= 0)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }
    }
}
