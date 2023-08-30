using System;
using Domain.Models;
using Infrastructure.Repository;
using System.Collections.Generic;

namespace Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        IGenericRepository<Employee> employeeRepository;
        IGenericRepository<EmployeeProfessional> employeeProfessionalRepository;
        IGenericRepository<EmployeeQualification> employeeQualificationRepository;

        public EmployeeRepository(IGenericRepository<Employee> _employeeRepository, IGenericRepository<EmployeeProfessional> _employeeProfessionalRepository,IGenericRepository<EmployeeQualification> _employeeQualificationRepository)
        {
            this.employeeRepository = _employeeRepository;
            this.employeeProfessionalRepository = _employeeProfessionalRepository;
            this.employeeQualificationRepository = _employeeQualificationRepository;
        }

        public void DeleteEmployee(long Id)
        {
            EmployeeProfessional employeeProfessional = employeeProfessionalRepository.GetT(Id);
            EmployeeQualification employeeQualification = employeeQualificationRepository.GetT(Id);
            employeeProfessionalRepository.Remove(employeeProfessional);
            employeeQualificationRepository.Remove(employeeQualification);

            Employee employee = GetEmployee(Id);
            employeeRepository.Remove(employee);
            employeeRepository.SaveChanges();
        }

        public Employee GetEmployee(long Id)
        {
            return employeeRepository.GetT(Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employeeRepository.GetAll();
        }

        public void InsertEmployee(Employee Employee)
        {
            employeeRepository.Insert(Employee);
        }

        public void UpdatetEmployee(Employee Employee)
        {
            employeeRepository.Update(Employee);
        }
    }
}
