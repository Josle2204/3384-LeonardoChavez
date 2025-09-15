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
            //Condicionales -- Simples // Ejemplo 2
            //Saludar solo si el usuario ingresado es 'admin'

            //Definir
            string user;

            //Ingresar valor
            Console.WriteLine("Ingrese el nombre de usuario:");
            user = Console.ReadLine();

            //Condicional Simple

            if (user == "admin")
            {
                Console.WriteLine("¡Tenga un bonito dia!");
            }

            Console.ReadKey();
        }
    }
}
