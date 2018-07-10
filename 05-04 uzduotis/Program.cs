using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivseskite penkis savo [azymius");
            var pazimys1 = Convert.ToInt32(Console.ReadLine());
            var pazimys2 = Convert.ToInt32(Console.ReadLine());
            var pazimys3 = Convert.ToInt32(Console.ReadLine());
            var pazimys4 = Convert.ToInt32(Console.ReadLine());
            var pazimys5 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (double)(pazimys1 + pazimys2 + pazimys3 + pazimys4 + pazimys5) / 5;
            Console.WriteLine("vidurki " + vidurkis);
            if (vidurkis >= 5)
            {
                Console.WriteLine("vidurkis didesnis uz 5");
            }
        }
    }
}
