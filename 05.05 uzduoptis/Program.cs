using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._05_uzduoptis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius % 5 == 0)
            {
                var daugiklis = 1;
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} ={2}", skaicius, daugiklis, skaicius * daugiklis++);
            }
        }
    }
}
