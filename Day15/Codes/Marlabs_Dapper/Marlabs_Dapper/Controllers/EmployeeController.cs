using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marlabs_Dapper.Repository;
using Marlabs_Dapper.Models;

namespace Marlabs_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository iemployeeRepository;

        public EmployeeController(IEmployeeRepository _iemployeeRepository)
        {
            this.iemployeeRepository = _iemployeeRepository;
        }

        [HttpGet("GetAllEmployees")]
        public ActionResult<List<Employee>> GetAllEmployeeData()
        {
            return iemployeeRepository.GetAllEmployees();
        }

        [HttpGet("GetEmployeeById")]
        public Employee GetById(int empid)
        {
            return iemployeeRepository.GetById(empid);
        }

        [HttpPost("InsertEmployee")]
        public int AddEmployee(Employee emp)
        {
            return iemployeeRepository.AddEmployee(emp);
        }

        [HttpPut("UpdateEmployee")]
        public int UpdateEmployee(Employee emp)
        {
            return iemployeeRepository.UpdateEmployee(emp);
        }

        [HttpDelete("DeleteEmployee")]
        public int DeleteEmployee(int empId)
        {
            return iemployeeRepository.DeleteEmployee(empId);
        }

    } 
}
