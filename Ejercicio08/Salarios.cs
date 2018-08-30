using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Salarios
    {

        public static int Calcular_y_Mostrar_Salario(string nombre, int antiguedad, int valor_hora, int horas_mes)
        {
            int bruto;
            float neto;
            float descuentos;

            bruto = Calcular_Bruto(antiguedad,valor_hora,horas_mes);
            neto = Calcular_Neto(antiguedad, valor_hora, horas_mes, out descuentos);

            Mostrar_Recibo(nombre, antiguedad, valor_hora, horas_mes, bruto, neto, descuentos);



            return bruto;
        }

        private static int Calcular_Bruto(int antiguedad, int valor_hora, int horas_mes)
        {
            int resultado = 0;

            resultado = (valor_hora * horas_mes) + (antiguedad * 150);

            return resultado;
        }

        private static float Calcular_Neto(int antiguedad, int valor_hora, int horas_mes, out float descuentos)
        {
            float parcial;
            float resultado;

            parcial = Calcular_Bruto(antiguedad,valor_hora,horas_mes);
            descuentos = (float)(parcial * 0.13);
            resultado = parcial - descuentos;

            return resultado;
        }

        private static void Mostrar_Recibo(string name, int antiguedad, int valor_hora, int horas_mes, int bruto, float neto,float descuentos)
        {
            Console.WriteLine("Nombre del empleado: {0}",name);
            Console.WriteLine("\nAños de antiguedad: {0} Años", antiguedad);
            Console.WriteLine("\nValor de la hora: ${0}", valor_hora);
            Console.WriteLine("\nHoras trabajadas este mes: {0}hs", horas_mes);
            Console.WriteLine("\nSueldo bruto: ${0}", bruto);
            Console.WriteLine("\nImpuestos: ${0:N2}", descuentos);
            Console.WriteLine("\nSueldo neto: ${0:N2}", neto);
            
        }

    }
}
