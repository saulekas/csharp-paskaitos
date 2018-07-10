using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 30; i < 60; i++)
            {
                if (1 % 2 != 0)
                {
                    suma += i;

                }
            }
            Console.WriteLine("atsakymas: "+suma);
        }
    }
}
