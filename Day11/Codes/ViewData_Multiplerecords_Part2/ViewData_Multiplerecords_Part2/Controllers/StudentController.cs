using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData_Multiplerecords_Part2.Models;

namespace ViewData_Multiplerecords_Part2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> lstStudents = new List<Student>()
            {
                new Student()
                {
                    StudentId=5001,
                    StudentName="Aravind",
                    StudentEmail="Aravi23@gmail.com",
                    StudentAddress="Kerala"
                },
                new Student()
                {
                    StudentId=5002,
                    StudentName="KrishnaKanth",
                    StudentEmail="Krish98@gmail.com",
                    StudentAddress="Andhra Pradesh"
                },
                new Student()
                {
                    StudentId=5003,
                    StudentName="Sarwan",
                    StudentEmail="sarwa05@gmail.com",
                    StudentAddress="Banglore"
                },
                new Student()
                {
                    StudentId=5004,
                    StudentName="Subhankar",
                    StudentEmail="subbu@gmail.com",
                    StudentAddress="Delhi"
                },
                new Student()
                {
                    StudentId=5005,
                    StudentName="Sai Venkat",
                    StudentEmail="sai@gmail.com",
                    StudentAddress="Anhdra Pradesh"
                },
            };
            ViewData["Students"] = lstStudents;
            return View();
        }
    }
}