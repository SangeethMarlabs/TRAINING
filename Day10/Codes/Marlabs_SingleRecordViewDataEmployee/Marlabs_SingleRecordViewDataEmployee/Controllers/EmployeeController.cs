using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marlabs_SingleRecordViewDataEmployee.Models;

namespace Marlabs_SingleRecordViewDataEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
                EmpId=101, EmpName="Sangeeth", EmpAddress1="Kerala", EmpAddress2="India", EmpContact="9633337115",EmpEmail="sangeeth@gmail.com",EmpSal=40000
            };
            ViewData["EmpName"] = objEmployee.EmpName;
            ViewData["EmpAddress1"] = objEmployee.EmpAddress1;
            ViewData["EmpAddress2"] = objEmployee.EmpAddress2;
            ViewData["EmpContact"] = objEmployee.EmpContact;
            ViewData["EmpEmail"] = objEmployee.EmpEmail;
            ViewData["EmpSal"] = objEmployee.EmpSal;
            ViewData["EmpId"] = objEmployee.EmpId;
            ViewData["Employee"] = objEmployee;
            return View();
        }
    }
}