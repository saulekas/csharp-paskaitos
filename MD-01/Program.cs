using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var metai = 7;
            var menesiai = metai * 12;
            var dienos = metai * 365;
            var valandos = dienos * 24;
            Console.WriteLine("menesiai " + menesiai);
            Console.WriteLine("dienos " + dienos);
            Console.WriteLine("valandos " + valandos);

        }
    }
}
