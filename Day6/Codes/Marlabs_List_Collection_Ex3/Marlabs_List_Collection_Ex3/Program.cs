using System;
using System.Collections.Generic;
namespace Marlabs_List_Collection_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployee = new List<Employee>();

            //creating employee objects
            Employee objEmployee1 = new Employee()
            {
                EmpId = 100,
                EmpName ="Sangeeth",
                EmpAddress = "Kerala"
            };
            Employee objEmployee2 = new Employee()
            {
                EmpId = 101,
                EmpName ="Neha",
                EmpAddress = "Bangalore"
            };            
            Employee objEmployee3 = new Employee()
            {
                EmpId = 102,
                EmpName ="Sai",
                EmpAddress = "Bangalore"
            };            
            Employee objEmployee4 = new Employee()
            {
                EmpId = 103,
                EmpName ="Rakesh",
                EmpAddress = "Bangalore"
            };            
            Employee objEmployee5 = new Employee()
            {
                EmpId = 104,
                EmpName ="Sreeshaila",
                EmpAddress = "Bangalore"
            };

            //adding objects to Employee List
            lstEmployee.Add(objEmployee1);
            lstEmployee.Add(objEmployee2);
            lstEmployee.Add(objEmployee3);
            lstEmployee.Add(objEmployee4);
            lstEmployee.Add(objEmployee5);

            //printing Employee list
            Console.WriteLine($"------------- Employee Details --------------");
            foreach (var Employee in lstEmployee)
            {
                Console.WriteLine($"-------------Employee : {Employee.EmpName }-------------");
                Console.WriteLine($"" +
                    $"\nEmployee Id      : {Employee.EmpId }" +
                    $"\nEmployee Name    : {Employee.EmpName }" +
                    $"\nEmployee Address : {Employee.EmpAddress }" +
                    $"\n--------------------------------------------\n");
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
    }
}
