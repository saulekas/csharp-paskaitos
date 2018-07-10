using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01_masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 8, 5, 6, 5, 8, 6 };
            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[2]);
            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[4]);
            Console.WriteLine(pazymiai[5]);

            int[] pazymiai2 = new int[6];
            pazymiai2[0] = 8;
            pazymiai2[1] = 5;
            pazymiai2[2] = 6;
            pazymiai2[3] = 5;
            pazymiai2[4] = 8;
            pazymiai2[5] = 6;
            Console.WriteLine(pazymiai2[3]);
            Console.WriteLine(pazymiai2[2]);
            Console.WriteLine(pazymiai2[5]);
            Console.WriteLine(pazymiai2[1]);


            string[] marke =
            {
                "ford",
                "mazda",
                "dodge",
                "opel"

            };
            Console.WriteLine(marke[0]);
            Console.WriteLine(marke[1]);
            Console.WriteLine(marke[2]);


            Console.WriteLine(marke.Length);
            Console.WriteLine("First: {0}", marke.First());

            Console.WriteLine("Last {0}", marke.Last());

       
        }
    }
}
