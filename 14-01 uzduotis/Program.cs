using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new int[] { 25, 11, 29, 31, 16, 22, 23 };
            Console.WriteLine(temperaturos[0]);
            Console.WriteLine(temperaturos[1]);
            Console.WriteLine(temperaturos[2]);
            Console.WriteLine(temperaturos[3]);
            Console.WriteLine(temperaturos[4]);
            Console.WriteLine(temperaturos[5]);
            Console.WriteLine(temperaturos[6]);
            var min = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura < min)
                {
                    min = temperatura;
                }

            }
            Console.WriteLine("min: " + min);

            var max = temperaturos[0];
            foreach (var temperatura in temperaturos)

            {
                if (temperatura > max)
                {
                    max = temperatura;
                }
               
                
            }
            Console.WriteLine("max: " + max);


            var suma = 0;
            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;

            }

            var vidurkis = suma / temperaturos.Length;
          

            Console.WriteLine("vidurkis: " + vidurkis);


        }
    }
}
