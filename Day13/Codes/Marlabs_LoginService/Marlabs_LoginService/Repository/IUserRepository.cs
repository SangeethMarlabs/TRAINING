using Marlabs_LoginService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_LoginService.Repository
{
    public interface IUserRepository
    {
        int CreateUser(User user);
        bool LoginValidate(string userName, string password);
    }
}
