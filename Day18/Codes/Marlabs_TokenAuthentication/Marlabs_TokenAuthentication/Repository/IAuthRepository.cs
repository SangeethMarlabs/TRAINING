using Marlabs_TokenAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_TokenAuthentication.Repository
{
    public interface IAuthRepository
    {
        TblUser Register(TblUser user);
        TblUser Login(string email);
    }
}
