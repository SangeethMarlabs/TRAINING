using System.Data.Entity;
using Marlabs_Customer_DatabaseConnectivity_Ex2.Models;

namespace Marlabs_Customer_DatabaseConnectivity_Ex2.Context
{
    public class CustomerDbContext :DbContext
    {
        public DbSet<Customer> Customer { get; set; }
    }
}