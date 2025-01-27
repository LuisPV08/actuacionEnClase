using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.Escribe un programa que solicite al usuario ingresar un número del 1 al 7 y luego 
            muestre el día de la semana correspondiente (por ejemplo: 1 para "Lunes", 2 para "Martes", etc.)*/

            // Declaración de la variable que almacenará el número ingresado
            int num;

            // Bucle que se ejecutará hasta obtener una entrada válida
            while (true)
            {
                // Solicita al usuario ingresar un número entre 1 y 7
                Console.WriteLine("Ingrese un numero del 1 al 7");

                // Valida que:
                // 1. La entrada sea un número válido (usando TryParse)
                // 2. El número esté fuera del rango 1-7
                // Si cualquiera de estas condiciones se cumple, muestra error
                if (!int.TryParse(Console.ReadLine(), out num) || (num < 1 || num > 7))
                {
                    // Mensaje de error si la entrada no es válida
                    Console.WriteLine("Ingrese un número válido entre 1 y 7");
                }
                else 
                {
                    // Si la entrada es válida, sale del bucle
                    break;
                }
            }

            // Estructura switch para convertir el número en su día de la semana correspondiente
            switch (num)
            {
                // Caso 1 corresponde a Lunes
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                // Caso 2 corresponde a Martes
                case 2:
                    Console.WriteLine("Martes");
                    break;
                // Caso 3 corresponde a Miércoles
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                // Caso 4 corresponde a Jueves
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                // Caso 5 corresponde a Viernes
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                // Caso 6 corresponde a Sábado
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                // Caso 7 corresponde a Domingo
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }

        }
    }
}
