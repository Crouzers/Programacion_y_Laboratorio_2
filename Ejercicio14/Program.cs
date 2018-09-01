using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";
            Console.ForegroundColor = ConsoleColor.Cyan;
            int opc=0;
            double resultado;

            Console.WriteLine("Este es un programa que calcula areas. Por favor ingrese el numero de la figura que quiere calcular.");
            Console.Write("1-Calcula el area de un triangulo\n2-Calcula el area de un cuadrado\n3-Calcula el area de un circulo");
            Console.Write("\nIngrese la opcion: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    double b, h;

                    Console.Write("\nIngrese la base del triangulo: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la altura del triangulo: ");
                    h = double.Parse(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularTriangulo(b,h);
                    Console.WriteLine("\nEl area del triangulo es: {0:N2}", resultado);
                    break;

                case 2:
                    double side;
                    Console.Write("Ingrese la medida de un lado del cuadrado: ");
                    side = double.Parse(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularCuadrado(side);
                    Console.WriteLine("\nEl area del cuadrado es: {0:N2}", resultado);
                    break;
                case 3:
                    double radio;
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularCirculo(radio);
                    Console.WriteLine("\nEl area del circulo es: {0:N2}", resultado);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;

            }

            Console.ReadLine();


        }
    }
}
