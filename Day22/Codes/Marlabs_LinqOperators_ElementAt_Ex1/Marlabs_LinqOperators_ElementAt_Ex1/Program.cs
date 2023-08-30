using System;
using System.Linq;
namespace Marlabs_LinqOperators_ElementAt_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array with values
            int[] a = { 1, 2, 3, 4, 5 };

            //Fetch the element from specified index position
            int result1 = a.ElementAt(1);
            int result2 = a.ElementAt(3);

            //Printing results
            Console.WriteLine("The element at Index 1 : {0}",result1); //2
            Console.WriteLine("The element at Index 3 : {0}",result2); //4 
            Console.ReadLine();
        }
    }
}
