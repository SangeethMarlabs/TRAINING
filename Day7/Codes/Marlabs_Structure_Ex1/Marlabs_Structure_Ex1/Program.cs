using System;

namespace Marlabs_Structure_Ex1
{
    class Program
    {
        struct Employee
        {
            public int empId;
            public string empName;
            public string empGender;
            public int empSalary;
        }
        static void Main(string[] args)
        {
            Employee emp;
            emp.empId = 100;
            emp.empName = "Sangeeth";
            emp.empGender = "Male";
            emp.empSalary = 40000;

            Console.WriteLine($"---------Emp Details-----------" +
                $"\nEmp Id : {emp.empId}" +
                $"\nEmp Name : {emp.empName}" +
                $"\nEmp Gender : {emp.empGender}" +
                $"\nEmp Salary : {emp.empSalary}" +
                $"\n-------------------------------");
            Console.ReadLine();
        }
    }
}
