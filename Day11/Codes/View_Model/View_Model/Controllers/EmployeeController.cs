using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Model.Models;
using View_Model.ViewModel;

namespace View_Model.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
                EmpId = 1001,
                EmpName = "Kuni Sai Venkat",
                EmpDept = "EEE",
                EmpGender = "Male",
                EmpSal = 100000,
                AddressId = 1
            };
            Address objAddress = new Address()
            {
                AddressId=1,
                City="Kadapa",
                State="Andhra Pradesh",
                PinCode=516101,
                Country="INDIA"
            };
            EmployeeDetailsViewModel objEmployeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee=objEmployee,
                Address=objAddress,
                PageTitle="Employee Details",
                PageHeader= "Employee details"
            };
            return View(objEmployeeDetailsViewModel);
        }
    }
}