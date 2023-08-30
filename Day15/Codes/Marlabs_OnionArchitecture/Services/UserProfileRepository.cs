using Domain.Models;
using Infrastructure.Repository;

namespace Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IGenericRepository<UserProfile> userProfileRepository;

        public UserProfileRepository(IGenericRepository<UserProfile> _userProfileRepository)
        {
            this.userProfileRepository = _userProfileRepository;
        }
        public UserProfile GetUserProfile(long Id)
        {
            return userProfileRepository.GetT(Id);
        }
    }
}
