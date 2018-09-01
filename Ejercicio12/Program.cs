using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro 12";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int num;
            char confirm='n';

            Console.WriteLine("Ingrese un numero, confirme si de desea continuar con S/N.");

            do
            {

                Console.Write("\nIngrese un numero: ");
                num=int.Parse(Console.ReadLine());
                Console.Write("\n¿Desea seguir ingresando numeros? S/N: ");

            } while (ValidarRespuesta.ValidaS_N(confirm));

            Console.WriteLine("PROGRAMA TERMINADO");
            Console.ReadLine();
        }
    }
}
