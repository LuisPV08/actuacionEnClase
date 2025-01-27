using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace grupo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            adivinarnumero();
        }

        public static int generanumero()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        public static void adivinarnumero()
        {
            int intento;
            int numero_secreto = generanumero();
            bool adivinar = false;

            Console.WriteLine("¡Bienvenido al juego! Adivina un número entre 1 y 100:");

            while (!adivinar)
            {
                Console.Write("Ingrese un número: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intento))
                {
                    if (intento == numero_secreto)
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número: {numero_secreto}");
                        adivinar = true;
                    }
                    else if (intento < numero_secreto)
                    {
                        Console.WriteLine("El número es mayor. Intenta nuevamente.");
                    }
                    else
                    {
                        Console.WriteLine("El número es menor. Intenta nuevamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }
    }
}
