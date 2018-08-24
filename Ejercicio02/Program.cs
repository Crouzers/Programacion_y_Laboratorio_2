using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            double num;
            double numsqr;
            double numcub;

            Console.Title = "Ejercicio Nro 2";
            Console.Write("Ingresar un numero para mostrar su potencia cuadrada y cubica: ");
            num = double.Parse(Console.ReadLine());

            if (num > 0)
            {
                numsqr = Math.Pow(num, 2);
                numcub = Math.Pow(num, 3);

                Console.WriteLine("\nLa potencia cuadrada y cubica respectivamente de {0} es: {1} y {2}", num, numsqr, numcub);
            }

            else
            {
                Console.WriteLine("\nERROR. ¡Reingresar numero!");

            }
            Console.ReadLine();
            
        }
    }
}
