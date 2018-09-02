using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Alumno primerAlumno = new Alumno("Franas", "Bustamante", 45687);
            Alumno segundoAlumno = new Alumno("Maki", "Rome", 58687);
            Alumno tercerAlumno = new Alumno("Delfi", "Bri", 98787);

            primerAlumno.Estudiar(8, 5);
            segundoAlumno.Estudiar(2, 3);
            tercerAlumno.Estudiar(9, 1);

            primerAlumno.CalcularFinal();
            segundoAlumno.CalcularFinal();
            tercerAlumno.CalcularFinal();

            primerAlumno.Mostrar();
            segundoAlumno.Mostrar();
            tercerAlumno.Mostrar();

            Console.ReadLine();

        }
    }
}
