using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marlabs_ViewData_Multiple_Records.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            List<string> lstCourse = new List<string>();
            lstCourse.Add("MCA");
            lstCourse.Add("BCA");
            lstCourse.Add("BBA");
            lstCourse.Add("MBA");
            lstCourse.Add("MTech");
            ViewData["Course"] = lstCourse;
            return View();
        }
    }
}