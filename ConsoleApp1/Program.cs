using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gauta pazimi");
            var pazimys = Convert.ToInt32(Console.ReadLine());
            if (pazimys == 10)
            {
                Console.WriteLine("puikiai");
            }
            else if (pazimys >=8)
            {
                Console.WriteLine("labai gerai");
           
            }
            else if (pazimys >= 5)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (pazimys >= 3)
            {
                Console.WriteLine("prastai");
            }
            else if (pazimys >= 1)
            {
                Console.WriteLine("labai blogai");
            }
        }
    }
}
