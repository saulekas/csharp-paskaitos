using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_00_pavizdziai
{
    class Gyvunas
    {
        public string KailioSpalva { get; private set; }
        public string KailioIlgis { get; private set; }
        public int KojuKiekis { get; private set; }
        public int Amzius { get; private set; }

        public Gyvunas() { }
        public Gyvunas(string kailioSpalva, string kailioIlgis, int kojuKiekis, int amzius)
        {
            KailioSpalva = kailioSpalva;
            KailioIlgis = kailioIlgis;
            KojuKiekis = kojuKiekis;
            Amzius = amzius;

        }
        public void isvedimas()
        {
            Console.WriteLine("Kailis {0}, jo spalva {1},);
        }
    }
}
