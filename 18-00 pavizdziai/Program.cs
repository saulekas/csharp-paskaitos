using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_00_pavizdziai
{
    class Studentas
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public string Universitetas;
        public string StudijuPrograma;
        public string Grupe;
        public int Kursas;

        // ctor
        public Studentas()
        {

        }

        public Studentas(string vardas, string pavarde, int amzius, string universitetas, string studijuPrograma, string grupe, int kursas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Universitetas = universitetas;
            StudijuPrograma = studijuPrograma;
            Grupe = grupe;
            Kursas = kursas;

        }

        public void Isvedimas()
        {
            Console.WriteLine("________________");
            Console.WriteLine("Studento {0} {1} ({2} m.) duomenys", Vardas, Pavarde, Amzius);
            Console.WriteLine("__________________");
            Console.WriteLine("Universitetas: " + Universitetas);
            Console.WriteLine("Studiju programa: " + StudijuPrograma);
            Console.WriteLine("Grupe: " + Grupe);
            Console.WriteLine("Kursas: " + Kursas);
            Console.WriteLine("_____________________");
            Console.WriteLine();

        }



    }
    class Program
    {
        static void Main(string[] args)

        {
            int sphdg = 55;
            var petras1 = new Studentas();
            var petras2 = new Studentas();

            petras1.Vardas = "Petras";
            petras1.Pavarde = "Petraitis";
            petras1.Amzius = 25;
            petras1.Universitetas = "KTU";
            petras1.StudijuPrograma = "Programu sistemos";
            petras1.Grupe = "PS-4/2";
            petras1.Kursas = 4;

            /* Console.WriteLine(petras1.Vardas);
             Console.WriteLine(petras1.Pavarde);
             Console.WriteLine(petras1.Amzius);
             Console.WriteLine(petras1.Universitetas);
             Console.WriteLine(petras1.StudijuPrograma);
             Console.WriteLine(petras1.Grupe);
             Console.WriteLine(petras1.Kursas);*/

            petras2.Vardas = "Jonas";
            petras2.Pavarde = "Jonaitis";
            petras2.Amzius = 21;
            petras2.Universitetas = "KTU";
            petras2.StudijuPrograma = "Dizainas";
            petras2.Grupe = "D/K2";
            petras2.Kursas = 2;

            petras1.Isvedimas();
            petras2.Isvedimas();

            var studentas = new Studentas("Jonas", "Jonaitis", 33, "VDU", "Kataliku teologija", "nezinau", 1);
            studentas.Isvedimas();

            var grupe = new List<Studentas>();
            grupe.Add(new Studentas("qwert", "TYUIO", 18, "KK", "ABC", "AF-54", 3));
            grupe.Add(new Studentas("qwert", "TGFD", 20, "Kt", "kfC", "KF-54", 3));
            grupe.Add(new Studentas("DEWQ", "BVFD", 25, "YT", "MHG", "YT-41", 3));
            grupe.Add(new Studentas("DESVH", "PLKIUY", 23, "TG", "DER", "TG-55", 3));
            grupe.Add(new Studentas("KUMM", "UJHGT", 21, "Tk", "KUY", "TK-54", 3));
            foreach (var stud in grupe)
            {
                stud.Isvedimas();

            }
            var programa = new Program();

            var vyriausias = programa.VyriausiasStudentas(grupe);
            Console.WriteLine("Vyriausias studentas");
            vyriausias.Isvedimas();

            Console.WriteLine("Vyriausiuas studentas");
            programa.VyriausiasStudentas(grupe).Isvedimas();

            Console.WriteLine("Jauniausias studentas");
            programa.JauniausiasStudentas(grupe).Isvedimas();

            var jauniausias = programa.JauniausiasStudentas(grupe);
            Console.WriteLine("Jauniausias studentas");
            jauniausias.Isvedimas();



        }


        public Studentas VyriausiasStudentas(List<Studentas> grupe)
        {
            var vyriausias = grupe.First();



            foreach (var studentas in grupe)
            {
                if (studentas.Amzius > vyriausias.Amzius)
                {
                    vyriausias = studentas;

                }

            }
            return vyriausias;

        }
        public Studentas JauniausiasStudentas(List<Studentas> grupe)
        {
            var jauniausias = grupe.First();

            foreach (var studentas in grupe)
            {
                if (studentas.Amzius < jauniausias.Amzius)

                {
                    jauniausias = studentas;
                }
                
            }
            return jauniausias;



        }
    }
}
