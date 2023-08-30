using System;
using System.Linq;
namespace Marlabs_Sum_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //to get the sum of array
            int sum = numbers.Sum();

            Console.WriteLine($"The Sum is {sum}");
            Console.ReadLine();
        }
    }
}
