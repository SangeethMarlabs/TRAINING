using System;
using System.Linq;
namespace Marlabs_Min_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //to get the min number
            int minimum = a.Min();    

            Console.WriteLine($"The minimum number is {minimum}");
            Console.ReadLine();
        }
    }
}
