using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_06_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite reziu pradzia");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("iveskite reziu pabaiga");
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
                
        }
    }
}
