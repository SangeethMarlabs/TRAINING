using System;


namespace Marlabs_Action_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Action With static method-------");

            Console.WriteLine("Enter first number :: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second number :: ");
            int secondtNumber = Convert.ToInt32(Console.ReadLine());

            Action <int, int> myActionAdd = Add;
            myActionAdd.Invoke(firstNumber, secondtNumber);

            Action <int, int> myActionSub = Sub;
            myActionSub.Invoke(firstNumber, secondtNumber);

            Action <int, int> myActionMul = Mul;
            myActionMul.Invoke(firstNumber, secondtNumber);

            Action <int, int> myActionDiv = Div;
            myActionDiv.Invoke(firstNumber, secondtNumber);


            Console.ReadLine();
        }

        public static void Add(int a,int b)
        {
            Console.WriteLine($"The Addition would be :: {a + b}");
        }
        public static void Sub(int a,int b)
        {
            Console.WriteLine($"The Subtraction would be :: {a - b}");
        }
        public static void Mul(int a,int b)
        {
            Console.WriteLine($"The Multiplication would be :: {a * b}");
        }        
        public static void Div(int a,int b)
        {
            Console.WriteLine($"The Division would be :: {a / b}");
        }


    }
}
