using Marlabs_LoginService.EntityFrameWork;
using Marlabs_LoginService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_LoginService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }
        public int CreateUser(User user)
        {
            try
            {
                this.applicationDbContext.Add(user);
                this.applicationDbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool LoginValidate(string userName, string password)
        {
            var temp = applicationDbContext.User.Where(s => s.UserName == userName && s.Password == password).FirstOrDefault();
            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
