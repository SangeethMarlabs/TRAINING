﻿using Marlabs_ViewMode1_Ex1.Models;
using Marlabs_ViewMode1_Ex1.ViewModel;
using Microsoft.AspNetCore.Mvc;
namespace Marlabs_ViewMode1_Ex1.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
                EmpID = 100, EmpDept="IT",EmpGender="Male",EmpName="Sangeeth",EmpSal="40000.00",AddressId=1001
            };

            Address objAddress = new Address()
            {
                AddressId=1001,Country="India",District="Thrissur",Pincode="680001",State="Kerala"
            };

            EmployeeDetailsViewModel objEmployeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = objEmployee,
                Address = objAddress,
                PageHeader = "Marlabs Employees",
                PageTitle = "Employee List"
            };
            return View(objEmployeeDetailsViewModel);
        }
    }
}
