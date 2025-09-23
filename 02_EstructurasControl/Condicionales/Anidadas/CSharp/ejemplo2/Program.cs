using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Un sistema de transporte cobra pasajes según la edad de la persona y el tipo de viaje
                Si la edad es menor a 0 o mayor a 120 → mostrar "Edad inválida"

                Si la persona es menor de 18 años:
                Si el viaje es urbano, el pasaje cuesta S/ 2
                Si el viaje es rural, el pasaje cuesta S/ 5

                Si la persona es 18 años o más:
                Si el viaje es urbano, el pasaje cuesta S/ 3
                Si el viaje es rural, el pasaje cuesta S/ 7   */

            //Definir edad, viaje y solicitar los datos

            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            
            //Usando Condicional anidada:
            if (edad > 120 || edad < 0)
            {
                Console.WriteLine("Edad Invalida");
            }
            else
            {
                    Console.WriteLine("Escriba su tipo de viaje:    (urbano // rural)");
                    string viaje = Console.ReadLine().ToLower();

                    if (edad >= 18)
                    {
                        if (viaje == "urbano")
                        {

                            Console.WriteLine("Su pasaje cuesta S/3");

                        }
                        else
                        {
                            if (viaje == "rural")
                            {
                                Console.WriteLine("Su pasaje cuesta S/7");
                            }
                            else
                            {
                                Console.WriteLine("Su destino es invalido");
                            }
                        }
                    }

                    else
                    {
                        if (viaje == "urbano")
                        {

                            Console.WriteLine("Su pasaje cuesta S/2");

                        }
                        else
                        {
                            if (viaje == "rural")
                            {
                                Console.WriteLine("Su pasaje cuesta S/5");
                            }
                            else
                            {
                                Console.WriteLine("Su destino es invalido");
                            }
                        }
                    }
            }

            Console.ReadKey();
        }
    }
}
