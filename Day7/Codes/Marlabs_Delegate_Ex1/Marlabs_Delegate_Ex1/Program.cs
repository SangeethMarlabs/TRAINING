using System;

namespace ArithemeticDelegates
{
    class Program
    {
        public delegate int ArithmeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate objAddDelegate = new ArithmeticDelegate(Add);
            int sum = objAddDelegate.Invoke(80, 80);
            Console.WriteLine($"The Addition would be - {sum}");

            ArithmeticDelegate objSubDelegate = new ArithmeticDelegate(Sub);
            int sub = objSubDelegate.Invoke(80, 40);
            Console.WriteLine($"The Subtraction would be - {sub}");

            ArithmeticDelegate objMulDelegate = new ArithmeticDelegate(Mul);
            int mul = objMulDelegate.Invoke(80, 80);
            Console.WriteLine($"The Multiplication would be - {mul}");

            ArithmeticDelegate objDivDelegate = new ArithmeticDelegate(Mul);
            int div = objDivDelegate.Invoke(80, 80);
            Console.WriteLine($"The Division would be - {div}");

            Console.ReadLine();
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
}