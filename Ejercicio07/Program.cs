using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            string birthDate;
            DateTime date;
            Console.Write("Ingresa tu fecha de nacimiento: (DD-MM-YYYY) ");
            birthDate = Console.ReadLine();
            date = DateTime.Parse(birthDate);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nHasta ahora viviste {0:dd} días", DateTime.Now - date);
            Console.ReadLine();
        }
    }
}
