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

            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Escriba su opción: ");

            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menu >= 1 && menu <= 4)
            {

                Console.Write("Ingrese el 1er numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el 2do numero: ");
                int num2 = int.Parse(Console.ReadLine());


                switch (menu)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;

                    case 3:
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado: {(double)num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre 0");
                        }

                        break;
                }  
            }

            else
            {
                Console.WriteLine("Opcion no valida");
            }

            Console.ReadKey();
        }   
    }
}
