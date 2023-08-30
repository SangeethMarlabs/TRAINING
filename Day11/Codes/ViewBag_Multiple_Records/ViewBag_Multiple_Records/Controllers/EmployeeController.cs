using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_Multiple_Records.Models;

namespace ViewBag_Multiple_Records.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee objEmployee = new Employee()
            {
               EmpId=1001,
               EmpName="saivenkat",
               EmpSal=100000
            };
            ViewBag.EmpId = objEmployee.EmpId;
            ViewBag.EmpName = objEmployee.EmpName;
            ViewBag.EmpSal = objEmployee.EmpSal;

            return View();
        }
    }
}