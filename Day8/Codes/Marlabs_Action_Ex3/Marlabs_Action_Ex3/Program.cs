using System;

namespace Marlabs_Action_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Action With Anonymouse function-------");

            Console.WriteLine("Enter first number :: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :: ");
            int secondtNumber = Convert.ToInt32(Console.ReadLine());

            
            Action<int, int> objAdd = delegate(int a, int b) 
            {
                Console.WriteLine($"The Addition would be :: {a + b}");
            };
            objAdd.Invoke(firstNumber, secondtNumber);

            
            Action<int, int> objSub = delegate (int a, int b)
            {
                Console.WriteLine($"The Subtraction would be :: {a - b}");
            };
            objSub.Invoke(firstNumber, secondtNumber);


            Action<int, int> objMul = delegate (int a, int b)
            {
                Console.WriteLine($"The Multiplication would be :: {a * b}");
            };
            objMul.Invoke(firstNumber, secondtNumber);


            Action<int, int> objDiv = delegate (int a, int b)
            {
                Console.WriteLine($"The Division would be :: {a / b}");
            };
            objDiv.Invoke(firstNumber, secondtNumber);


            Console.ReadLine();
        }
    }
}
