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
            //Ejemplo 2 C# -- Secuenciales
            //Calcular area de un terrero rectangular

            //Definir
            float ancho, largo, area;
      
            //Ingresar Valores
            Console.WriteLine("Ingrese su ancho del terreno en m:");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su largo del terreno en m:");
            largo = int.Parse(Console.ReadLine());

            //Formula
            area = ancho * largo;

            //Impresion
            Console.WriteLine($"Su area del terreno es de {area} m2");

            Console.ReadKey();
        }
    }
}
