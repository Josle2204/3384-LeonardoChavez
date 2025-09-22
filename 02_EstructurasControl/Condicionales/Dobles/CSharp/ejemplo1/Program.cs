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
            //Mostrar si el numero ingresado es par o impar
        
            //Definir y solicitar valor del numero entero
            Console.WriteLine("Ingrese un numero entero: ");
            int num = int.Parse(Console.ReadLine());

            //Usando condicional doble
            if (num % 2 == 0)
            {
                Console.WriteLine($"Su numero {num} es par");
            }
            else
            {
                Console.WriteLine($"Su numero {num} es impar");
            }

            Console.ReadKey();
        }
    }
}
