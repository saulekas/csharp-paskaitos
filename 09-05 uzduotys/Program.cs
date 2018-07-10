using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_05_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite rezio pradzia");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite reziu pabaiga");
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine("{0} {1}", i, i * i);
                }
            }
        }
    }
}
