using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("iveskite du skaicius");
                var skaicius1 = Convert.ToInt32(Console.ReadLine());
                var skaicius2 = Convert.ToInt32(Console.ReadLine());
                var suma = skaicius1 + skaicius2;
                var skirtumas = skaicius1 - skaicius2;
                var sandauga = skaicius1 * skaicius2;
                var dalyba = (double)skaicius1 / skaicius2;
                Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, suma);
                Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skirtumas);
                Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, sandauga);
                Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, dalyba);

                Console.WriteLine("ar norite testi?  Taip/Ne");
                var veiksmas = (Console.ReadLine());
                if (veiksmas != "taip")
                {
                    break;

                }





            }
        }
    }
}
