using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int x=0;
            int y=0;
            double resul;
            int opc;
            char confirm='s';

            do
            {
                opc = Calculadora.Menu(x,y);
                
                switch(opc)
                {
                    case 1:
                        Console.Write("\nIngrese el operando X: ");
                        x = int.Parse(Console.ReadLine());

                        break;
                    case 2:
                        Console.Write("\nIngrese el operando Y: ");
                        y = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        resul = Calculadora.Calcular(x, y, opc);
                        Calculadora.Mostrar(resul, opc);

                        Console.WriteLine("¿Desea continuar? S/N");
                        confirm = char.Parse(Console.ReadLine());
                        break;
                    case 4:
                        resul = Calculadora.Calcular(x, y, opc);
                        Calculadora.Mostrar(resul, opc);

                        Console.WriteLine("¿Desea continuar? S/N");
                        confirm = char.Parse(Console.ReadLine());
                        break;
                    case 5:
                        resul = Calculadora.Calcular(x, y, opc);
                        Calculadora.Mostrar(resul, opc);

                        Console.WriteLine("¿Desea continuar? S/N");
                        confirm = char.Parse(Console.ReadLine());
                        break;
                    case 6:
                        resul = Calculadora.Calcular(x, y, opc);
                        Calculadora.Mostrar(resul, opc);

                        Console.WriteLine("¿Desea continuar? S/N");
                        confirm = char.Parse(Console.ReadLine());
                        break;
                    default:

                        break;
                }


                Console.Clear();
            } while (confirm=='s' || confirm=='S');

        }
    }
}
