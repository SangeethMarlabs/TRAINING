using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_ThenBy_Linq_Ex6
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
                },
                new Student()
                {
                    StudentId = 5,StudentName="Neha",StudentAddress="MP",StudentAge=26
                }

            };

            var thenByResult = studentArray.OrderBy(s => s.StudentName).ThenBy(s => s.StudentAge);
            var thenByDescResult = studentArray.OrderBy(s => s.StudentName).ThenByDescending(s => s.StudentAge);

            Console.WriteLine("Then by Order");
            Console.WriteLine("Ascending Order");
            foreach (var std in thenByResult)
            {
                Console.WriteLine(std.StudentName);
            }

            Console.WriteLine("-------------------------");
            foreach (var std in thenByResult)
            {
                Console.WriteLine($"Name: {std.StudentName}  Age: {std.StudentAge}");
            }

            Console.WriteLine("\nDescending Order");
            foreach (var std in thenByDescResult)
            {
                Console.WriteLine($"Name: {std.StudentName}  Age: {std.StudentAge}");
            }

            Console.ReadLine();
        }
    }
}
