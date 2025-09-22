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
            //Cada libro en una libreria sale a  S/13.
            //Si compras más de 5 libros cada libro te sale a S/10.

            //Definir y solicitar numero de libros comprados
            Console.WriteLine("Escriba la cantidad de libros a comprar:");
            int num = int.Parse(Console.ReadLine());

            //Usando condicional doble
            if (num >= 5)
            {
                Console.WriteLine("Obtuvo una oferta, ahora cada libro le cuesta S/10");
                Console.WriteLine($"El total a pagar es de S/{num*10}");
            }
            else
            {
                Console.WriteLine("Cada libro le cuesta S/13");
                Console.WriteLine($"El total a pagar es de S/{num * 13}");
            }

            Console.ReadKey();
        }
    }
}
