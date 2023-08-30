using System;
using System.Linq;
namespace Marlabs_ElementAtOrDefault_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Array with values
            int[] a = { 1, 2, 3, 4, 5 };

            //Fetch the element from specific index position
            int result1 = a.ElementAtOrDefault(1);
            int result2 = a.ElementAtOrDefault(3);
            int result3 = a.ElementAtOrDefault(10);

            //Printing results
            Console.WriteLine("The element at Index 1 : {0}", result1); //2
            Console.WriteLine("The element at Index 3 : {0}", result2); //4 
            Console.WriteLine("The element at Index 10 : {0}", result3); //0 no data then return the defualt value

            Console.ReadLine();
        }
    }
}
