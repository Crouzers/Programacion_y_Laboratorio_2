using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        #region Atributos
        private ConsoleColor _color;
        private ETipoTinta _tinta;
        #endregion

        #region Metodos
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        private string Mostrar()
        {
            return this._color.ToString() + "----" + this._tinta.ToString();
        }
        #endregion

        #region Constructor
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tinta = ETipoTinta.ConBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }
        
        //public Tinta(ETipoTinta tinta) : this()
        //{
        //    this._tinta = tinta;
        //}

        public Tinta(ConsoleColor color,ETipoTinta tinta):this(color)
        {
            this._tinta = tinta;
        }
        #endregion

        #region SobrecargaOP
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool flag = false;

            if ((t1._color == t2._color) && (t1._tinta == t2._tinta))
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }
        #endregion



    }
}
