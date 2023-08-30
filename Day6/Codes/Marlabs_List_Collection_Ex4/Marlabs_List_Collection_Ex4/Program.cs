using System;
using System.Collections.Generic;

namespace Marlabs_List_Collection_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployee = new List<Employee>();
        
        start:
            Console.WriteLine("Enter Employee details");
            Console.WriteLine("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            string empName = Console.ReadLine();            
            Console.WriteLine("Enter Employee Address : ");
            string empAddress = Console.ReadLine();

            Employee objEmployee1 = new Employee()
            {
                EmpId = empId,
                EmpName = empName,
                EmpAddress = empAddress
            };

            lstEmployee.Add(objEmployee1);

            //printing Employee list
            Console.WriteLine($"------------- Employee Details --------------");
            Console.WriteLine($"-------------Employee : {objEmployee1.EmpName }-------------");
            Console.WriteLine($"" +
                $"\nEmployee Id      : {objEmployee1.EmpId }" +
                $" Employee Name    : {objEmployee1.EmpName }" +
                $"\nEmployee Address : {objEmployee1.EmpAddress }" +
                $"\n--------------------------------------------\n");

            Console.ReadLine();
      goto start;
        }
    }
}
