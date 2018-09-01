using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int num;
            int min = int.MinValue;
            int max = int.MaxValue;
            int acum=0;
            bool flag = true;
            double prom;

            Console.WriteLine("Este programa le pedira 10 numeros para informarle el numero minimo, maximo y el promedio.");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nPor favor ingrese el {0}° numero (-100/100): ",i);
                num = int.Parse(Console.ReadLine());

                if(Validacion.Validar(num,-100,100))
                {
                    Console.WriteLine("El numero es invalido. Por favor introduzca un numero entre -100/100.");
                    i--;
                    Console.ReadLine();
                    continue;
                }

                if (flag)
                {
                    min = max = num;
                    flag = false;
                }

                else if (num > max)
                {
                    max = num;
                }

                else if (num < min)
                {
                    min = num;
                }

                acum = acum + num;

            }

            prom = (double)acum / 10.00;
            Console.WriteLine("\nEl numero maximo fue: {0}\n\nEl numero minimo fue: {1}\n\nEl promedio fue: {2:N2}",max,min,prom);
            Console.ReadLine();
        }
    }
}
