using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD___4
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[] { 7, 6, 9, 10, 5, 7, 9, 7 };
            var suma = 0;
            foreach (var skaicius in skaiciai)
            {
                suma += skaicius;

            }
            var vidurkis = (double) suma / skaiciai.Length;
            Console.WriteLine("atsakymas = " + vidurkis);
        }
       
        
    }
}
