using System;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int lenght = 10){
            //PADLEFT PADRIGTH RELLENAR STRING
            //INT, CHAR
            WriteLine("".PadLeft(lenght, '='));                        
        }

        public static void WriteTitle(string titulo){
            var tam = titulo.Length + 4;
            DrawLine(tam);
            WriteLine($"| {titulo} |");
            DrawLine(tam);
        }

        public static void Beep(int Hertz, int Tiempo = 500, int cantidad = 1){
            while (cantidad > 0)
            {
                Console.Beep(Hertz, Tiempo);
                cantidad--;
            }
        }
    }
}