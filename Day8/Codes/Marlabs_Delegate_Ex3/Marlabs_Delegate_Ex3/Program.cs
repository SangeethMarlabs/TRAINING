using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Delegate_Ex3
{
    class Program
    {
        public delegate int ArithDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithemeticOperation objArithemeticOperation = new ArithemeticOperation();
            
        start:
            Console.WriteLine("*************Arithemetic Operations****************");
            Console.WriteLine($"Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            ArithDelegate objAddDelegate = new ArithDelegate(objArithemeticOperation.Add);
            int sum = objAddDelegate.Invoke(num1, num2);
            Console.WriteLine($"The sum would be :: {sum}");

            ArithDelegate objSubDelegate = new ArithDelegate(objArithemeticOperation.Sub);
            int sub = objSubDelegate.Invoke(num1, num2);
            Console.WriteLine($"The sub would be :: {sub}");

            ArithDelegate objMulDelegate = new ArithDelegate(objArithemeticOperation.Mul);
            int mul = objMulDelegate.Invoke(num1, num2);
            Console.WriteLine($"The mul would be :: {mul}");

            ArithDelegate objDivDelegate = new ArithDelegate(objArithemeticOperation.Div);
            int div = objDivDelegate.Invoke(num1, num2);
            Console.WriteLine($"The div would be :: {div}");

            goto start;
        }
    }
}
