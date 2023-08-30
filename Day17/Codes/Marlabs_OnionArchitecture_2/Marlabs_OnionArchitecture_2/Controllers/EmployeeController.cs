using Domain.Models;
using Marlabs_OnionArchitecture_2.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_OnionArchitecture_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository iemployeeRepository;
        IEmployeeQualificationRepository iemployeeQualificationRepository;
        IEmployeeProfessionalRepository iemployeeProfessionalRepository;

        public EmployeeController(IEmployeeRepository _iemployeeRepository, IEmployeeQualificationRepository _iemployeeQualificationRepository, IEmployeeProfessionalRepository _iemployeeProfessionalRepository)
        {
            this.iemployeeRepository = _iemployeeRepository;
            this.iemployeeQualificationRepository = _iemployeeQualificationRepository;
            this.iemployeeProfessionalRepository = _iemployeeProfessionalRepository;
        }


        [HttpGet("ListEmployees")]
        public ActionResult ListEmployees()
        {
            List<Employee> lstEmployee = new List<Employee>();
            iemployeeRepository.GetEmployees().ToList().ForEach(Emp =>
            {
                Employee employee = null;
                EmployeeProfessional employeeProfessional = iemployeeProfessionalRepository.GetEmployeeProfessional(Emp.Id);
                EmployeeQualification employeeQualification = iemployeeQualificationRepository.GetEmployeeQualification(Emp.Id);
                employee = new Employee()
                {
                    Id = Emp.Id,
                    EmpName = Emp.EmpName,
                    EmpAddress = Emp.EmpAddress,
                    EmpEmail = Emp.EmpEmail,
                    EmpContact = Emp.EmpContact,
                    ModifiedDate = Emp.ModifiedDate,
                    IPAddress = Emp.IPAddress,
                    EmployeeProfessional = new EmployeeProfessional
                    {
                        Id = employeeProfessional.Id,
                        EmpCompany = employeeProfessional.EmpCompany,
                        EmpDesignation = employeeProfessional.EmpDesignation,
                        EmpExperience = employeeProfessional.EmpExperience,
                        EmpSalary = employeeProfessional.EmpSalary,
                        Employee = employee,
                        ModifiedDate = DateTime.UtcNow,
                        IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                    },
                    EmployeeQualification = new EmployeeQualification
                    {
                        Employee = employee,
                        Id = employeeQualification.Id,
                        EmpCollege = employeeQualification.EmpCollege,
                        EmpCourse = employeeQualification.EmpCourse,
                        EmpDegree = employeeQualification.EmpDegree,
                        ModifiedDate = DateTime.UtcNow,
                        IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                    }
                };
                lstEmployee.Add(employee);
            });
            return Ok(lstEmployee);
        }


        [HttpPost("CreateEmployee")]
        public int CreateEmployee(EmployeeDTO model)
        {
            Employee EmployeeEntity = null;
            EmployeeEntity = new Employee
            {
                EmpName = model.EmpName,
                EmpAddress = model.EmpAddress,
                EmpEmail = model.EmpEmail,
                EmpContact = model.EmpContact,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                EmployeeProfessional = new EmployeeProfessional
                {
                    Id = model.Id,
                    EmpCompany = model.EmpCompany,
                    EmpDesignation = model.EmpDesignation,
                    EmpExperience = model.EmpExperience,
                    EmpSalary = model.EmpSalary,
                    Employee = EmployeeEntity,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                },
                EmployeeQualification = new EmployeeQualification
                {
                    Employee = EmployeeEntity,
                    Id = model.Id,
                    EmpCollege = model.EmpCollege,
                    EmpCourse = model.EmpCourse,
                    EmpDegree = model.EmpDegree,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iemployeeRepository.InsertEmployee(EmployeeEntity);
            return 1;
        }

        [HttpPost("UpdateEmployee")]
        public int UpdateEmployee(EmployeeDTO model)
        {
            Employee EmployeeEntity = null;
            EmployeeEntity = new Employee
            {
                Id = model.Id,
                EmpName = model.EmpName,
                EmpAddress = model.EmpAddress,
                EmpEmail = model.EmpEmail,
                EmpContact = model.EmpContact,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                EmployeeProfessional = new EmployeeProfessional
                {
                    Id = model.Id,
                    EmpCompany = model.EmpCompany,
                    EmpDesignation = model.EmpDesignation,
                    EmpExperience = model.EmpExperience,
                    EmpSalary = model.EmpSalary,
                    Employee = EmployeeEntity,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                },
                EmployeeQualification = new EmployeeQualification
                {
                    Employee = EmployeeEntity,
                    Id = model.Id,
                    EmpCollege = model.EmpCollege,
                    EmpCourse = model.EmpCourse,
                    EmpDegree = model.EmpDegree,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            iemployeeRepository.UpdatetEmployee(EmployeeEntity);
            return 1;
        }

        [HttpDelete("DeleteEmployee")]
        public int DeleteEmployee(long id)
        {
            iemployeeRepository.DeleteEmployee(id);
            return 1;
        }




    }
}
