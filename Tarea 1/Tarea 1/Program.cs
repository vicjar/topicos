using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    //interface y clases que extienden de esta
    interface IOperaciones
    {
        int Calcular(int num);
    }
    class Doubler : IOperaciones
    {
        public int Calcular(int num)
        {
            return num * 2;
        }
    }
    class IsPair : IOperaciones
    {
        public int Calcular(int num)
        {
            int isPair = num % 2 == 0 ? 0 : 1; return isPair;
        }
    }
    class Factorial : IOperaciones
    {
        public int Calcular(int num)
        {
            int f = 1;
            if (num == 0)
                return 1;
            for (int i = num; i > 1; i--)
                f += f * (i - 1);
            return f;
        }
    }
    class Program
    {
        /*public delegate int Transformer(int x);
        static int Square(int x) { return x * x; }
        Transformer t = Square;
        */
        //delegado y clases
        public delegate int Operaciones(int num);
        static int Doubler(int num){ return num * 2; }
        static int IsPair(int num) { int isPair = num % 2 == 0 ? 0 : 1; return isPair; }
        static int Factorial(int num)
        {
            int f = 1;
            if (num == 0)
                return 1;
            for (int i = num; i > 1; i--)
                f += f * (i-1);
            return f;
        }
            static void Main(string[] args)
        {
            //Transformer prueba = new Transformer(Program.Square);
            //DELEGATES
            Operaciones operaciones = new Operaciones(Program.Doubler);
            Console.WriteLine("Operaciones con delegado ");
            Console.WriteLine(operaciones(2));
            operaciones = new Operaciones(Program.IsPair);
            Console.WriteLine(operaciones(2));
            operaciones = new Operaciones(Program.Factorial);
            Console.WriteLine(operaciones(2));
           
            //Interfaz
            Console.WriteLine("Operaciones con interface");
            IOperaciones operaciones2;
            operaciones2 = new Doubler();
            Console.WriteLine(operaciones2.Calcular(2));
            operaciones2 = new IsPair();
            Console.WriteLine(operaciones2.Calcular(2));
            operaciones2 = new Factorial();
            Console.WriteLine(operaciones2.Calcular(2));
            Console.Read();
        }
    }
}
