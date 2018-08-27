using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class EJercicio_05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int num;
            int nGroup1 = 0;
            int nGroup2 = 0;
            int cont = 1;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Un centro numerico es un\nnumero que separa una\nlista de numeros enteros\nen dos grupos numericos\ncuyas sumas son iguales.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese un numero para mostrar todos los centros numericos hasta ese numero: ");

            num = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 2; i <= num; i++)
            {
                for(int g1=0;g1<i;g1++)
                {
                    nGroup1 = nGroup1 + g1;
                }

                for(int g2=i+1;nGroup2<nGroup1;g2++)
                {
                    nGroup2 = nGroup2 + g2;
                }

                if (nGroup1 == nGroup2)
                {
                    Console.WriteLine("El centro numerico numero {0} es: {1}",cont,i);
                    cont++;
                }
                nGroup1 = nGroup2 = 0;  
            }

            Console.ReadLine();
        }
    }
}
