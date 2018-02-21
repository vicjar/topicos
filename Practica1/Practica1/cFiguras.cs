using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class cFiguras
    {
        public double areaCuadrado(double lado)
        {
            return lado * lado;
        }
        public double perimetroCuadrado(double lado)
        {
            return lado * 4;
        }
        public double areaTriangulo(double b, double a)
        {
            return (b * a) / 2;
        }
        public double perimetroTriangulo(double a, double b, double c)
        {
            return (a+b+c);
        }
        public double areaRectangulo(double a, double b)
        {
            return a * b;
        }
        public double perimetroRectangulo(double a, double b)
        {
            return 2 * a + 2 * b;
        }
        public double perimetroCirculo(double d)
        {
            return (2*d * 3.1416);
        }
        public double areaCirculo(double a)
        {
            return a * a * 3.1416;
        }
    }
}
