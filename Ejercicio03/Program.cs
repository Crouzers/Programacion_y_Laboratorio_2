using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            int num;
            bool flag;

            Console.WriteLine("Ingrese un numero, se mostraran los numeros primos hasta el numero ingresado: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                flag = true;

                for (int n = 2; n < i; n++)
                {
                    if (i%n==0)
                    {
                        flag = false;
     
                    }
                }

                if (flag)
                {
                    Console.WriteLine("{0}",i);
                }
                
            }

            Console.ReadLine();
        }
    }
}
