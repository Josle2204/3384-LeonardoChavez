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
            //Ejemplo 1 C# -- Secuenciales
            //Calcular area de un triángulo

            //Definir
            int bas, altura;
            float area;

            //Ingresar valores
            Console.WriteLine("Ingrese la base de su triangulo");
            bas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura de su triangulo");
            altura = int.Parse(Console.ReadLine());

            //Formula
            area = (float)(bas * altura) / 2;

            //Impresión
            Console.WriteLine($"Su area del triangulo es {area}");

            Console.ReadKey();
        }
    }
}
