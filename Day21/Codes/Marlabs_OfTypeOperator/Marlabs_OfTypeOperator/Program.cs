using System;
using System.Collections;
using System.Linq;

namespace Marlabs_OfTypeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(5);
            mixedList.Add(new Student() 
            { 
                StudentId = 1,StudentName="Sangeeth",StudentAge=28,StudentAddress="Kerala"
            });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;
            var intResult = from s in mixedList.OfType<int>()
                            select s;            
            var stdResult = from s in mixedList.OfType<Student>()
                            select s;

            foreach(var str in stringResult)
            {
                Console.WriteLine(str);
            }
            
            foreach(var i in intResult)
            {
                Console.WriteLine(i);
            }    
            
            foreach(var str in stdResult)
            {
                Console.WriteLine(str.StudentName);
            }

            Console.WriteLine("Standard query syntax in Method syntax");
            var stringMethodResult = mixedList.OfType<string>();
            var intMethodResult = mixedList.OfType<int>();
            var stdMethodResult = mixedList.OfType<Student>();

            foreach (var str in stringMethodResult)
            {
                Console.WriteLine(str);
            }

            foreach (var i in intMethodResult)
            {
                Console.WriteLine(i);
            }

            foreach (var str in stdMethodResult)
            {
                Console.WriteLine(str.StudentName);
            }

            Console.ReadLine();
        }
    }
}
