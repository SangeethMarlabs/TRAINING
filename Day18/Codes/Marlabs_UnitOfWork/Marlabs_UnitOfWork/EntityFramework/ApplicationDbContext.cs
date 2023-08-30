using Marlabs_UnitOfWork.Models;
using Microsoft.EntityFrameworkCore; 
namespace Marlabs_UnitOfWork.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}

