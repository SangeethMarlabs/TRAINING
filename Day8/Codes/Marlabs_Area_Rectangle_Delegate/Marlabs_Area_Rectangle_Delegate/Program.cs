using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Area_Rectangle_Delegate
{
    class Program
    {
        public delegate T AreaRectangleDelgate<T>(T length, T width);
        public delegate T AreaSquareDelgate<T>(T side);
        public delegate T AreaCircleDelegate<T>(T radious);
        static void Main(string[] args)
        {
            Console.WriteLine("-------Integer Area operations delegate-------");
            Console.WriteLine("\n-------Area of rectangle-------");
            Console.WriteLine("Enter the length :: ");
            int intLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width :: ");
            int intWidth = Convert.ToInt32(Console.ReadLine());

            AreaRectangleDelgate<int> objareaRectangleDelgate = new 
        }
    }
}
