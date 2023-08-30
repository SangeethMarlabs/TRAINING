using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Interface_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
           

            Console.WriteLine("****************Addition********************\n");
            Console.WriteLine("--------------Addition of integer---------------");
            Console.WriteLine("Input the first number : ");
            int integerNum1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Input the second number : ");
            int integerNum2 = Convert.ToInt32(Console.ReadLine());
            ArithemeticOperations<int> objArithemeticOperationsInteger = new ArithemeticOperations<int>();
            int integerSum = objArithemeticOperationsInteger.Addition(integerNum1, integerNum2);
            Console.WriteLine($"The integer sum would be :: {integerSum}\n");

            Console.WriteLine("--------------Addition of float---------------");
            Console.WriteLine("Input the first number : ");
            float floatNum1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            float floatNum2 = Convert.ToSingle(Console.ReadLine());
            ArithemeticOperations<float> objArithemeticOperationsfloat = new ArithemeticOperations<float>();
            float floatSum = objArithemeticOperationsfloat.Addition(floatNum1, floatNum2);
            Console.WriteLine($"The float sum would be :: {floatSum}\n");

            Console.WriteLine("--------------Addition of double---------------");
            Console.WriteLine("Input the first number : ");
            double doubleNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            double doubleNum2 = Convert.ToDouble(Console.ReadLine());
            ArithemeticOperations<double> objArithemeticOperationsdouble = new ArithemeticOperations<double>();
            double doubleSum = objArithemeticOperationsdouble.Addition(doubleNum1, doubleNum2);
            Console.WriteLine($"The double sum would be :: {doubleSum}\n");

            Console.WriteLine("--------------Addition of decimal---------------");
            Console.WriteLine("Input the first number : ");
            decimal decimalNum1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            decimal decimalNum2 = Convert.ToDecimal(Console.ReadLine());
            ArithemeticOperations<decimal> objArithemeticOperationsdecimal = new ArithemeticOperations<decimal>();
            decimal decimalSum = objArithemeticOperationsdecimal.Addition(decimalNum1, decimalNum2);
            Console.WriteLine($"The decimal sum would be :: {decimalSum}\n");



            Console.WriteLine("****************Subtraction********************\n");
            Console.WriteLine("--------------Subtraction of integer---------------");
            Console.WriteLine("Input the first number : ");
            integerNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            integerNum2 = Convert.ToInt32(Console.ReadLine());
            int integerSub = objArithemeticOperationsInteger.Subtraction(integerNum1, integerNum2);
            Console.WriteLine($"The integer Sub would be :: {integerSub}\n");

            Console.WriteLine("--------------Subtraction of float---------------");
            Console.WriteLine("Input the first number : ");
            floatNum1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            floatNum2 = Convert.ToSingle(Console.ReadLine());
            float floatSub = objArithemeticOperationsfloat.Subtraction(floatNum1, floatNum2);
            Console.WriteLine($"The float Sub would be :: {floatSub}\n");

            Console.WriteLine("--------------Subtraction of double---------------");
            Console.WriteLine("Input the first number : ");
            doubleNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            doubleNum2 = Convert.ToDouble(Console.ReadLine());
            double doubleSub = objArithemeticOperationsdouble.Subtraction(doubleNum1, doubleNum2);
            Console.WriteLine($"The double Sub would be :: {doubleSub}\n");

            Console.WriteLine("--------------Subtraction of decimal---------------");
            Console.WriteLine("Input the first number : ");
            decimalNum1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            decimalNum2 = Convert.ToDecimal(Console.ReadLine());
            decimal decimalSub = objArithemeticOperationsdecimal.Subtraction(decimalNum1, decimalNum2);
            Console.WriteLine($"The decimal Sub would be :: {decimalSub}\n");




            Console.WriteLine("****************Multiplication********************\n");
            Console.WriteLine("--------------Multiplication of integer---------------");
            Console.WriteLine("Input the first number : ");
            integerNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            integerNum2 = Convert.ToInt32(Console.ReadLine());
            int integerMul = objArithemeticOperationsInteger.Multiplication(integerNum1, integerNum2);
            Console.WriteLine($"The integer Multiplication would be :: {integerMul}\n");

            Console.WriteLine("--------------Multiplication of float---------------");
            Console.WriteLine("Input the first number : ");
            floatNum1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            floatNum2 = Convert.ToSingle(Console.ReadLine());
            float floatMul = objArithemeticOperationsfloat.Multiplication(floatNum1, floatNum2);
            Console.WriteLine($"The float Multiplication would be :: {floatMul}\n");

            Console.WriteLine("--------------Multiplication of double---------------");
            Console.WriteLine("Input the first number : ");
            doubleNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            doubleNum2 = Convert.ToDouble(Console.ReadLine());
            double doubleMul = objArithemeticOperationsdouble.Multiplication(doubleNum1, doubleNum2);
            Console.WriteLine($"The double Multiplication would be :: {doubleMul}\n");

            Console.WriteLine("--------------Multiplication of decimal---------------");
            Console.WriteLine("Input the first number : ");
            decimalNum1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            decimalNum2 = Convert.ToDecimal(Console.ReadLine());
            decimal decimalMul = objArithemeticOperationsdecimal.Multiplication(decimalNum1, decimalNum2);
            Console.WriteLine($"The decimal Multiplication would be :: {decimalMul}\n");



            Console.WriteLine("****************Division********************\n");
            Console.WriteLine("--------------Division of integer---------------");
            Console.WriteLine("Input the first number : ");
            integerNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            integerNum2 = Convert.ToInt32(Console.ReadLine());
            int integerDiv = objArithemeticOperationsInteger.Division(integerNum1, integerNum2);
            Console.WriteLine($"The integer Division would be :: {integerDiv}\n");

            Console.WriteLine("--------------Division of float---------------");
            Console.WriteLine("Input the first number : ");
            floatNum1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            floatNum2 = Convert.ToSingle(Console.ReadLine());
            float floatDiv = objArithemeticOperationsfloat.Division(floatNum1, floatNum2);
            Console.WriteLine($"The float Division would be :: {floatDiv}\n");

            Console.WriteLine("--------------Division of double---------------");
            Console.WriteLine("Input the first number : ");
            doubleNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            doubleNum2 = Convert.ToDouble(Console.ReadLine());
            double doubleDiv = objArithemeticOperationsdouble.Division(doubleNum1, doubleNum2);
            Console.WriteLine($"The double Division would be :: {doubleDiv}\n");

            Console.WriteLine("--------------Division of decimal---------------");
            Console.WriteLine("Input the first number : ");
            decimalNum1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            decimalNum2 = Convert.ToDecimal(Console.ReadLine());
            decimal decimalDiv = objArithemeticOperationsdecimal.Division(decimalNum1, decimalNum2);
            Console.WriteLine($"The decimal Division would be :: {decimalDiv}\n");


            Console.ReadLine();
            goto start;
        }
    }
}
