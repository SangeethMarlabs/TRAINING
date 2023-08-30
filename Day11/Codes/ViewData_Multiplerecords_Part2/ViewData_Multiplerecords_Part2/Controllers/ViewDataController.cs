using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData_Multiplerecords_Part2.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        public ActionResult Index()
        {
            ViewData["name"] = "Marlabs Batch is Learnng View data";
            //return View();
            return RedirectToAction("Index1");
        }
        public ActionResult Index1()
        {
            try
            {
                string str = ViewData["name"].ToString();
                ViewData["string"] = str;
                return View();
            }
            catch(Exception ex)
            {
                string str = ex.Message;
                ViewData["error"] = str;
                return View();
            }

        }
    }
}