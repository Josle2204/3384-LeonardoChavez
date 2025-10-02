using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de numeros a contar N");
            int n = int.Parse(Console.ReadLine());
            int par = 0; int impar = 0;

            for (int i = 1; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    par = par + 1;
                }
                
                else
                {
                    impar = impar + 1;
                }
            }

            Console.WriteLine($"Hay {par} numeros pares");
            Console.WriteLine($"Hay {impar} numeros impares");

            Console.ReadKey();
        }
    }
}
