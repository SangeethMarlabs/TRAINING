using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics_Functions_Assign_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            AreaOperations objAreaOperations = new AreaOperations();
            Console.WriteLine("****************Rectangle********************");
            Console.WriteLine("");
            Console.WriteLine("--------------Area of Rectangle (Integer)---------------");
            Console.WriteLine("Enter Rectangle length (Integer): ");
            int intLength =  Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter Rectangle width (Integer): ");
            int intWidth =  Convert.ToInt32(Console.ReadLine());
            int intArearRect = objAreaOperations.AreaRectangle<int>(intLength, intWidth);
            Console.WriteLine($"The Area of rectangle (integer) would be {intArearRect}\n");

            Console.WriteLine("--------------Area of Rectangle (float)---------------");
            Console.WriteLine("Enter Rectangle length (float): ");
            float floatLength =  Convert.ToSingle(Console.ReadLine());            
            Console.WriteLine("Enter Rectangle width (float): ");
            float floatWidth =  Convert.ToSingle(Console.ReadLine());
            float floatArearRect = objAreaOperations.AreaRectangle<float>(floatLength, floatWidth);
            Console.WriteLine($"The Area of rectangle (float) would be {floatArearRect}");

            Console.WriteLine("--------------Area of Rectangle (decimal)---------------");
            Console.WriteLine("Enter Rectangle length (decimal): ");
            decimal decimalLength =  Convert.ToDecimal(Console.ReadLine());            
            Console.WriteLine("Enter Rectangle width (decimal): ");
            decimal decimalWidth =  Convert.ToDecimal(Console.ReadLine());
            decimal decimalArearRect = objAreaOperations.AreaRectangle<decimal>(decimalLength, decimalWidth);
            Console.WriteLine($"The Area of rectangle (decimal) would be {decimalArearRect}");

            Console.WriteLine("****************Circle********************");
            Console.WriteLine("");
            Console.WriteLine("--------------Area of Circle (decimal)---------------");
            Console.WriteLine("Enter Circle radious (decimal): ");
            decimal decimalRadious = Convert.ToDecimal(Console.ReadLine());
            decimal decimalArearCir = objAreaOperations.AreaCircle<decimal>(decimalRadious, Convert.ToDecimal(3.14));
            Console.WriteLine($"The Area of Circle (decimal) would be {decimalArearCir}");

            Console.WriteLine("--------------Area of Circle (float)---------------");
            Console.WriteLine("Enter Circle radious (float): ");
            float floatRadious = Convert.ToSingle(Console.ReadLine());
            float floatArearCir = objAreaOperations.AreaCircle<float>(floatRadious, Convert.ToSingle(3.14));
            Console.WriteLine($"The Area of Circle (float) would be {floatArearCir}");

            Console.WriteLine("--------------Area of Circle (double)---------------");
            Console.WriteLine("Enter Circle radious (double): ");
            double doubleRadious = Convert.ToDouble(Console.ReadLine());
            double doubleArearCir = objAreaOperations.AreaCircle<double>(doubleRadious, Convert.ToDouble(3.14));
            Console.WriteLine($"The Area of Circle (double) would be {doubleArearCir}");


            Console.WriteLine("****************Square********************");
            Console.WriteLine("");
            Console.WriteLine("--------------Area of Square (integer)---------------");
            Console.WriteLine("Enter Square radious (integer): ");
            int integerSide = Convert.ToInt32(Console.ReadLine());
            int integerArearSqua = objAreaOperations.AreaSquare<int>(integerSide);
            Console.WriteLine($"The Area of Square (integer) would be {integerArearSqua}");

            Console.WriteLine("--------------Area of Square (float)---------------");
            Console.WriteLine("Enter Square radious (float): ");
            float floatSide = Convert.ToSingle(Console.ReadLine());
            float floatArearSqua = objAreaOperations.AreaSquare<float>(floatSide);
            Console.WriteLine($"The Area of Square (float) would be {floatArearSqua}");

            Console.WriteLine("--------------Area of Square (decimal)---------------");
            Console.WriteLine("Enter Square radious (decimal): ");
            decimal decimalSide = Convert.ToDecimal(Console.ReadLine());
            decimal decimalArearSqua = objAreaOperations.AreaSquare<decimal>(decimalSide);
            Console.WriteLine($"The Area of Square (decimal) would be {decimalArearSqua}");

            goto start;
        }
    }
}
