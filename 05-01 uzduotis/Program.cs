using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var skaiciai = new List<int>();
            var kiek = random.Next(20, 100);
            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(random.Next(1, 100));

            }
            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }
            Console.WriteLine();

            //maziasias skaicius
            var min = skaiciai.First();
            foreach (var skaicius in skaiciai)
            {
                if (skaicius < min)
                {
                    min = skaicius;
                }
            }
            Console.WriteLine("maziausias skaicius: " + min);


            //didziausias skaicius
            var max = skaiciai.First();
            foreach (var skaicius in skaiciai)


            {
                if (skaicius > max)

                {
                    max = skaicius; 
                }
            }
            Console.WriteLine("didziausias skaicius: "+ max);

            var suma = 0;

            foreach (var skaicius in skaiciai)
            {
                suma += skaicius;

            }
            var vidurkis = suma / skaiciai.Count;
            Console.WriteLine("vidurkis: "+vidurkis);

            var mazesnisUzVidurki = 0;
            foreach (var skaicius in skaiciai)

            {
                if (skaicius < vidurkis)
                {
                    mazesnisUzVidurki++;
                }
               

            }
            Console.WriteLine("mazesnius uz vidurki: " + mazesnisUzVidurki);

            var lyginiaiSkaiciuSuma = 0;

            foreach (var skaicius in skaiciai)
            {
                if (skaicius % 2 == 0) 
                {
                    lyginiaiSkaiciuSuma += skaicius;

                }
            }
            Console.WriteLine("lyginiu skaivciu suma: "+lyginiaiSkaiciuSuma);

        }
    }
}
