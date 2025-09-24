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
            Console.WriteLine("Calificaciones:");
            Console.WriteLine("A > Excelente");
            Console.WriteLine("B > Notable");
            Console.WriteLine("C > Aprobado");
            Console.WriteLine("D > Insuficiente");
            Console.WriteLine("F > Reprobatorio");
            
            Console.WriteLine("Ingrese una letra de calificación: ");
            string nota = Console.ReadLine().ToUpper();

            if (nota == "A")
            {
                Console.WriteLine("Su nota es Excelente");
            }
            else if (nota == "B")
            {
                Console.WriteLine("Su nota es Notable");
            }
            else if (nota == "C")
            {
                Console.WriteLine("Su nota es Aprobado");
            }
            else if (nota == "D")
            {
                Console.WriteLine("Su nota es Insuficiente");
            }
            else if (nota == "F")
            {
                Console.WriteLine("Su nota es Reprobatorio");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }

            Console.ReadKey();
        }
    }
}
