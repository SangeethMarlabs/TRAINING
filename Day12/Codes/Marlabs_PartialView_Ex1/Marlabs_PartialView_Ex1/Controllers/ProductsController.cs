using Microsoft.AspNetCore.Mvc;
using Marlabs_PartialView_Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_PartialView_Ex1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult GetProdctsList()
        {
            List<Products> lstProducts = new List<Products>()
            {
               new Products{ProductId=100,ProductCategory="Smart Phone",ProductDecscription="128GB",ProductName="Redmi 11 Pro",ProductPrice=18000.00m},
               new Products{ProductId=101,ProductCategory="Smart Phone",ProductDecscription="32GB",ProductName="Redmi 11 Lite",ProductPrice=9000.00m},
               new Products{ProductId=102,ProductCategory="Smart Phone",ProductDecscription="128GB",ProductName="Redmi 9 Pro",ProductPrice=14000.00m},
               new Products{ProductId=103,ProductCategory="Smart Phone",ProductDecscription="64GB",ProductName="Redmi 9",ProductPrice=12000.00m},
               new Products{ProductId=104,ProductCategory="Smart Phone",ProductDecscription="128GB",ProductName="Realme 9i",ProductPrice=15000.00m}
            };
            return View(lstProducts);
        }
    }
}
