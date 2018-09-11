using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;

namespace Ejercicio17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string dibujo;
            Boligrafo boliAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boliRojo = new Boligrafo(ConsoleColor.Red, 50);
            if (boliAzul.Pintar(20, out dibujo))
            {
                Console.ForegroundColor = boliAzul.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(dibujo);
            }

            if (boliRojo.Pintar(70, out dibujo))
            {
                Console.ForegroundColor = boliAzul.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(dibujo);
            }
            Console.ReadLine();

        }
    }
}
