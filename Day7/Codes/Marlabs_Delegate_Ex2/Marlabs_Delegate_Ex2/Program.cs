using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Delegate_Ex2
{
    class Program
    {
        public delegate int AreaRectangle(int length, int width);
        public delegate int AreaSquare(int side);
        public delegate int AreaCircle(double radious);
        public delegate void petanim(string name);

        static void Main(string[] args)
        {
        start:
            petanim p = delegate (string name)
            {
                Console.WriteLine("My pet Animal is " + name);
            };

            p("Dog");


            Console.WriteLine("--------Creating onject of Area -------");
            Area objArea = new Area();

            AreaRectangle objAreaRectangle = new AreaRectangle(objArea.AreaRectangle);
            Console.WriteLine("--------Area Rectangle-------");
            Console.WriteLine($"Enter the length of rectangle");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the width of rectangle");
            int width = Convert.ToInt32(Console.ReadLine());

            int areaRect = objAreaRectangle.Invoke(length, width);
            Console.WriteLine($"The Area of rectangle would be :: {areaRect}");

            Console.WriteLine("--------Area Square-------");
            Console.WriteLine($"Enter the side of square");
            int side = Convert.ToInt32(Console.ReadLine());

            AreaSquare objAreaSquare = new AreaSquare(objArea.AreaSquare);
            int areaSquare = objAreaSquare.Invoke(side);
            Console.WriteLine($"The Area of square would be :: {areaRect}");

            Console.WriteLine("--------Area Circle-------");
            Console.WriteLine($"Enter the radious of circle");
            double radious = Convert.ToDouble(Console.ReadLine());

            //AreaCircle objAreaCircle = new AreaCircle(objArea.AreaCircle);
            //double areaCircle = objAreaCircle.Invoke(radious);
            //Console.WriteLine($"The Area of Circle  would be :: {areaCircle}");


            goto start;
        }
    }
}
