using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_Dapper_Customer.Models;
using Marlabs_Dapper_Customer.Repository;

namespace Marlabs_Dapper_Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository icustomerRepository;

        public CustomerController(ICustomerRepository _icustomerRepository)
        {
            this.icustomerRepository = _icustomerRepository;
        }
        
        [HttpGet("GetAllCustomers")]
        public ActionResult<List<Customer>> GetAllCustomerData()
        {
            return icustomerRepository.GetAllCustomers();
        }

        [HttpGet("GetCustomerById")]
        public Customer GetById(int empid)
        {
            return icustomerRepository.GetById(empid);
        }

        [HttpPost("InsertCustomer")]
        public int AddCustomer(Customer emp)
        {
            return icustomerRepository.AddCustomer(emp);
        }

        [HttpPut("UpdateCustomer")]
        public int UpdateCustomer(Customer emp)
        {
            return icustomerRepository.UpdateCustomer(emp);
        }

        [HttpDelete("DeleteCustomer")]
        public int DeleteCustomer(int empId)
        {
            return icustomerRepository.DeleteCustomer(empId);
        }
    }
}
