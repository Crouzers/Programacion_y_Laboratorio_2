using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
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
