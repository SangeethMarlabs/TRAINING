using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marlabs_FirstApp.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        public ActionResult Index()
        {
            int sum = Addition(10, 20);
            int mul = Multiplication(10, 20);
            string strC = StringConcat("Sangeeth", "Sudhakaran");
            ViewData["CurrentDateTime"] = DateTime.Now;
            ViewData["Name"] = "Sangeeth Sudhakaran";
            ViewData["Sum"] = sum;
            ViewData["Mul"] = mul;
            ViewData["StringConcat"] = strC;

            return View();
        }
        public int Addition(int a,int b)
        {
            return a + b;
        }        
        public int Multiplication(int a,int b)
        {
            return a * b;
        }        
        public string StringConcat(string a,string b)
        {
            return a + " " + b;
        }
    }
}