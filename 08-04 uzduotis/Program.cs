using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkite:");
            Console.WriteLine("1-stacionarus kompiuteris");
            Console.WriteLine("2-nesiojamas kompiuteris");
            Console.WriteLine("3-plancete");

            var skaicius = Convert.ToInt32(Console.ReadLine());

            switch (skaicius)
            {
                case 1: Console.WriteLine("pasirinkote personalini kompiuteri");
                    break;
                case 2: Console.WriteLine("pasirinkote nesiojama kompiuteri");
                    break;
                case 3: Console.WriteLine("plancetinis kompiuteris");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;
            }
        }
    }
}
