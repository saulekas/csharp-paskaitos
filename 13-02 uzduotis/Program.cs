using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek duomenu ivesti?");
            int kiek = Convert.ToInt32(Console.ReadLine());
            string[] dydziai = new string[kiek];
            for (int i = 0; i < dydziai.Length; i++)
            {
                Console.WriteLine("iveskite teksta: ");
                dydziai[i] = Console.ReadLine();
            }
            foreach (var dydis in dydziai)

            {
                Console.WriteLine(dydis + " ");
            }
            Console.WriteLine();
        }
    }
}
