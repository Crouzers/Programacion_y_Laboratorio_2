using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularTriangulo(double b, double h)
        {
            double area = 0;
            area = (double)(b * h) / 2;
            return area;
        }

        public static double CalcularCuadrado(double side)
        {
            double area = 0;
            area = (double)(side*side);
            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area=0;
            area = (double)(3.14* (Math.Pow((radio), 2)));
            return area;
        }


    }
}
