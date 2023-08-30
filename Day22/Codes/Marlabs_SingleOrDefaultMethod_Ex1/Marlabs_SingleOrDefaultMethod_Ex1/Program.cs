using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_SingleOrDefaultMethod_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of students
            List<Student> objStudent = new List<Student>()
            {
                new Student(){Name="Sangeeth", Gender="Male",Location="Kerala"},
                new Student(){Name="Neha", Gender="Female",Location="MP"},
                new Student(){Name="Sreeshaila", Gender="Male",Location="Bangalore"},
                new Student(){Name="Sai", Gender="Male",Location="Bangalore"},
                new Student(){Name="Venkat", Gender="Male",Location="Bangalore"}
            };

            //Integer array
            int[] vs = { 1, 2, 3, 4, 5 };

            //Geting single records on both
            var user = objStudent.SingleOrDefault(s => s.Name == "Sangeeth");
            int val = vs.SingleOrDefault(i=> i > 6);

            //Printing results
            Console.WriteLine("The element from objStudent : {0}", user.Name);
            Console.WriteLine("The element from objList : {0}", val);

            Console.ReadLine();
        }
    }
}
