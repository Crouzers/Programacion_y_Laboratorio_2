using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            int cant_empl;
            string nombre;
            int antiguedad;
            int valor_hora;
            int horas_mes;
            float total_sueldos=0;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Ingrese el numero de empleados que ingresara: ");
            cant_empl = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            for(int i=1;i<=cant_empl;i++)
            {
                Console.Write("Ingrese el nombre del empleado n{0}: ", i);
                nombre = Console.ReadLine();
                Console.Write("\n\nIngrese la antiguedad en años de {0}: ", nombre);
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("\n\nIngrese el valor de la hora de trabajo de {0}: ", nombre);
                valor_hora = int.Parse(Console.ReadLine());
                Console.Write("\n\nIngrese la cantidad de horas que {0} trabaja por mes: ",nombre);
                horas_mes = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\nAprete ENTER para continuar.");
                Console.ReadLine();
                Console.Clear();

                total_sueldos = Salarios.Calcular_y_Mostrar_Salario(nombre, antiguedad, valor_hora, horas_mes);
                if (cant_empl != i)
                {
                    Console.WriteLine("\n\nAprete ENTER para ingresar otro empleado.");
                }
                else
                {
                    Console.WriteLine("\n\nAprete ENTER para terminar.");
                }

                Console.ReadLine();
                Console.Clear();

                
            }

            Console.WriteLine("\n\n--------El monto necesario para pagarle a los {0} empleados es: ${1}---------",cant_empl,total_sueldos);


            Console.ReadLine();
        }
    }
}
