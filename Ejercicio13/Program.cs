using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";
            Console.ForegroundColor = ConsoleColor.Cyan;

            int opc;
            int num;
            string bin;
            Console.WriteLine("1-Ingrese un decimal para convertirlo a binario\n2-Ingrese un binario para convertirlo a decimal.");
            Console.WriteLine("¿Que desea hacer?\nIngrese opcion: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Write("Ingrese un numero decimal: ");
                    num = int.Parse(Console.ReadLine());
                    bin = Conversor.DecimalBinario(num);
                    Console.WriteLine("\nEl numero decimal {0} en binario es: {1}", num, bin);
                    break;

                case 2:
                    Console.Write("Ingrese un numero binario: ");
                    bin = Console.ReadLine();
                    num = Conversor.BinarioDecimal(bin);
                    Console.WriteLine("\nEl numero binario {0} en decimal es: {1}", bin, num);
                    break;

                default:

                    break;
            }


            Console.ReadLine();
        }
    }
}
