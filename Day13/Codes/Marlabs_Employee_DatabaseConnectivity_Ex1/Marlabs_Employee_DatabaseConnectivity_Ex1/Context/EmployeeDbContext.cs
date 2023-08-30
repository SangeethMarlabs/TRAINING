using System.Data.Entity;
using Marlabs_Employee_DatabaseConnectivity_Ex1.Models;

namespace Marlabs_Employee_DatabaseConnectivity_Ex1.Context
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
