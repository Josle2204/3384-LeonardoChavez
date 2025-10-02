using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabla de multiplicar del 1 al 12

            Console.WriteLine("Escriba un numero, escribiremos su tabla de multiplicar");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.WriteLine("Se mostro sus 12 multiplicaciones");

            Console.ReadKey();
        }
    }
}
