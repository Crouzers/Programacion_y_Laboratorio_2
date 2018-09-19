using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Indexadas
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _colores;
        private int _cantMaximaElementos;
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno = "Cantidad maxima de elementos: " + this._cantMaximaElementos + "\r\nColores utilizados en la paleta: \r\n";
            string cadenaAux1 = "";
            string cadenaAux2 = "";

            foreach (Tempera temperas in this._colores)
            {
                if (!(Object.Equals(temperas, null)))
                {
                    cadenaAux2 = temperas;
                    cadenaAux1 += cadenaAux2;
                }
            }
            retorno += cadenaAux1;
            return retorno;
        }

        private int ObtenerIndice()
        {
            int i;
            int indice = -1;

            for (i = 0; i < this._cantMaximaElementos; i++)
            {
                if (Object.Equals(this._colores,null))
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        private int ObtenerIndice(Tempera t)
        {
            int i;
            int indice = -1;

            for (i = 0; i < this._cantMaximaElementos; i++)
            {
                if (!(Object.Equals(this._colores[i],null)) && this._colores[i] == t)
                {
                    indice = i;
                }
            }

            return indice;
        }
        #endregion

        #region Constructor
        private Paleta() : this(5)
        {

        }

        private Paleta(int cantElementos)
        {
            this._cantMaximaElementos = cantElementos;
            this._colores = new Tempera[_cantMaximaElementos];
        }
        #endregion

        #region Sobrecargas
        public static explicit operator string(Paleta pal)
        {
            return pal.Mostrar();
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool flag=false;

            foreach (Tempera item in p._colores)
            {
                if (!(Object.Equals(item,null)) && t==item)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p==t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            int indice = -1;
            if (p == t)
            {
                indice = p.ObtenerIndice(t);
                if (indice != -1)
                {
                    p._colores[indice] += t;
                }
            }

            else
            {
                indice = p.ObtenerIndice();
                if(indice != -1)
                {
                    p._colores[indice] = t;
                }
            }

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice;
            sbyte aux1;
            sbyte aux2;
            indice = p.ObtenerIndice(t);

            if (indice != -1)
            {
                aux1 = (sbyte)t;
                p._colores[indice] += (sbyte)(aux1 * (-1));
                aux2 = (sbyte)p._colores[indice];
                if (aux2<=0)
                {
                    p._colores[indice] = null;
                }
            }
            return p;
        }
        #endregion

        #region Indexador
        public Tempera this[int indice]
        {
            get
            {
                if (indice >=0 && !(Object.Equals(this._colores[indice],null)) && indice < this._cantMaximaElementos)
                {
                    return this._colores[indice];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (indice >= 0 &&  indice < this._cantMaximaElementos)
                {
                    this._colores[indice] = value;
                }
       
                
            }
        }
        #endregion

    }
}
