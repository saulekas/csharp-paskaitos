using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_uzduotis____1
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbovalandos = 8;
            Console.WriteLine("Kiek darbuotojas iskeps kepalu per valanda ?");
            var kepalupervalanda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kiek darbuotoju turi kepykla?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vieno kepalo savikaina?");
            var kepalosavikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vieno kepalo pardavimo kaina?");
            var pardavimokaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kiek kepykla per diena turi uzsakymu?");
            var uzsakymaiperdiena = Convert.ToInt32(Console.ReadLine());

            var kepaluperdiena = darbovalandos * kepalupervalanda * darbuotojai;

            var visukepalusavikaina = kepaluperdiena * kepalosavikaina;
            var pajamos = kepaluperdiena * pardavimokaina;
            var pelnas = pajamos - visukepalusavikaina;

            Console.WriteLine("kepalu per diena " + kepaluperdiena);
            Console.WriteLine("visu kepalu savikaina " + visukepalusavikaina);
            Console.WriteLine("pajamos " + pajamos);
            Console.WriteLine("pelnas " + pelnas);

            if (uzsakymaiperdiena < kepaluperdiena)
            {
                Console.WriteLine("spes iskepti");

            }
            else if (uzsakymaiperdiena > kepaluperdiena)
            {
                var neiskepskepalu = kepaluperdiena - uzsakymaiperdiena;
                Console.WriteLine("neiskeps kepalu: " + neiskepskepalu * -1);

                
            }
            
            
           

        }
    }
}
