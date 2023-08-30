using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Func_Delegate_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Func delegates with user inputs-------");
            Func<int, int, int> myFuncAddition = Add;
            
            Console.WriteLine("Enter first number ::");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number ::");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int amt = myFuncAddition(num1, num2);
            Console.WriteLine($"The Addition would be {amt}");

            Func<int, int, int> myFuncSubtract = Sub;
            amt = myFuncSubtract(num1, num2);
            Console.WriteLine($"The Subtraction would be {amt}");

            Func<int, int, int> myFuncMultiplication = Mul;
            amt = myFuncMultiplication(num1, num2);
            Console.WriteLine($"The Multiplication would be {amt}");

            Func<int, int, int> myFuncDivision = Div;
            amt = myFuncDivision(num1, num2);
            Console.WriteLine($"The Division would be {amt}");

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
