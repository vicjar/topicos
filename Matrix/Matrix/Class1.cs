using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Operaciones
    {
        int filas, columnas;
        int resSumD, resSumDI;
        public Operaciones(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
        }

        public int[,] suma(int[,] a, int[,] b)
        {
            int[,] resSuma = new int[filas, columnas];
            for (int i= 0; i<filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    resSuma[i,j] = a[i,j] + b[i,j];
                }
            }
            return resSuma;
        }
        public int[,] resta(int[,] a, int[,] b)
        {
            int[,] resResta = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resResta[i, j] = a[i, j] - b[i, j];
                }
            }
            return resResta;
        }
        public int sumaDiagonal(int[,] a, int[,] b)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (i == j)
                    {
                        resSumD += a[i, j];
                    }
                }
            }
            return resSumD;
        }
        public int sumaDiagonalI(int[,] a, int[,] b)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (a.GetLength(0) - i == j)
                    {
                        resSumDI += a[filas-i, j];
                    }
                }
            }
            return resSumDI;
        }
        public int[,] multiplicacion(int[,] a, int[,] b)
        {
            int[,] resMult = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    for (int k = i; k < filas; k++)
                    {
                        resMult[i, j] += a[i, k] - b[k, j];
                    }
                    
                }
            }
            return resMult;
        }
    }
}
