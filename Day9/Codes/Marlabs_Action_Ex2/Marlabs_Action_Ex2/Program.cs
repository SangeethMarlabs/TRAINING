using System;
namespace Marlabs_Action_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Action With Class-------");
            ArithemeticFunctions objArithemeticFunctions = new ArithemeticFunctions();

            Console.WriteLine("Enter first number :: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number :: ");
            int secondtNumber = Convert.ToInt32(Console.ReadLine());

            Action<int, int> objAdd = new ArithemeticFunctions().Add;
            objAdd.Invoke(firstNumber, secondtNumber);
            
            Action<int, int> objSub = new ArithemeticFunctions().Sub;
            objSub.Invoke(firstNumber, secondtNumber);
            
            Action<int, int> objMul = new ArithemeticFunctions().Mul;
            objMul.Invoke(firstNumber, secondtNumber);
            
            Action<int, int> objDiv = new ArithemeticFunctions().Div;
            objDiv.Invoke(firstNumber, secondtNumber);

            Console.ReadLine();

        }
    }
}
