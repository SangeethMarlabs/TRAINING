using Domain.Models;
using Infrastructure.Repository;
using System.Collections.Generic;

namespace Services
{
    public class UserRepository : IUserRepository
    {
        IGenericRepository<User> userRepository;
        IGenericRepository<UserProfile> userProfileRepository;

        public UserRepository(IGenericRepository<User> _userRepository, IGenericRepository<UserProfile> _userProfileRepository)
        {
            this.userRepository = _userRepository;
            this.userProfileRepository = _userProfileRepository;
        }
        public void DeleteUser(long Id)
        {
            UserProfile userProfile = userProfileRepository.GetT(Id);
            userProfileRepository.Remove(userProfile);

            User user = GetUser(Id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        public User GetUser(long Id)
        {
            return userRepository.GetT(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }

        public void UpdatetUser(User user)
        {
            userRepository.Update(user);
        }
    }
}
