using System.Web.Mvc;
using Marlabs_SinglerecordViewData.Models;

namespace Marlabs_SinglerecordViewData.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer objCust = new Customer()
            {
                CustomerId = 100,
                CustomerName = "Sangeeth Sudhakaran",
                CustomerAddress = "India, Kerala"
            };
            ViewData["CustomerId"] = objCust.CustomerId;
            ViewData["CustomerName"] = objCust.CustomerName;
            ViewData["CustomerAddress"] = objCust.CustomerAddress;
            return View();
        }
    }
}