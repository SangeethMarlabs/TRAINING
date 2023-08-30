using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_Employee_Service.Repository;
using Marlabs_Employee_Service.Models;


namespace Marlabs_Employee_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository iemployeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepository)
        {
            iemployeeRepository = _employeeRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateEmployee(Employee employee)
        {
            return Ok(iemployeeRepository.CreateEmployee(employee));
        }

        [HttpGet("EmployeeList")]
        public ActionResult GetEmployeeList()
        {
            return Ok(iemployeeRepository.GetEmployees());
        }

    }
}
