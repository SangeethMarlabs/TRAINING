using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Func_Delegate_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("-------Func delegates Area operations with user inputs-------");
            Console.WriteLine("Enter length of rectangle ::");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle ::");
            int width = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> areaRectangleDelegate = new AreaOperations().AreaRectangle;
            int areaRectangle = areaRectangleDelegate.Invoke(length, width);
            Console.WriteLine($"The area of rectangle would be :: {areaRectangle}");

            Console.WriteLine("Enter side of square ::");
            int side = Convert.ToInt32(Console.ReadLine());
            Func<int, int> areaSquareDelegate = new AreaOperations().AreaSquare;
            int areaSquare = areaSquareDelegate.Invoke(side);
            Console.WriteLine($"The area of rectangle would be :: {areaSquare}");


            Console.WriteLine("Enter radious of Circle ::");
            int radious = Convert.ToInt32(Console.ReadLine());
            Func<int, double> areaCircleDelegate = new AreaOperations().AreaCircle;
            double areaCircle = areaCircleDelegate.Invoke(radious);
            Console.WriteLine($"The area of circle would be :: {areaCircle}");

            Console.WriteLine("Enter height of triangle ::");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter base of triangle ::");
            width = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> areaTriangleDelegate = new AreaOperations().AreaTrinagle;
            int areaTriangle = areaTriangleDelegate.Invoke(height, width);
            Console.WriteLine($"The area of triangle would be :: {areaTriangle}");

            goto start;
        }
    }
}
