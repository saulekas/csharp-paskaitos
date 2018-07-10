using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00_cilklas_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i + " ");
            }
            for (int i = 0; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 25; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            var suma = 0;
            for (int i = 0; i < 100; i++)
            {
                suma += i;

            }
            Console.WriteLine("suma:  " + suma);

            var sandauga = 1;

            for (int i = 1; i <= 10; i++)
            {
                sandauga *= i;

            }
            Console.WriteLine("sandauga: " + sandauga);

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
            var lyginiuSuma = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    lyginiuSuma += i;
                }
            }
            Console.WriteLine("lyginiu suma: " + lyginiuSuma);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0)
                {
                    break; //iseiti is ciklo, nutraukti

                }

            }
            Console.WriteLine();
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // 2, 4, 6, 8, 10

            for (int i = 2 ; i <= 10; i += 2)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}