using System.Collections.Generic;
using System.Web.Mvc;
using Marlabs_ViewData_Multiple_Records.Models;

namespace Marlabs_ViewData_Multiple_Records.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employees> lstEmployees = new List<Employees>()
            {
                new Employees()
                {
                    EmpId=101, EmpName="Sangeeth",EmpSalary=40000.00m
                },
                new Employees()
                {
                    EmpId=102, EmpName="Sreeshaila",EmpSalary=50000.00m
                },
                new Employees()
                {
                    EmpId=103, EmpName="Neha",EmpSalary=60000.00m
                },
                new Employees()
                {
                    EmpId=104, EmpName="Venkat",EmpSalary=50000.00m
                },
                new Employees()
                {
                    EmpId=105, EmpName="Sai",EmpSalary=40000.00m
                },
            };
            ViewData["Employees"] = lstEmployees;
            return View();
        }
    }
}