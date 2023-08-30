using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_List_Collection_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmployee = new List<Employee>();
            List<Department> lstDept = new List<Department>()
            {
                new Department {DeptId=50, DeptName="IT" },
                new Department {DeptId=51, DeptName="HR" },
                new Department {DeptId=52, DeptName="Finance" }
            };

            Employee objEmployee1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Sangeeth",
                EmpAddress = "Kerala",
                EmpEmail = "sangeeth@gmail.com",
                lstDept = lstDept
            };
            Employee objEmployee2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Neha",
                EmpAddress = "Bangalore",
                EmpEmail = "neha@gmail.com",
                lstDept = lstDept
            };
            Employee objEmployee3 = new Employee()
            {
                EmpId = 102,
                EmpName = "Sai",
                EmpAddress = "Bangalore",
                EmpEmail = "sai@gmail.com",
                lstDept = lstDept
            };
            Employee objEmployee4 = new Employee()
            {
                EmpId = 102,
                EmpName = "Pooja",
                EmpAddress = "Bangalore",
                EmpEmail = "pooja@gmail.com",
                lstDept = lstDept
            };
            Employee objEmployee5 = new Employee()
            {
                EmpId = 102,
                EmpName = "Sreeshaila",
                EmpAddress = "Bangalore",
                EmpEmail = "sreeshaila@gmail.com",
                lstDept = lstDept
            };
           
            //obj adding to list employee
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
                    $"Employee Id : {Employee.EmpId}" +
                    $"Employee Name : {Employee.EmpName}" +
                    $"Employee Address : {Employee.EmpAddress}" +
                    $"Employee Email : {Employee.EmpEmail}" +
                    $"\n   --  Employee Departments  --   ");
                foreach (var Department in lstDept)
                {
                    Console.WriteLine($"DeptId:{Department.DeptId} DeptName:{Department.DeptName} ");
                }
                Console.WriteLine("----------------------------------------");
            } 
            Console.ReadLine();
        }
    }
}
