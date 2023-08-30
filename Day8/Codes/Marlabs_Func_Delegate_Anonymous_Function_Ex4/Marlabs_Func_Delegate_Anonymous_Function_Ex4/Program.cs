using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Func_Delegate_Anonymous_Function_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("-------Func delegates Area operations | anonymouse functions with user inputs-------");
            Console.WriteLine("Enter length of rectangle ::");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle ::");
            int width = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> areaRectangleDelegate(int length, int width)
            {

            };
            int areaRectangle = areaRectangleDelegate.Invoke(length, width);
            Console.WriteLine($"The area of rectangle would be :: {areaRectangle}");
             
            goto start;
        }
    }
}
