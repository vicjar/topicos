using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class cCuadro
    {
        protected int x, y, ancho;
        public cCuadro()
        {
            ancho = 10;
        }
        public Boolean colicion(cCuadro cuadro)
        {
            int difx = Math.Abs(this.x - cuadro.x);
            int dify = Math.Abs(this.y - cuadro.y);
            if (difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
            {
                return true;
            }
            else
               return false;
        }
    }
}
