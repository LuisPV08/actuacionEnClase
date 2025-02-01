using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiedraPapelTijera
{
    internal class Program
    {
        static int vidasUsuario = 3;
        static int vidasPc = 3;
        
        static void Main(string[] args)
        {
            ejercicio();
        }
        private static void ejercicio()
        {
            /*1.-menu opciones ->jugador
             *2.-recuperar la opcion del jugador
             *3.-generar numero aletorio 1-4 (con la clase Random Next(1,4))*/

            bool jugarDeNuevo = true;

            do
            {
                int opcionUsuario = menuOpciones();
                int randomPc = new Random().Next(1, 4);
                logicaJuego(opcionUsuario, randomPc);


                if (vidasUsuario == 0 || vidasPc == 0)
                {
                    mostrarGanador();

                    jugarDeNuevo = seguirJugando();

                    if (jugarDeNuevo)
                    {
                        vidasUsuario = 3;
                        vidasPc = 3;
                    }
                    else
                    {
                        break;
                    }
                }

            } while (true);
        }
        private static int menuOpciones()
        {
            Console.WriteLine("1..para Piedra\n" +
                "2..Papel\n" +
                "3..Tijera");
            return int.Parse(Console.ReadLine());
        }

        private static void logicaJuego(int a, int b)
        {
            // Piedra Papel Tijera   usario a   1->Piedra 2->Papel  3->Tijera
            // Pierdra Papel Tijera  pc     b   3->Tijera 1->Piedra  2->Papel
            string[] opciones = { "Piedra", "Papel", "Tijera" };
            Console.WriteLine($"Usuario: {opciones[a - 1]}\nPc: {opciones[b - 1]}");
            
            string cadena = "";

            if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
            {
                //gano usuario
                cadena = "Usuario gana";
                vidasPc--;
            }
            else if (a == b)
            {
                //emapate
                cadena = "Empate!";
            }
            else
            {
                cadena = "Pc gana!";
                vidasUsuario--;
            }

            Console.WriteLine(cadena);
            Console.WriteLine($"Vidas PC: {vidasPc}, Vidas Usuario: {vidasUsuario}");

        }

        private static void mostrarGanador()
        {
            
            if (vidasUsuario == 0)
            {
                Console.WriteLine("¡PC ha ganado el juego!");
            }
            else
            {
                Console.WriteLine("¡Usuario ha ganado el juego!");
            }
        }

        private static bool seguirJugando()
        {
            Console.WriteLine("Presione cualquier tecla para seguir jugando o (n) para finalizar");
            string input = Console.ReadLine().ToLower();
            return input.Equals("s");
        }

    }
}
