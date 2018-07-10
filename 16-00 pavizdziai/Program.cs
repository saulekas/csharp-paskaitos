using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_00_pavizdziai
{
    class Program
    {
        static void Main(string[] args)
        {

            var programa = new Program();

            /*
            Pasisveikinti();
            PasisveikintiSuVardu();
            Skaiciuotuvas();
            programa.Pasisveikinti2();
            


            programa.Pasisveikinti3("Saulius", "Kemzura");
            programa.Pasisveikinti4("Saulius");

            var suma = programa.Suma(10, 3);
            Console.WriteLine(suma);

            Console.WriteLine(programa.Suma(7, 5));

            Console.WriteLine("iveskite du skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var suma3 = programa.Suma(skaicius1, skaicius2);
            Console.WriteLine(suma3);

            Console.WriteLine(programa.Suma(skaicius1, skaicius2));
            */
            programa.SkaiciuotuvasMandras();
            var vardas = "hgfh";
            var pavarde = "sgfhghrfgh";
            programa.Ivedimas(ref vardas, ref pavarde);
            Console.WriteLine("naujas vardas: " + vardas);
            Console.WriteLine("naujas pavarde: " + pavarde);





        }
        public static void Pasisveikinti()
        {
            Console.WriteLine("Labas");
        }
        public static void PasisveikintiSuVardu()
        {
            Console.WriteLine("koks jusu vardas?");
            var vardas = Console.ReadLine();
            Console.WriteLine("Labas, " + vardas);
        }
        public static void Skaiciuotuvas()
        {
            Console.WriteLine("iveskite du skaicius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, pirmas + antras);
            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, pirmas * antras);
        }
        public void Pasisveikinti2()
        {
            Console.WriteLine("Kas jus esate toks????");
            var vardas = (Console.ReadLine());
            Console.WriteLine("Ate " + vardas);
        }

        public void Pasisveikinti3(string vardas, string pavarde)

        {
            Console.WriteLine("Labas," + vardas + " " + pavarde);
        }
        public void Pasisveikinti4(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);

        }
        public int Suma(int pirmas, int antras)
        {
            /*var suma = pirmas + antras;
             return suma;*/
            return pirmas + antras;

        }
        public int Skirtumas(int pirmas, int antras)
        {
            return pirmas - antras;

        }
        public int Sandauga(int pirmas, int antras)
        {
            return pirmas * antras;

        }
        public double Dalmuo(int pirmas, int antras)
        {
            return (double)pirmas / antras;




        }
        public void SkaiciuotuvasMandras()

        {
            Console.WriteLine("Iveskite du skaicius");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = Suma(pirmas, antras);
            var skirtumas = Skirtumas(pirmas, antras);
            var sandauga = Sandauga(pirmas, antras);
            var dalmuo = Dalmuo(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, sandauga);
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, dalmuo);

        }
        public void Ivedimas(ref string vardas, ref string pavarde)
        {
            Console.WriteLine("Dabartiniai duomenys:");
            Console.WriteLine("vardas: " + vardas);
            Console.WriteLine("pavarde: " + pavarde);

            Console.WriteLine("Naujas vardas: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Nauja pavarde: ");
            pavarde = Console.ReadLine();
        }




    }

}
