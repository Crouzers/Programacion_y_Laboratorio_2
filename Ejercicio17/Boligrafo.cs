using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Boligrafo
    {
        #region Atributos
        public const short cantidadTintaMax = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Metodos

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short test = (short)(this.GetTinta() + tinta);
            if ((test >= 0) && (test <= cantidadTintaMax))
            {
                this.tinta = (short)(this.tinta + tinta);
                Console.WriteLine("\nEl nivel actual de tinta es: {0}", this.tinta);
            }
            else if (test < 0)
            {
                Console.WriteLine("\nNo se pudo hacer el gasto porque alcanza la tinta");
            }
            else if (test > cantidadTintaMax)
            {
                Console.WriteLine("\nNo se pudo hacer la recarga porque supera la capacidad maxima");
            }
        }

        public void Recargar()
        {
            short missingTint=(short)(cantidadTintaMax-this.tinta);

            SetTinta(missingTint);
        }

        public bool Pintar(short tinta,out string dibujo)
        {
            bool ret=false;
            dibujo = "";

            return ret;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            int i;
            bool retorno = false;
            dibujo = "";
            if (this.GetTinta() - gasto > 0)
            {
                for (i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                    retorno = true;
                }
            }
            else
            {
                dibujo = "No hay tinta suficiente!!";
                retorno = false;
            }
            return retorno;
        }


        #endregion

        #region Contructor

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        #endregion

    }
}
