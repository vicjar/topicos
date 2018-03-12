using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Practica_4
{
    class cSerpiente: cCuadro
    {
        cSerpiente siguiente;

        public cSerpiente(int x, int y)
        {
            this.x = x;
            this.y = y;
            siguiente = null;
        }

        public void dibujar(Graphics g)
        {
            if(siguiente!=null)
            {
                siguiente.dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.ancho, this.ancho);
        }
        public void setxy(int x, int y)
        {

            if(siguiente != null)
            {
                siguiente.setxy(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }
        public void insertar()
        {
            if(siguiente == null)
            {
                siguiente = new cSerpiente(this.x, this.y);
            }
            else
            {
                siguiente.insertar();
            }
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }   
        public cSerpiente getCola()
        {
            return siguiente;
        }
    }
}
