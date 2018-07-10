using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD___3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ilgis = 24;
            var plotis = 18;
            var kvatratoKaina = 15;
            var kvadratura = ilgis * plotis * 1.05;
            var atsakymas = kvadratura * kvatratoKaina;
            Console.WriteLine("atsakymas = "+ atsakymas);



        }
    }
}
