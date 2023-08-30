using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_Multiple_Records.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("UK");
            lstCountries.Add("Germany");
            lstCountries.Add("Russia");
            lstCountries.Add("Japan");
            lstCountries.Add("Indonesia");

            ViewBag.Countries = lstCountries;
            return View();
        }
    }
}