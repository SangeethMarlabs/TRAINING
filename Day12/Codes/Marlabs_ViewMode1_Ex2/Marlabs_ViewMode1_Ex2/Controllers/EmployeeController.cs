using Marlabs_ViewMode1_Ex2.Models;
using Marlabs_ViewMode1_Ex2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Marlabs_ViewMode1_Ex2.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetEmployeeDetails()

        {
            List<EmployeeDetailsViewModel> lstEmployee = new List<EmployeeDetailsViewModel>();
            Employee objEmployee = new Employee()
            {
                EmpID = 100, EmpDept = "IT", EmpGender = "Male", EmpName = "Sangeeth",  EmpSal = "40000.00", AddressId = 1001
            };

            Address objAddress = new Address()
            {
                AddressId = 1001, Country = "India", District = "Thrissur", Pincode = "680001", State = "Kerala"
            };

            EmployeeDetailsViewModel objEmployeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = objEmployee, Address = objAddress,  PageHeader = "Marlabs", PageTitle = "Employee List"
            };



            Employee objEmployee1 = new Employee()
            {
                EmpID = 101, EmpDept = "IT", EmpGender = "Male", EmpName = "Sreeshaila",  EmpSal = "50000.00", AddressId = 1002
            };

            Address objAddress1 = new Address()
            {
                AddressId = 1002, Country = "India", District = "Bangalre", Pincode = "580001", State = "Karnataka"
            };

            EmployeeDetailsViewModel objEmployeeDetailsViewModel1 = new EmployeeDetailsViewModel()
            {
                Employee = objEmployee1, Address = objAddress1,  PageHeader = "Marlabs", PageTitle = "Employee List"
            };


            lstEmployee.Add(objEmployeeDetailsViewModel);
            lstEmployee.Add(objEmployeeDetailsViewModel1);


            return View(lstEmployee);
        }
         
    }
}
