using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Ejercicio_00
    {
        static void Main(string[] args)
        {
            Console.Title ="Ejercicio Nro 00";
            string name;
            int age;

            Console.WriteLine("Que onda perro, ingresa tu nombre");
         

            name = Console.ReadLine();

            Console.WriteLine("tu nombre es: {0}",name);
            Console.WriteLine("ingresa la edad: ");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Su edad es: {0}", age);

            Console.ReadLine();
        }
    }
}
