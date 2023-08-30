using System;
using System.Linq;
namespace Marlabs_DefaultIfMethod_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = {};

            var result1 = a.DefaultIfEmpty();
            var result2 = b.DefaultIfEmpty();

            Console.WriteLine("-------List1 with values----------");
            foreach(var val1 in result1)
            {
                Console.WriteLine(val1);
            }

            Console.WriteLine("-------List2 without values-------");
            foreach (var val2 in result2)
            {
                Console.WriteLine(val2);
            }

            Console.ReadLine();
        }
    }
}
