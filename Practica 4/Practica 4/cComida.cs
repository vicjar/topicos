using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Practica_4
{
    class cComida: cCuadro
    {
        public cComida()
        {
            this.x = generar(66);
            this.y = generar(46);
        }
        public int generar(int n)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, n) * 10;
            return num;
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.ancho, this.ancho);
        }
        public void reGen()
        {
            this.x = generar(66);
            this.y = generar(46);
        }
    }
}
