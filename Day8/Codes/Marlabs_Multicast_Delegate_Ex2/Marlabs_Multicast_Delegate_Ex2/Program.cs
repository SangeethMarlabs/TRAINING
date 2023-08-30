using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Multicast_Delegate_Ex2
{
    class Program
    {
        public delegate void ArithemeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ArithemeticDelegate objArithemeticDelegate = new ArithemeticDelegate(Add);
            objArithemeticDelegate += new ArithemeticDelegate(Mul);
            objArithemeticDelegate+= new ArithemeticDelegate(Div);
            objArithemeticDelegate+= new ArithemeticDelegate(Sub);

            objArithemeticDelegate.Invoke(num1, num2);
            Console.ReadLine();

        }

        public static void Add(int a, int b)
        {
            int amt = a + b;
            Console.WriteLine($"The Addition would be {amt}");
        }

        public static void Mul(int a, int b)
        {
            int amt = a * b;
            Console.WriteLine($"The Multiplication would be {amt}");
        }

        public static void Sub(int a, int b)
        {
            int amt = a - b;
            Console.WriteLine($"The Subtraction would be {amt}");
        }

        public static void Div(int a, int b)
        {
            int amt = a / b;
            Console.WriteLine($"The Division would be {amt}");
        }
    }
}
