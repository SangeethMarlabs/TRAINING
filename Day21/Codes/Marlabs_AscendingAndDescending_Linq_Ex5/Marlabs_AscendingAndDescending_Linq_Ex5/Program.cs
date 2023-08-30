using System;
using System.Linq;

namespace Marlabs_AscendingAndDescending_Linq_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray =
{
                new Student()
                {
                    StudentId = 1, StudentName="Pooja",StudentAddress="Bangalore",StudentAge=18
                },
                new Student()
                {
                    StudentId = 2,StudentName="Sai",StudentAddress="Bangalore",StudentAge=19
                },
                new Student()
                {
                    StudentId = 3,StudentName="Parsha",StudentAddress="Chennai",StudentAge=22
                },
                new Student()
                {
                    StudentId = 4,StudentName="Neha",StudentAddress="MP",StudentAge=24
                }
            };

            Console.WriteLine("************Standard query syntax*********");
            var OrderByResult = from s in studentArray
                                orderby s.StudentName ascending
                                select s;

            var OrderByDescentingResult = from s in studentArray
                                          orderby s.StudentName descending
                                          select s;

            Console.WriteLine("Ascending Order");
            foreach (var std in OrderByResult)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Descending Order");
            foreach (var std in OrderByDescentingResult)
            {
                Console.WriteLine(std.StudentName);
            }


            Console.WriteLine("\n************Standard query syntax in Method Syntax*********");
            var stuMethodInAscendingOrder = studentArray.OrderBy(s => s.StudentName).ToList();
            var stuMethodInDescendingOrder = studentArray.OrderByDescending(s => s.StudentName).ToList();

            Console.WriteLine("Ascending Order");
            foreach (var std in stuMethodInAscendingOrder)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Ascending Order");
            foreach (var std in stuMethodInAscendingOrder)
            {
                Console.WriteLine($"Name: {std.StudentName}  Age: {std.StudentAge}");
            }

            Console.WriteLine("Descending Order");
            foreach (var std in stuMethodInDescendingOrder)
            {
                Console.WriteLine($"Name: {std.StudentName}  Age: {std.StudentAge}");
            }

            Console.ReadLine();
        }
    }
}
