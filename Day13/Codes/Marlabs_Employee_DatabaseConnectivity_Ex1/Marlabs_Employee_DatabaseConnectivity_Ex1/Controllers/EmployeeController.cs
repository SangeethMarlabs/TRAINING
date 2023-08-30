using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marlabs_Employee_DatabaseConnectivity_Ex1.Context;
using Marlabs_Employee_DatabaseConnectivity_Ex1.Models;

namespace Marlabs_Employee_DatabaseConnectivity_Ex1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeDbContext db = new EmployeeDbContext();
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Details(int id)
        {
            return View(db.Employees.Where(x => x.EmpID == id).FirstOrDefault());
        }
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            using(EmployeeDbContext entities = new EmployeeDbContext())
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();
                int id = employee.EmpID;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeDbContext employeeContext = new EmployeeDbContext();
            Employee employee = employeeContext.Employees.Where(emp => emp.EmpID == id).First();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var employeeData = db.Employees.Where(x => x.EmpID == emp.EmpID).FirstOrDefault();
            if(employeeData != null)
            {
                employeeData.EmpName = emp.EmpName;
                employeeData.EmpAddress = emp.EmpAddress;
                employeeData.EmpID = emp.EmpID;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeDbContext employeeContext = new EmployeeDbContext();
            Employee employee = employeeContext.Employees.Where(emp => emp.EmpID == id).First();
            return View(employee);
        }

        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var itemToRemove = db.Employees.SingleOrDefault(x => x.EmpID == id);
            if (itemToRemove != null)
            {
                db.Employees.Remove(itemToRemove);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}