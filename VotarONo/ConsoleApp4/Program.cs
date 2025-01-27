using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que pida la edad del usuario y determine si puede votar (mayor o igual a 18 años).*/

            int edad;

            do
            {
                Console.WriteLine("Ingrese su edad para determinar si puede votar:");

                if (!int.TryParse(Console.ReadLine(), out edad) || edad < 1)
                {
                    Console.WriteLine("La edad debe ser un número entero positvo");
                    
                }
                else
                {
                    break;
                }

            } while (true);

            if (edad >= 18)
            {
                Console.WriteLine("Puede votar");
            }
            else
            {
                Console.WriteLine("No puede votar");
            }

        }
    }
}
