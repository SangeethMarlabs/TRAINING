using System;
using System.Linq;

namespace Marlabs_Linq_Ex2
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

            foreach(var student in studentArray)
            {
                Console.WriteLine($"Student Id : {student.StudentId} " +
                    $" | Student Name : {student.StudentName}" +
                    $"\nStudent Address : {student.StudentAddress}" +
                    $" | Student Age : {student.StudentAge}" +
                    "");

                Console.WriteLine("---------------------------------------------------");
            }

            //Standard query operator in query syntax
            var students = from s in studentArray
                           where s.StudentAge > 20
                           select s;
            Console.WriteLine("====Standard query operator in query syntax====");
            foreach (var s1 in students)
            {
                Console.WriteLine($"Student Id : {s1.StudentId} " +
                    $" Student Name : {s1.StudentName}" +
                    $" Student Address : {s1.StudentAddress}" +
                    $" Student Age : {s1.StudentAge}" +
                    "");
            }



            //Standard query operator in Method syntax
            var studentsList = studentArray.Where(s => s.StudentAge > 20).ToList();

            Console.WriteLine("\n====Standard query operator in method syntax====");
            foreach (var s1 in studentsList)
            {
                Console.WriteLine($"Student Id : {s1.StudentId} " +
                    $" Student Name : {s1.StudentName}" +
                    $" Student Address : {s1.StudentAddress}" +
                    $" Student Age : {s1.StudentAge}" +
                    "");
            }


            Console.ReadLine();
        }
    }
}
