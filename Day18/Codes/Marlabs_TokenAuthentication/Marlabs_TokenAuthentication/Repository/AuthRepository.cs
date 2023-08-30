using Marlabs_TokenAuthentication.Models;
using System.Linq;

namespace Marlabs_TokenAuthentication.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MarlabsTokenAuthenticationContext _context;
        public AuthRepository(MarlabsTokenAuthenticationContext context)
        {
            _context = context;
        }

        public TblUser Login(string email)
        {
            var user = _context.TblUsers.FirstOrDefault(x => x.Email == email);
            if (user == null)
                return null;

            return user;//auth success
        }

        public TblUser Register(TblUser user)
        {
            _context.TblUsers.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
