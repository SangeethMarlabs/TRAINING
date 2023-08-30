using Microsoft.EntityFrameworkCore;
using Marlabs_Employee_Service.Models;

namespace Marlabs_Employee_Service.EntityFramework
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            new EmployeeMap(modelbuilder.Entity<Employee>());
        }
    }
}
