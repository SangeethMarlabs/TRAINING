using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_GroupBy_Linq_Ex7
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
                    StudentId = 2,StudentName="Sai",StudentAddress="Bangalore",StudentAge=18
                },
                new Student()
                {
                    StudentId = 3,StudentName="Parsha",StudentAddress="Chennai",StudentAge=19
                },
                new Student()
                {
                    StudentId = 4,StudentName="Neha",StudentAddress="MP",StudentAge=18
                },
                new Student()
                {
                    StudentId = 5,StudentName="Neha",StudentAddress="MP",StudentAge=19
                },                
                new Student()
                {
                    StudentId = 6,StudentName="Venkat",StudentAddress="Bangalore",StudentAge=20
                }

            };

            Console.WriteLine("Standard query syntax");
            var groupResult = from s in studentArray
                              group s by s.StudentAge;
            
            foreach (var ageGrp in groupResult)
            {
                Console.WriteLine($"\nAge Group :: {ageGrp.Key}");
                foreach (var s in ageGrp)
                {
                    Console.WriteLine($"Student Name :: {s.StudentName}");
                }
            }

            Console.WriteLine("\nStandard query syntax Method");
            var groupMethodResult = studentArray.GroupBy(s=> s.StudentAge);

            foreach (var ageGrp in groupMethodResult)
            {
                Console.WriteLine($"\nAge Group :: {ageGrp.Key}");
                foreach (var s in ageGrp)
                {
                    Console.WriteLine($"Student Name :: {s.StudentName}");
                }
            }


            Console.ReadLine();
        }
    }
}
