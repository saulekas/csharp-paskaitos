﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_08_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;

            }
            Console.WriteLine("Atsakymas: "+suma);
        }
    }
}
