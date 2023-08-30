using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> objEmpId = new Employee<int>();
            objEmpId.value = 101;

            Employee<string> objEmpName = new Employee<string>();
            objEmpName.value = "Sangeeth";

            Employee<float> objEmpSal = new Employee<float>();
            objEmpSal.value = 40000f;

            Console.WriteLine($"Emp Id : {objEmpId.value} Emp Name : {objEmpName.value} Emp Salary : {objEmpSal.value} ");
            Console.ReadLine();
        }
    }
}
