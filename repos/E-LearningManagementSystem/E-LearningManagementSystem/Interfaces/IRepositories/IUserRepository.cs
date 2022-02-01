using E_LearningManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Interfaces.IRepository
{
    public interface IUserRepository
    {
        public User AddUser(User user);

        public User UpdateUser(int id);

        public User GetUserById(int id);

        public User GetUserByEmail(string email);

        public void DeleteUser(int id);

        public IList<User> GetAllUsers();
    }
}
