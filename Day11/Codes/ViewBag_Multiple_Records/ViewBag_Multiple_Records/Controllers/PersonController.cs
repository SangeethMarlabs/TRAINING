using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_Multiple_Records.Models;

namespace ViewBag_Multiple_Records.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            List<Person> lstPerson = new List<Person>()
            {
                new Person()
                {
                    PersonName="Kuni sai venkat",
                    PersonAddress="Andhra Pradesh",
                    PersonEmail="sai@gmail.com",
                    PersonContact="9182736450"
                },
                 new Person()
                {
                    PersonName="Galla Praveen",
                    PersonAddress="Karnataka",
                    PersonEmail="praveen14@gmail.com",
                    PersonContact="9103746274"
                },
                  new Person()
                {
                    PersonName="Siva Kumar",
                    PersonAddress="Madhya Pradesh",
                    PersonEmail="shiv1996@gmail.com",
                    PersonContact="8162035104"
                },
            };
            ViewBag.Persons = lstPerson;
            return View();
        }
    }
}