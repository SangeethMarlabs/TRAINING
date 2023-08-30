using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_Var_Keyword_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.empId = 100;
            objEmployee.empName = "Sreeshaila";
            objEmployee.EmpInfo();
           
            Console.WriteLine($"Emp Name is {objEmployee.Empinformation()}");


            dynamic i;
            i = "Sangeeth";
            Console.WriteLine(i + " - " + i.GetType());            
            i =100;
            Console.WriteLine(i + " - " + i.GetType());            
            i =100.34;
            Console.WriteLine(i + " - " + i.GetType());           
            i =new Employee();
            Console.WriteLine(i + " - " + i.GetType());


            Console.ReadLine();
        }
    }
}
