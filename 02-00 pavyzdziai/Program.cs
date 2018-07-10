using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Saulius";
            var pavarde = "Kemzura";
            var amzius = 39;

            Console.WriteLine("Labas");
            Console.WriteLine("Krabas");

            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);
            Console.WriteLine("Vardas: "+ vardas);
            Console.WriteLine("Pavarde: "+ pavarde);
            Console.WriteLine("Amzius: "+ amzius);

            Console.WriteLine("Vardas: {0}", vardas);
            Console.WriteLine("Pavarde: {0}", pavarde);
            Console.WriteLine("Ämzius: {0}", amzius);

            Console.WriteLine("Vardasir pavarde: " + vardas + " " +pavarde);
            Console.WriteLine("Vardas ir pavarde: {0} {1}", vardas, pavarde);

            Console.WriteLine(vardas + " " +pavarde + " (" + amzius + " m.)");
            Console.WriteLine("{0} {1} ({2} m.)", vardas, pavarde, amzius);

            var marke = "Dodge";
            var modelis = "GrandCaravan";
            var metai = 1997;
            var spalva = "Ruda";

            Console.WriteLine();


                }
    }
}
