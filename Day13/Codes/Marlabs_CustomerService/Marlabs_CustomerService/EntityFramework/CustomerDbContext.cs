using Microsoft.EntityFrameworkCore;
using Marlabs_CustomerService.Models;
namespace Marlabs_CustomerService.EntityFramework
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
           new CustomerMap(modelbuilder.Entity<Customer>());
        }
    }
}
