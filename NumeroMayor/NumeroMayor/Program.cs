using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que pida dos números al usuario y determine cuál es el mayor.*/

            int num1, num2;

            do
            {

                Console.WriteLine("Ingrese un numero");

                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }

                Console.WriteLine("Ingrese otro numero");

                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Debe ingresar un número");
                    continue;
                }
                break;

            } while (true);

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} es mayor");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} es mayor");
            }
            else
            {
                Console.WriteLine("Ambos son iguales");
            }
        }
    }
}
