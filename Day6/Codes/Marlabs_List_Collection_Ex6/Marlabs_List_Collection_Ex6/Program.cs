using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_List_Collection_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring both lists
            List<Employee> lstEmployee = new List<Employee>();
            List<Department> lstDept = new List<Department>();

            Employee objEmployee = new Employee();
            Department objDepartment = new Department();

        start:
            //getting user inputs
            Console.WriteLine($"------------- Input Employee Details --------------");
            Console.WriteLine("Enter Employee Id :");
            int empId = Convert.ToInt32(Console.ReadLine());  
            
            Console.WriteLine("Enter Employee name :");
            string empName =  Console.ReadLine();

            Console.WriteLine("Enter Employee address :");
            string empAddress = Console.ReadLine();

            Console.WriteLine("Enter Employee contact :");
            string empContact = Console.ReadLine();

            Console.WriteLine("Enter Employee email :");
            string empEmail = Console.ReadLine();

            Console.WriteLine("Enter number of departments :");
            int numOfDepartment = Convert.ToInt32(Console.ReadLine());

            //getting dpt count and dept name
            lstDept = new List<Department>();
            for (int i =1; i<= numOfDepartment; i++)
            {
                Console.WriteLine("Enter Department name :");
                string deptName = Console.ReadLine();
                objDepartment = new Department();
                objDepartment.DepartmentName = deptName;
                lstDept.Add(objDepartment);
            }

            //adding new obj emp and dept to emp list
            objEmployee = new Employee()
            {
                EmpId = empId,
                EmpName = empName,
                EmpAddress = empAddress,
                EmpContacts =empContact,
                EmpEmail = empEmail,
                lstDept= lstDept
            };
            lstEmployee.Add(objEmployee);

            //printing Employee list
            Console.WriteLine($"------------- Employee Details --------------");
            foreach (var Employee in lstEmployee)
            {
                Console.WriteLine($"-------------Employee : {Employee.EmpName }-------------");
                Console.WriteLine($"" +
                    $"Employee Id : {Employee.EmpId}" +
                    $"Employee Name : {Employee.EmpName}" +
                    $"Employee Address : {Employee.EmpAddress}" +
                    $"Employee Email : {Employee.EmpEmail}" +
                    $"\n--Employee Departments--");

                foreach(var dept in Employee.lstDept)
                {
                    Console.WriteLine($"{dept.DepartmentName}");
                }
                Console.WriteLine("----------------------------------------");
            }
            Console.ReadLine();
            goto start;
        }
    }
}
