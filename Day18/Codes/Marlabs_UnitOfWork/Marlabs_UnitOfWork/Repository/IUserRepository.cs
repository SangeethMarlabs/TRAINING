using Marlabs_UnitOfWork.Models;
using System.Collections.Generic;

namespace Marlabs_UnitOfWork.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(long userId);
        User GetUser(long Id);
    }

}
