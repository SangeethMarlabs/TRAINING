using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_Multiple_Records.Models;

namespace ViewBag_Multiple_Records.Controllers
{
    public class ListEmployeeController : Controller
    {
        // GET: ListEmployee
        public ActionResult Index()
        {
            List<Employee> lstEmployee = new List<Employee>()
            {
                new Employee()
                {
                    EmpId=5070,
                    EmpName="K Chenna",
                    EmpSal=100000
                },
                 new Employee()
                {
                    EmpId=5071,
                    EmpName="sai venkat",
                    EmpSal=120000
                }, 
                new Employee()
                {
                    EmpId=5072,
                    EmpName="Vamsi",
                    EmpSal=130000
                },
            };
            ViewBag.Employees = lstEmployee;
            return View();
        }
    }
}