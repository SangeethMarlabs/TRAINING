using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marlabs_ViewData_Multiple_Records.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("Canada");
            lstCountries.Add("UK");
            ViewData["Country"] = lstCountries;
            return View();
        }
    }
}