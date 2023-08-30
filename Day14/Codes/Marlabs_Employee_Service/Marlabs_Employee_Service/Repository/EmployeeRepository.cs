using Marlabs_Employee_Service.Models;
using Marlabs_Employee_Service.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_Employee_Service.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;
        public int CreateEmployee(Employee Employee)
        {
            this.employeeDbContext.Add(Employee);
            return this.employeeDbContext.SaveChanges();
        }

        public int DeleteEmployee(Employee Employee)
        {
            this.employeeDbContext.Employees.Remove(Employee);
            return 1;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employeeDbContext.Employees.ToList();
        }

        public Employee SearchEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(Employee Employee)
        {
            throw new NotImplementedException();
        }
    }
}
