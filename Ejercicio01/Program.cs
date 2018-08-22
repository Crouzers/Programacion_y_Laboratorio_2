using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int num;
            int acum = 0;
            int max=int.MaxValue;
            int  min=99;
            float prom;
            int i;
            bool flag=true;


            Console.WriteLine("Ingrese 5 numeros");
            for (i = 1; i < 6; i++)
            {
                Console.Write("Ingrese numero {0}: ",i);
                num = int.Parse(Console.ReadLine());

                if (flag)
                {
                    max = min = num;
                    flag = false;
                }

                if(num>max)
                {
                    max = num;
                }

                else if (num<min)
                {
                    min = num;
                }
                acum = acum + num;
                
            }

            prom = (float)(acum / 5.0);
            Console.WriteLine("El numero maximo es {0} \n El numero minimo es {1} \n El promedio es: {2:0.00}",max,min,prom);

            Console.ReadLine();

        }
    }
}
