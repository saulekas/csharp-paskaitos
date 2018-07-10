using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var skaiciusvienas = Convert.ToInt32(Console.ReadLine());
            var skaiciusdu = Convert.ToInt32(Console.ReadLine());
            if (skaiciusvienas > skaiciusdu)
            {
                Console.WriteLine("skaicius vienas didesnis uz skaiciu du");
              
            }
            else if (skaiciusdu > skaiciusvienas)
            {
                Console.WriteLine("skaicius du didesnis uz skaicius vioenas");

            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
        }
    }
}
