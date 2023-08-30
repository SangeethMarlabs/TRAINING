using System;
namespace Marlabs_Arithemetic_Operation_Delegates
{
    class Program
    {
        public delegate T ArithemeticOperationDelegate<T>(T a, T b);
        static void Main(string[] args)
        {
            Console.WriteLine("-------Arithemetic operations delegate-------");
            Console.WriteLine("\n-------Integer Arithemetic operations-------");
            Console.WriteLine("Enter first number :: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number :: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            ArithemeticOperationDelegate<int> objArithemeticOperationDelegate1 = new ArithemeticOperationDelegate<int>(new ArithemeticOperations().Addition);
            ArithemeticOperationDelegate<int> objArithemeticOperationDelegate2 = new ArithemeticOperationDelegate<int>(new ArithemeticOperations().Subtraction);
            ArithemeticOperationDelegate<int> objArithemeticOperationDelegate3 = new ArithemeticOperationDelegate<int>(new ArithemeticOperations().Multiplication);
            ArithemeticOperationDelegate<int> objArithemeticOperationDelegate4 = new ArithemeticOperationDelegate<int>(new ArithemeticOperations().Division);

            int intAmt = objArithemeticOperationDelegate1.Invoke(firstNumber,secondNumber);
            Console.WriteLine($"The Addition would be :: {intAmt}");
              intAmt = objArithemeticOperationDelegate2.Invoke(firstNumber,secondNumber);
            Console.WriteLine($"The Subtraction would be :: {intAmt}");
              intAmt = objArithemeticOperationDelegate3.Invoke(firstNumber,secondNumber);
            Console.WriteLine($"The Multiplication would be :: {intAmt}");
              intAmt = objArithemeticOperationDelegate4.Invoke(firstNumber,secondNumber);
            Console.WriteLine($"The Division would be :: {intAmt}");

            Console.WriteLine("\n-------Float Arithemetic operations-------");
            Console.WriteLine("Enter first number :: ");
            float firstNumberF = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter second number :: ");
            float secondNumberF = Convert.ToSingle(Console.ReadLine());

            ArithemeticOperationDelegate<float> objArithemeticOperationDelegate5 = new ArithemeticOperationDelegate<float>(new ArithemeticOperations().Addition);
            ArithemeticOperationDelegate<float> objArithemeticOperationDelegate6 = new ArithemeticOperationDelegate<float>(new ArithemeticOperations().Subtraction);
            ArithemeticOperationDelegate<float> objArithemeticOperationDelegate7 = new ArithemeticOperationDelegate<float>(new ArithemeticOperations().Multiplication);
            ArithemeticOperationDelegate<float> objArithemeticOperationDelegate8 = new ArithemeticOperationDelegate<float>(new ArithemeticOperations().Division);

            float floatAmt = objArithemeticOperationDelegate5.Invoke(firstNumberF, secondNumberF);
            Console.WriteLine($"The Addition would be :: {floatAmt}");
            floatAmt = objArithemeticOperationDelegate6.Invoke(firstNumberF, secondNumberF);
            Console.WriteLine($"The Subtraction would be :: {floatAmt}");
            floatAmt = objArithemeticOperationDelegate7.Invoke(firstNumberF, secondNumberF);
            Console.WriteLine($"The Multiplication would be :: {floatAmt}");
            floatAmt = objArithemeticOperationDelegate8.Invoke(firstNumberF, secondNumberF);
            Console.WriteLine($"The Division would be :: {floatAmt}");



            Console.WriteLine("\n-------Decimal Arithemetic operations-------");
            Console.WriteLine("Enter first number :: ");
            decimal firstNumberD = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter second number :: ");
            decimal secondNumberD = Convert.ToDecimal(Console.ReadLine());

            ArithemeticOperationDelegate<decimal> objArithemeticOperationDelegate9 = new ArithemeticOperationDelegate<decimal>(new ArithemeticOperations().Addition);
            ArithemeticOperationDelegate<decimal> objArithemeticOperationDelegate10 = new ArithemeticOperationDelegate<decimal>(new ArithemeticOperations().Subtraction);
            ArithemeticOperationDelegate<decimal> objArithemeticOperationDelegate11 = new ArithemeticOperationDelegate<decimal>(new ArithemeticOperations().Multiplication);
            ArithemeticOperationDelegate<decimal> objArithemeticOperationDelegate12 = new ArithemeticOperationDelegate<decimal>(new ArithemeticOperations().Division);

            decimal decimalAmt = objArithemeticOperationDelegate9.Invoke(firstNumberD, secondNumberD);
            Console.WriteLine($"The Addition would be :: {decimalAmt}");
            decimalAmt = objArithemeticOperationDelegate10.Invoke(firstNumberD, secondNumberD);
            Console.WriteLine($"The Subtraction would be :: {decimalAmt}");
            decimalAmt = objArithemeticOperationDelegate11.Invoke(firstNumberD, secondNumberD);
            Console.WriteLine($"The Multiplication would be :: {decimalAmt}");
            decimalAmt = objArithemeticOperationDelegate12.Invoke(firstNumberD, secondNumberD);
            Console.WriteLine($"The Division would be :: {decimalAmt}");

            Console.ReadLine();
        }
    }
}
