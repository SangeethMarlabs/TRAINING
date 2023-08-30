using System;
using System.Linq;
namespace Marlabs_LinqOperators_Last_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] objList1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] objList2 = { };

            //to get the last or defualt element | if the list is empty return the defualt value
            int result1 = objList1.LastOrDefault();           
            
            //to get the last or defualt element | if the list is empty return the defualt value
            int result2 = objList2.LastOrDefault();

            Console.WriteLine($"The last element from the list :: {result1}"); 
            Console.WriteLine($"The Last Or Default element from the list :: {result2}"); 
            Console.ReadLine();
        }
    }
}
