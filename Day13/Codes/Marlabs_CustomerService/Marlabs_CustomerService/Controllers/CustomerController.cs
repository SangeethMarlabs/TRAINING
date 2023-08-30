using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_CustomerService.Repository;
using Marlabs_CustomerService.Models;

namespace Marlabs_CustomerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository icustomerRepository;

        public CustomerController(ICustomerRepository _icustomerRepository)
        {
            icustomerRepository = _icustomerRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateCustomer(Customer customer)
        {
            return Ok(icustomerRepository.CreateCustomer(customer));
        }

        [HttpGet("CustomerList")]
        public ActionResult GetCustomerList()
        {
            return Ok(icustomerRepository.GetCustomers());
        }

        [HttpGet("SearchCustomerById")]
        public ActionResult SearchCustomer(int customerId)
        {
            return Ok(icustomerRepository.SearchCustomer(customerId));
        }

        [HttpPost("Delete")]
        public ActionResult DeleteCustomer(Customer customer)
        {
            return Ok(icustomerRepository.DeleteCustomer(customer));
        }

        [HttpPost("Update")]
        public ActionResult UpdateCustomer(Customer customer)
        {
            return Ok(icustomerRepository.UpdateCustomer(customer));
        }

    }
}
