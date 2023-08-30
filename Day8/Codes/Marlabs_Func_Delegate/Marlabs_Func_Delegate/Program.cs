using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Func_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Func delegate with static function-----------");
            Func<int, int, int> myFuncAddition = Add;
            int amt = myFuncAddition(10, 20);
            Console.WriteLine($"The Addition would be {amt}");

            Func<int, int, int> myFuncSubtract = Sub;
            amt = myFuncSubtract(20, 10);
            Console.WriteLine($"The Subtraction would be {amt}");

            Func<int, int, int> myFuncMultiplication = Mul;
            amt = myFuncMultiplication(30, 40);
            Console.WriteLine($"The Multiplication would be {amt}");

            Func<int, int, int> myFuncDivision = Div;
            amt = myFuncDivision(100, 20);
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
