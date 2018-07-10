using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_00_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "jusu vardas:");
            var vardas = Console.ReadLine();

            Console.WriteLine("jusu pavarde?");
            var pavarde = Console.ReadLine();

            Console.WriteLine("Ka vairuojate");
            var auto = Console.ReadLine();


            Console.WriteLine("jusu amzius?");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu ugi?");
            var ugisTekstas = Console.ReadLine();
            var ugis = Convert.ToDouble(ugisTekstas);


            Console.WriteLine("Gyvenamoji vieta?");
            var vieta = Console.ReadLine();

            Console.WriteLine("Korteles numeris?");
            var kortelesNr = Console.ReadLine();

          


            Console.WriteLine("pin kodas?");
            var pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gimimo data ?");
            var gimimoData = Console.ReadLine();

            Console.WriteLine("lytis");
            var lytris = Console.ReadLine();

            Console.WriteLine("Jusu suvesti duomenys:");
            Console.WriteLine(vardas + " " + pavarde);
            Console.WriteLine("jusu vairuojamas automobilis: " + auto);
            Console.WriteLine("jusu ugis: " + ugis);
            Console.WriteLine("jusu amzius:" + amzius);
            Console.WriteLine("Jusu gyvenamoji vieta:" + vieta);
            Console.WriteLine("Gimimo data:" + gimimoData);


            Console.WriteLine("Gyvuno vardas?");
            var gyvunoVardas = Console.ReadLine();
            Console.WriteLine("kailio spalva?");
            var kailioSpalva = Console.ReadLine();
            Console.WriteLine("kilme?");
            var kilme = Console.ReadLine();
            Console.WriteLine("rusis?");
            var rusis = Console.ReadLine();
            Console.WriteLine("greitis?");
            var greitis = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine( gyvunoVardas);
            Console.WriteLine("Kailio spalva:" + kailioSpalva);
            Console.WriteLine("kilme:" + kilme);
            Console.WriteLine("rusis:" + rusis);
            Console.WriteLine("greitis:" + greitis);

            Console.WriteLine("Iveskite 5 sveikus skaicius viena po kito: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var trecias = Convert.ToInt32(Console.ReadLine());
            var ketvirtas = Convert.ToInt32(Console.ReadLine());
            var penktas = Convert.ToInt32(Console.ReadLine());
            var suma = pirmas + antras + trecias + ketvirtas + penktas;
            Console.WriteLine("skaiciu suma: " + suma);
            Console.WriteLine(pirmas + " " + penktas);

          

            


        }
    }
}
