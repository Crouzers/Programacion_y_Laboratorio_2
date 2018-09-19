using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Indexadas
{
    public class Tempera
    {
        #region Atributos
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "\r\nColor: " + this._color + " --- Marca: " + this._marca + " --- Cantidad: " + this._cantidad;
        }
        #endregion

        #region Constructor
        public Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidad = cantidad;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator string(Tempera temp)
        {
            return temp.Mostrar();
        }

        public static explicit operator sbyte(Tempera temp)
        {
            return temp._cantidad;
        }

        public static bool operator ==(Tempera t1,Tempera t2)
        {
            return ((t1._marca == t2._marca) && (t1._color == t2._color));
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return (!(t1 == t2));
        }

        public static Tempera operator +(Tempera temp, sbyte cant)
        {
            temp._cantidad += cant;
            return temp;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera t3 = new Tempera(t1._color, t1._marca, t1._cantidad);

            if (t1 == t2)
            {
                t3._cantidad += t2._cantidad;
            }

            return t3;
        }
        #endregion


    }
}
