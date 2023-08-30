using Marlabs_SimpleAuthorizarion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_SimpleAuthorizarion.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<User> WithoutPasswords(this IEnumerable<User> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static User WithoutPasswords(this User user)
        {
            user.Password = null;
            return user;
        }
    }
}
