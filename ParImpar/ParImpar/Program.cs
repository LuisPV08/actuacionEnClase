using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pide al usuario un número entero y determina si es par o impar.*/

            int num;

            do
            {

                Console.WriteLine("Ingres un numero para determinar si es par o impar");

                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Debe ingresar un número");
                }
                else 
                { 
                    break;
                }
            
            } while (true);

            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }

        }
    }
}
