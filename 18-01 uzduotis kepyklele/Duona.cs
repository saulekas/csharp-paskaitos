using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_01_uzduotis_kepyklele
{
    class Duona
    {
        public string Pavadinimas { get; private set; }
        public double Savikaina { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }

        public Duona(string pavadinimas, double savikaina, double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Savikaina = savikaina;
            Kaina = kaina;
            Kiekis = kiekis;

        }
        public void isvedimas()
        {
            Console.WriteLine("Duona: " + Pavadinimas);
            Console.WriteLine("Savikaina ir kaina:  {0} eur / {1} eur", Savikaina, Kaina);
            Console.WriteLine();






        }
        public double pelnas()
        {
            return (Kaina - Savikaina) * Kiekis;

        }
        public void Parduoti(int kiek)
        {
            if (Kiekis >= kiek)
            {
                Kiekis -= kiek;

            }
            else
            {
                Console.WriteLine("Nepakankamas duonos likutis uzsakymui.");
            }
        }

    }
}