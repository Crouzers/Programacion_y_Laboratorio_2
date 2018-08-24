using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            long cant;
            long acum=0;
            int cont = 1;
            //bool flag;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Un numero perfecto es un numero que esta conformado por la suma de todos sus divisores.");

            Console.WriteLine("Ejemplo: 6. \nDivisores: 1-2-3\n1+2+3=6");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Introduzca la cantidad de numeros perfectos que quiere mostrar: ");
            cant = long.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros perfectos hasta el numero 4 son: ");
            for (long i = 2; cont <= 4; i++)
            {
                for (long j = 1; j < i; j++)
                {
                    if (i%j==0)
                    {
                        acum = acum + j;
                    }
                }

                if (acum == i)
                {
                    Console.WriteLine("-{0}", acum);
                    cont++;
                }

                acum = 0;
            }




            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Igual te iba a mostrar solo cuatro porque el quinto esta en la loma del orto y me vas a romper la pc.");
            Console.ReadLine();
        }
    }
}
