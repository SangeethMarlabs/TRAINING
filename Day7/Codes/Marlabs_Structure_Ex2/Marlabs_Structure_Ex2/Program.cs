using System;
namespace Marlabs_Structure_Ex2
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
            Console.WriteLine("Enter employee details");

            Console.WriteLine("Enter Employee Id");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee gender");
            string empGender = Console.ReadLine();

            Console.WriteLine("Enter Employee salary");
            int empSalary = Convert.ToInt32(Console.ReadLine());

            Employee emp;
            emp.empId = empId;
            emp.empName = empName;
            emp.empGender = empGender;
            emp.empSalary = empSalary;

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
