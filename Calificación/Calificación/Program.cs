using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que convierta una calificación numérica (0-100) en una letra según el siguiente criterio:
            90-100: A
            80-89: B
            70-79: C
            60-69: D
            0-59: F*/

            int calificacion = 0;

            do
            {
                Console.WriteLine("Ingrese su calificación (0-100)");

                if (!int.TryParse(Console.ReadLine(), out calificacion) || calificacion < 0 || calificacion > 100)
                {
                    Console.WriteLine("Entrada no válida");
                }
                else
                {
                    break;
                }

            } while (true);

            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.WriteLine("A");
            }
            else if (calificacion >= 80 && calificacion < 90)
            {
                Console.WriteLine("B");
            }
            else if (calificacion >= 70 && calificacion < 80)
            {
                Console.WriteLine("C");
            }
            else if (calificacion >= 60 && calificacion < 70)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }
        }
    }
}
