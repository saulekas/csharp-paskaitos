using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite viena norima skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Sakiaucius neigiamas");
            }
            else if (skaicius > 0)
            {
                Console.WriteLine("skaicius teigiamas");
            }
            else
                Console.WriteLine("skaicius lygus 0");

        }
        
	
	
    }
}
