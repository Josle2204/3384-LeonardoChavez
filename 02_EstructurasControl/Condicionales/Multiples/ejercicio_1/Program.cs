using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //Declaran varaible tipo ALEATORIA

            int numgenerado = r.Next(1,6);

            switch (numgenerado)
            {
                case 1:
                    Console.WriteLine("Gano 0 soles");
                    break;

                case 2:
                    Console.WriteLine("Gano 5 soles");
                    break;

                case 3:
                    Console.WriteLine("Gano 10 soles");
                    break;

                case 4:
                    Console.WriteLine("Gano 20 soles");
                    break;

                case 5:
                    Console.WriteLine("Gano 50 soles");
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
