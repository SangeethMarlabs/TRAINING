using SimpleAuthorization.Entities;
using SimpleAuthorization.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAuthorization.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User{Id=1,FirstName="test",LastName="test",UserName="test",Password="test" }
        };
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.UserName == username && x.Password == password));

            //return null id user not found
            if (user == null)
                return null;

            //authentication successfull so return user details with password as null.
            return user.WithoutPassword();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run(() => _users.WithoutPasswords());
        }
    }
}