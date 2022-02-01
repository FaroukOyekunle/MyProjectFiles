using E_LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Interfaces.IServices
{
    public interface IUserService
    {
        public User GetUser(int id);

        public User GetUserByEmail(string email);

        public User RegisterUser(User user);

        public User Login(string email, string password);

        public IList<User> GetAllUsers();

        public void DeleteUser(int id);
    }
}
