using System;
namespace Marlabs_Delegate_Anonymous_Funcion_Ex2
{
    class Program
    {
        public delegate decimal ArithemeticOperationsDelegate(decimal a, decimal b);
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("*********Arithemetic Operations Delegate | Anonymous function ********");
            Console.WriteLine("Enter the first number : ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            ArithemeticOperationsDelegate objAdd = delegate (decimal a, decimal b)
            {
                return a + b;
            };
            decimal sum = objAdd.Invoke(num1, num2);
            Console.WriteLine($"the Addition would be {sum}");

            ArithemeticOperationsDelegate objSub = delegate (decimal a, decimal b)
            {
                return a - b;
            };
            decimal sub = objSub.Invoke(num1, num2);
            Console.WriteLine($"the Subtract would be {sub}");

            ArithemeticOperationsDelegate objMul = delegate (decimal a, decimal b)
            {
                return a * b;
            };
            decimal mul = objMul.Invoke(num1, num2);
            Console.WriteLine($"the Multiplication would be {mul}");

            ArithemeticOperationsDelegate objDiv = delegate (decimal a, decimal b)
            {
                return a / b;
            };
            decimal div = objDiv.Invoke(num1, num2);
            Console.WriteLine($"the Division would be {div}");

            Console.ReadLine();
            goto start;
        }
    }
}
