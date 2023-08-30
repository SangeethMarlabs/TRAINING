using System;
using System.Linq;
namespace Marlabs_Max_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 17, 52, 73, 754, 5, 67, 7, 878, 889 };

            //to get the max number
            int maximum = a.Max();

            Console.WriteLine($"The maximum number is {maximum}");
            Console.ReadLine();
        }
    }
}
