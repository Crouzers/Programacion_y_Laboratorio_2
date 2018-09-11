using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Metodos
        public int GetX()
        {
        return this.x;
        }

        public int GetY()
        {
        return this.y;
        }
        #endregion

        #region Constructor
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
    }

    class Rectangulo
    {
        #region Atributos
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        double area;
        double perimetro;
        #endregion

        #region Metodos


        #endregion

        #region Constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            int x, y;
            x = vertice1.GetX();
            y = vertice3.GetY();
            Punto vertice2 = new Punto(x, y);

            x = vertice3.GetX();
            y = vertice1.GetY();
            Punto vertice4 = new Punto(x, y);

            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;
        }
        #endregion
    }
}
