using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_Multiple_Records.Models;

namespace ViewBag_Multiple_Records.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student objStudent = new Student()
            {
                stuId=5071,
                stuName="Kuni Sai Venkat",
                stuEmail="KuniSai@gmail.com",
                stuContact="9848535495",
                stuAddress="Andhra Pradesh"
            };
            ViewBag.StudentId = objStudent.stuId;
            ViewBag.StudentName = objStudent.stuName;
            ViewBag.StudentEmail = objStudent.stuEmail;
            ViewBag.StudentContact = objStudent.stuContact;
            ViewBag.StudentAddress = objStudent.stuAddress;

            return View();
        }
    }
}