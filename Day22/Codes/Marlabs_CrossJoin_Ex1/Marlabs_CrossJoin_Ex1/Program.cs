using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marlabs_CrossJoin_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Department list
            List<Department> deptList = new List<Department>()
            {
                new Department(){DepId=1,DepName="IT"},
                new Department(){DepId=2,DepName="HR"},
                new Department(){DepId=3,DepName="Software"},
                new Department(){DepId=4,DepName="Accounts"},
            };


            //Employee list
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){ EmpId=1,Name="Sangeeth",DeptId=3},
                new Employee(){ EmpId=2,Name="Neha Wanjari",DeptId=3},
                new Employee(){ EmpId=3,Name="Sreeshaila",DeptId=3},
                new Employee(){ EmpId=4,Name="Kopparam Sai",DeptId=4},
                new Employee(){ EmpId=5,Name="Kunisai Venkat"},
            };

            //Join dept and emp and store the output in variable result
            var result = from e in empList
                         from d in deptList
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.DepName
                         };

            //print values
            foreach (var item in result)
            {
                Console.WriteLine(item.EmployeeName + "\t | " + item.DepartmentName);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }

    public class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
    }
}
