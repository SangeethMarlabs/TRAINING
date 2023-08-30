using System;
namespace Marlabs_AnonymousMethod
{
    class Program
    {
        public delegate int AreaRectangle(int length, int width);
        public delegate int AreaSquare(int side);
        public delegate double AreaCircle(int radious);
        static void Main(string[] args)
        {
            Console.WriteLine("--------Area Rectangle-------");
            AreaRectangle objAreaRectangle = delegate (int length, int width)
            {
                return length * width;
            };
            int areaRect = objAreaRectangle(90, 90);
            Console.WriteLine($"Area of rectangle would be {areaRect}");

            
            Console.WriteLine("--------Area Square-------");
            AreaSquare objAreaSquare = delegate (int side)
            {
                return side * side;
            };
            int areaSquare = objAreaSquare(90);
            Console.WriteLine($"Area of Square would be {areaSquare}");

            Console.WriteLine("--------Area Circle-------");
            AreaCircle objAreaCircle = delegate (int radious)
            {
                return 3.14 * (radious * radious);
            };
            double areaCircle = objAreaCircle(90);
            Console.WriteLine($"Area of Circle would be {areaCircle}");

            Console.ReadLine();
        }
    }
}
