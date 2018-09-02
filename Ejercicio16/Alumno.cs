using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio16
{
    class Alumno
    {
        #region Atributos
        private byte nota1;
        private byte nota2;
        private float final;

        public string nombre;
        public string apellido;
        public int legajo;
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            if((this.nota1>=4)&&(this.nota2>=4))
            {
                Random aleatorio = new Random();
                this.final = aleatorio.Next(1, 10);
            }
            else
            {
                this.final = -1;
            }
        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", "Legajo", "Nombre", "Apellido", "1º Nota", "2ª Nota", "Nota Final");
            if (this.final == -1)
            {
                Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", this.legajo, this.nombre, this.apellido, this.nota1, this.nota2, "Alumno desaprobado");
            }
            else
            {
                Console.WriteLine("{0,-8}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}", this.legajo, this.nombre, this.apellido, this.nota1, this.nota2, this.final);

            }
        }
        #endregion

        #region Constructor
        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        #endregion

    }
}
