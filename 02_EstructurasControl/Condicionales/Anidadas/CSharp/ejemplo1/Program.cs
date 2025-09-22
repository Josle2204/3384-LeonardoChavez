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
            /* Usando condicional anidadas:
            Si la nota es mayor o igual a 18 → mostrar "Excelente"
            Si la nota está entre 14 y 17 → mostrar "Muy bueno"
            Si la nota está entre 11 y 13 → mostrar "Suficiente"
            Si la nota es menor a 11 → mostrar "Desaprobado" */

            //Declarar 'num' y solicitar valor al usuario
            Console.WriteLine("Ingrese su nota (1 - 20):");
            float num = float.Parse(Console.ReadLine());

            //Condicionales Anidadas
            if (num > 20)
            {
                Console.WriteLine("Nota invalida");
            }
            else
            {
                if (num >= 18)
                {
                    Console.WriteLine("Nota Excelente");
                }
                else
                {
                    if (num >= 14)
                    {
                        Console.WriteLine("Nota Muy Buena");
                    }
                    else
                    {
                        if (num >= 11)
                        {
                            Console.WriteLine("Nota Suficiente");
                        }
                        else
                        {
                            if (num >= 0)
                            {
                                Console.WriteLine("Nota Desaprobatoria");
                            }
                            else
                            {
                                Console.WriteLine("Nota invalida");
                            }
                        }
                    }
                }
            }

        }
    }
}
