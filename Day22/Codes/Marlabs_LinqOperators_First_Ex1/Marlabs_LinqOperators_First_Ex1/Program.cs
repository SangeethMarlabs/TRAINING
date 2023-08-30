using System;
using System.Linq;
namespace Marlabs_LinqOperators_First_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] objList1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] objList2 = { };

            int result1 = objList1.First();

            //the first or defualt method is used to return the first element from the list
            //If the list is empty then it will return defualt value
            int result2 = objList2.FirstOrDefault();

            Console.WriteLine($"The first element from the list1 :: {result1}");
            Console.WriteLine($"The first or default element from the list2 :: {result2}");
            Console.ReadLine();
        }
    }
}
