using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var simbolis = "*" ;
            Console.WriteLine(" {0}{0}{0}{0}{0} " , simbolis);
            Console.WriteLine(" {0}   {0} " , simbolis);
            Console.WriteLine(" {0}   {0} " , simbolis);
            Console.WriteLine(" {0}   {0} " , simbolis);
            Console.WriteLine(" {0}{0}{0}{0}{0} " , simbolis);

            var marke = "Porshe";
            var modelis = "911";
            var gamybos_metai = "1970";
            var rida = "15000";

            Console.WriteLine("Automobilis {0} {1} ({2} m.) ", marke, modelis, gamybos_metai);
            Console.WriteLine("yra nuvaziaves {0} km.", rida);

            /*
             
                *
               ***
              *****
               ***
              *****
             *******
                *
                *
             
             */

            var simbolis2 = "*" ;
            Console.WriteLine(" {0} " , simbolis2);
            Console.WriteLine(" {0}{0}{0} " , simbolis2);
            Console.WriteLine(" {0}{0}{0}{0} ", simbolis2);
            Console.WriteLine(" {0}{0}{0} " , simbolis2);
            Console.WriteLine(" {0}{0}{0}{0}{0} " , simbolis2);
            Console.WriteLine(" {0}{0}{0}{0}{0}{0}{0} " ,  simbolis2);
            Console.WriteLine(" {0} " , simbolis2);
            Console.WriteLine(" {0} " , simbolis2);
            










        }
    }
}
