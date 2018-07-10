using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_05_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ïveskite triju egzaminu rezultatus");
            var pazimys1 = Convert.ToInt32(Console.ReadLine());
            var pazimys2 = Convert.ToInt32(Console.ReadLine());
            var pazimys3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = pazimys1 + pazimys2 + pazimys3 / 3
        }

    }
}
