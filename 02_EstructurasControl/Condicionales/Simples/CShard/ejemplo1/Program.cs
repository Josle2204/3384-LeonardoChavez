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
            //Condicionales -- Simples // Ejemplo 1
            //Hacer descuento del 10% solo si la compra es >= a S/1000

            //Definir
            float valor;

            //Ingresar valor
            Console.WriteLine("Ingrese el valor de su compra:");
            valor = float.Parse(Console.ReadLine());

            //Condicional Simple y formula

            if (valor >= 1000)
            {
                valor = (float)(valor * 0.90);

                Console.WriteLine($"Tiene un descuento del 10% y deberá pagar S/{valor}");
            }

            Console.ReadKey();

        }
    }
}
