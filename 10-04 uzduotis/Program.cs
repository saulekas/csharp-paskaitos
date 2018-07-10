using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sakinys = "";

            while (true)
            {

                Console.Write("Iveskite zodi arba exit: ");
                var zodis = (Console.ReadLine());

                if (zodis != "exit")
                {
                    sakinys += zodis + " ";
                }
                else
                {
                    break;

                }

            }

            Console.WriteLine("atsakymas: " + sakinys);
        }
    }
}
