﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Marlabs_InnerJoin_Ex1
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
            var result = from d in deptList
                         join e in empList
                         on d.DepId equals e.DeptId
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
}
