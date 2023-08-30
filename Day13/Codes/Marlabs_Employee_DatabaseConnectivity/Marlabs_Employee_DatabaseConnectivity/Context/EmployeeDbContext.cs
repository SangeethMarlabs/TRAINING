using System.Data.Entity;
using Marlabs_Employee_DatabaseConnectivity.Models;

namespace Marlabs_Employee_DatabaseConnectivity.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
