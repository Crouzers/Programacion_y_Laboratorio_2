using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            int altura;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Este programa dibujará una piramide de asteriscos (*) en base a la altura que ingresará.");
            Console.Write("Por favor, ingrese la altura de la piramide deseada: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= altura; i++)
            {

                for (int k = altura - i; k > 0; k--)
                {
                    Console.Write(" ");
                }

                for (double j = 0.5; j < i; j += 0.5)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
