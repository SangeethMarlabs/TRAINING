using Marlabs_Employee_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_Employee_Service.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee SearchEmployee(int id);
        int UpdateEmployee(Employee Employee);
        int CreateEmployee(Employee Employee);
        int DeleteEmployee(Employee Employee);
    }
}
