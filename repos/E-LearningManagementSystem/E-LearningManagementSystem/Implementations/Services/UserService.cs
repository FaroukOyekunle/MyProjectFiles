using E_LearningManagementSystem.Entities;
using E_LearningManagementSystem.Interfaces.IRepository;
using E_LearningManagementSystem.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Implementations.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public User RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
