using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(int x, int y, int opc)
        {
            double ret = 0;

            switch (opc)
            {
                case 3:
                    ret = x + y;
                    break;
                case 4:
                    ret = x - y;
                    break;
                case 5:
                    ret = x * y;
                    break;
                case 6:
                    if (Calculadora.Validar(y))
                    {
                        ret = x / y;
                    }

                    break;
                default:

                    break;
            }

            return ret;
        }

        private static bool Validar(int y)
        {
            bool ret= true;

            if (y == 0)
            {
                ret = false;
                Console.WriteLine("ERROR. No se puede dividir por 0, seleccione otro operando y");
                Console.ReadLine();
            }

            return ret;
        }

        public static void Mostrar(double resul,int opc)
        {
            string[] op = {"","","", "suma","resta","multiplicacion","division"};

            Console.WriteLine("El restultado de la {0} es; {1:N2}",op[opc],resul);
        }

        public static int Menu(int x,int y)
        {
            int opc = 0;
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1-Elegir primer operando (x={0})",x);
            Console.WriteLine("2-Elegir segundo operando (y={0})",y);
            Console.WriteLine("3-Calcular suma (x+y)");
            Console.WriteLine("4-Calcular resta (x-y)");
            Console.WriteLine("5-Calcular multiplicacion(x*y)");
            Console.WriteLine("6-Calcular division(x/y)");
            opc = int.Parse(Console.ReadLine());
            return opc;
        }
    }
}
