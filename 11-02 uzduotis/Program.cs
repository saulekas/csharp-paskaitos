using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i*i;

            }
            Console.WriteLine("atsakymas: " +suma);

            var suma2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma2 += i;
            }
            suma2 = suma2 * suma2;
            Console.WriteLine("atsakymas2: " +suma2);

            var atsakymas = suma2 - suma;
            Console.WriteLine("atsakymas: " +atsakymas);
        }
    }
}
