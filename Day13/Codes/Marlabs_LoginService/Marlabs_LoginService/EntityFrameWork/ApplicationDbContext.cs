using Marlabs_LoginService.Model;
using Microsoft.EntityFrameworkCore;

namespace Marlabs_LoginService.EntityFrameWork
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
