using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ConsoleColor.Blue);
            Tinta tinta3 = new Tinta(ConsoleColor.Red, ETipoTinta.Comun);

            Console.WriteLine(Tinta.Mostrar(tinta1));
            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            if (tinta1 == tinta2)
            {
                Console.WriteLine("{0} y {1} Son Iguales", tinta1, tinta2);
            }
            else
            {
                Console.WriteLine("{0} y {1} no son Iguales", tinta1, tinta2);
            }

            if (tinta1 == tinta3)
            {
                Console.WriteLine("{0} y {1} Son Iguales", tinta1, tinta3);
            }
            else
            {
                Console.WriteLine("{0} y {1} no son Iguales", tinta1, tinta3);
            }

            Console.ReadLine();
        }
    }
}
