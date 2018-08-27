using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int year=-1;

            
            while (year != 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese un año, el programa le informara si es un año bisiesto o no.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIngrese 0 para salir.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingrese el año: ");
                
                year = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                if ((year % 4 == 0) && (year !=0 ))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEl año {0} es bisiesto.\n", year);
                }

                else if (year == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSaliendo del programa.\n");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nEl año {0} no es bisisesto.\n", year);
                }

                //Console.ReadLine();
                //Console.Clear();


            }

            Console.ReadLine();
        }
    }
}
