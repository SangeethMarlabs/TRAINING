using System;
using System.Linq;
namespace Marlabs_Linq_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            string[] names = { "Neha","Sangeeth", "Sreeshaila" };

            //Liqu query
            var myNames = from name in names
                          select name;

            //query execution
            Console.WriteLine("*********Names would be*********");

            foreach (var name in myNames)
            {
                Console.WriteLine(name);
            }

            //Liqu query
            var myNames1 = from name in names
                           where name.Contains("ha")
                           select name;

            //query execution
            Console.WriteLine("*********Names would be with letter ha**********");

            foreach (var name in myNames1)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
