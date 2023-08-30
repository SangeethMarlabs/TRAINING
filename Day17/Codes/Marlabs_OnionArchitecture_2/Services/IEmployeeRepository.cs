using Domain.Models;
using System.Collections.Generic;
namespace Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(long Id);
        void InsertEmployee(Employee Employee);
        void UpdatetEmployee(Employee Employee);
        void DeleteEmployee(long Id);
    }
}
