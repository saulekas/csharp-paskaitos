using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkite:");
            Console.WriteLine("1-vanduo");
            Console.WriteLine("2-kava");
            Console.WriteLine("3-arbata");
            Console.WriteLine("4-kakava");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("vanduo");
                    break;
                case 2:
                    Console.WriteLine("kava");
                    break;
                case 3:
                    Console.WriteLine("arbata");
                    break;
                case 4:
                    Console.WriteLine("kakava");
                    break;
                default:
                    Console.WriteLine("nera tokio pasirinkimo");
                    break;
            }
            // vartotojas iveda pasirinkima

            // switch tikrina pasirinkima
        }
    }
}
