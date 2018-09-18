﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades07_08
{
        public class Paleta
        {
            #region Atributos
            private Tempera[] _colores;
            private int _cantMaximaelementos;
            #endregion

            #region Constructor
            private Paleta() : this(5)
            {

            }

            private Paleta(int cantElementos)
            {
                this._cantMaximaelementos = cantElementos;
                this._colores = new Tempera[this._cantMaximaelementos];
            }
            #endregion

            #region Metodos
            private string Mostrar()
            {
                string retorno = "Cantidad maxima de elementos: " + this._cantMaximaelementos + "\r\nColores utilizados en la paleta\n ";
                string cadenaAux = "";
                string cadenaAux2 = ""; 
                foreach (Tempera temperas in this._colores)
                {
                if (!(object.Equals(temperas, null)))
                {
                    cadenaAux2 = temperas;
                    cadenaAux += cadenaAux2;
                }
                }
                retorno += cadenaAux;
                return retorno;
            }

            private int ObtenerIndice()
            {
                int i;
                int indice = -1;
                for (i = 0; i < this._cantMaximaelementos; i++)
                {
                    if (this._colores.GetValue(i) == null)
                    {
                        indice = i;
                        break;
                    }
                }
                return indice;
            }

            private int ObtenerIndice(Tempera t)
            {
                int indice = -1;
                int i;
                for (i = 0; i < this._cantMaximaelementos; i++)
                {
                    if (this._colores.GetValue(i) != null && this._colores[i] == t)
                    {
                        indice = i;
                    }
                }
                return indice;
            }
            #endregion

            #region Sobrecarga
            public static explicit operator string(Paleta p)
            {
                return p.Mostrar();
            }

            public static implicit operator Paleta(int cantidad)
            {
                return new Paleta(cantidad); ;
            }

            public static bool operator ==(Paleta p, Tempera t)
        {

            //foreach (Tempera item in p._colores)
            //{
            //    if (!(Object.Equals(item, null)) && t == item)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            bool flag = false;
            for (int i = 0; i < p._cantMaximaelementos; i++)
            {
                if (p._colores.GetValue(i) != null)
                {
                    if (p._colores[i] == t)
                    {
                        flag =true;
                    }
                }

            }
            return flag;
        }

            public static bool operator !=(Paleta p, Tempera t)
            {
                return !(p == t);
            }

            public static Paleta operator +(Paleta p, Tempera t)
            {
                int indice = p.ObtenerIndice(t);
                if (indice != -1)
                {
                    p._colores[indice] += t;
                }
                else
                {
                    indice = p.ObtenerIndice();
                    if (indice != -1)
                    {
                        p._colores[indice] = t;
                    }
                }
                return p;
            }

            public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice = -1;
            int aux1 = 0;
            int aux2 = 0;

            if (p == t)
            {
                indice = p.ObtenerIndice(t);
                aux1 = (sbyte)p._colores[indice];
                aux2 = (sbyte)t;
                if(aux1-aux2 <=0)
                {
                    p._colores[indice] = null;

                }
                else
                {
                    p._colores[indice] += ((sbyte)(aux2 * -1));

                }
            }


            return p;
        }
            #endregion
        }
    
}
