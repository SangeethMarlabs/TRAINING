using Marlabs_UnitOfWork.EntityFramework;
using Marlabs_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.Repository
{
public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbContext; public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }
        public void AddUser(User user)
        {
            applicationDbContext.User.Add(user);
        }
        public bool DeleteUser(long userId)
        {
            var removed = false;
            User user = GetUser(userId);
            if (user != null)
            {
                removed = true;
                applicationDbContext.User.Remove(user);
            }
            return removed;
        }
        public User GetUser(long Id)
        {
            return applicationDbContext.User.Where(u => u.UserId == Id).FirstOrDefault();
        }
        public IEnumerable<User> GetUsers()
        {
            return applicationDbContext.User;
        }
    }
}