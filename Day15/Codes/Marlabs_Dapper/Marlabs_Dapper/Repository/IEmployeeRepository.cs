using Marlabs_Dapper.Models;
using Marlabs_Dapper.Repository;
using System.Collections.Generic;
namespace Marlabs_Dapper.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetById(int empId);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int empId);
        List<Employee> GetAllEmployees();
    }
}
