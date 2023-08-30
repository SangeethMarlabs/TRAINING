using SimpleAuthorization.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleAuthorization.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username,string password);
        Task<IEnumerable<User>> GetAll();
    }
}
