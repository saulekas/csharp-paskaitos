using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_00_pavizdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var ugiai = new List<int>();
            ugiai.Add(170);
            ugiai.Add(156);
            ugiai.Add(182);
            ugiai.Add(158);
            ugiai.Add(160);
            ugiai.Add(175);
            ugiai.Add(168);

            Console.WriteLine("Ugiai: ");
            foreach (var ugis in ugiai)

            {
                Console.WriteLine(ugis + " ");

            }
            Console.WriteLine();

            var suma = 0;
            for (int i = 0; i < ugiai.Count; i++)
            {
                suma += ugiai[i];
            }
            var vidurkis = (double)suma / ugiai.Count;

            Console.WriteLine("vidurkis: " + vidurkis);
            // maziausias ugis
            // didziausias ugis

            var min = ugiai.First();

            foreach (var ugis in ugiai)

            {

                if (ugis < min)

                {
                    min = ugis;

                }

            }
            Console.WriteLine("maziausias: " + min);


            var max = ugiai.First();

            foreach (var ugis in ugiai)

            {
                if (ugis > max)
                {
                    max = ugis;
                }
            }
            Console.WriteLine("didziausias: " + max);

            // kiek ugiu yra didesniu uiz vidurki
            var didesniUzVidurki = 0;
            foreach (var ugis in ugiai)
            {
                if (ugis > vidurkis)
                {
                    didesniUzVidurki++;
                }
            }
            Console.WriteLine("Didesniu uz vidurki kiekis: " +didesniUzVidurki);
        }
    }
}
