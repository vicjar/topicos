using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class cFiguras
    {
        public double areaCuadrado(double lado=0)
        {
            return lado * lado;
        }
        public double perimetroCuadrado(double lado=0)
        {
            return lado * 4;
        }
        public double areaTriangulo(double b=0, double a=0)
        {
            return (b * a) / 2;
        }
        public double perimetroTriangulo(double a=0, double b=0, double c=0)
        {
            return (a+b+c);
        }
        public double areaRectangulo(double a=0, double b=0)
        {
            return a * b;
        }
        public double perimetroRectangulo(double a=0, double b=0)
        {
            return 2 * a + 2 * b;
        }
        public double perimetroCirculo(double d=0)
        {
            return (2*d * 3.1416);
        }
        public double areaCirculo(double a=0)
        {
            return a * a * 3.1416;
        }
    }
}
