using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public class cFiguras
    {
        public void linea(Graphics g, Point p1, Point p2, Pen pen)
        {
            g.DrawLine(pen, p1, p2);     
        }
        public void circulo(Graphics g,Point p1, Point p2, Pen pen)
        {

            g.DrawEllipse(pen, new Rectangle(p1.X, p1.Y, Math.Abs(p2.X- p1.X), Math.Abs(p2.Y- p1.Y)));
        }
        public void cuadro(Graphics g, Point p1, Point p2, Pen pen)
        {
            g.DrawRectangle(pen, new Rectangle(p1.X, p1.Y, Math.Abs(p2.X-p1.X), Math.Abs(p2.Y-p1.Y)));
        }
        public void libre(Graphics g, Point p1, Point p2, int tam, Pen pen)
        {
            //g.DrawEllipse(pen, new Rectangle(p1.X, p1.Y, tam, tam));
            g.DrawLine(pen, p1, p2);
        }
        public void imagen(Graphics g, Point p1)
        {
            //g.DrawEllipse(pen, new Rectangle(p1.X, p1.Y, tam, tam));

            Bitmap myBitmap = new Bitmap("C:/Users/Vicjar/Desktop/topicos/Practica 3/Practica 3/img/triforce.jpg");
            g.DrawImage(myBitmap, p1);
        }
    }
}
