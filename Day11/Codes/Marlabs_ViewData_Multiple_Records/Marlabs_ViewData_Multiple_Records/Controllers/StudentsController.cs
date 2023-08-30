using System.Collections.Generic;
using System.Web.Mvc;
using Marlabs_ViewData_Multiple_Records.Models;

namespace Marlabs_ViewData_Multiple_Records.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Students> lstStudents = new List<Students>()
            {
                
                new Students
                {
                    StudentId=100,StudentName="Sangeeth",StudentAddress="Kerala",StudentEmail="sangeeth@gmail.com"
                },                
                new Students
                {
                    StudentId=101,StudentName="Sreeshaila",StudentAddress="Bangalore",StudentEmail="sreeshaila@gmail.com"
                },                
                new Students
                {
                    StudentId=102,StudentName="Neha",StudentAddress="bangalore",StudentEmail="neha@gmail.com"
                },                
                new Students
                {
                    StudentId=103,StudentName="Sai",StudentAddress="Bangalore",StudentEmail="sai@gmail.com"
                },
                new Students
                {
                    StudentId = 104,StudentName = "Praveena",StudentEmail = "Praveena@gmail.com",StudentAddress="Kurnool"
                },
            };
            ViewData["Students"] = lstStudents;
            return View();
        }
    }
}