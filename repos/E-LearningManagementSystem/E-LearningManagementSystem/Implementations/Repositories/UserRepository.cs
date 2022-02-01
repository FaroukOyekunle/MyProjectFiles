using E_LearningManagementSystem.Context.ApplicationContext;
using E_LearningManagementSystem.Entities;
using E_LearningManagementSystem.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Implementations.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly LibraryContext _libraryContext;
        public UserRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public User AddUser(User user)
        {
            _libraryContext.Users.Add(user);
            _libraryContext.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            var user = GetUserById(id);
            _libraryContext.Users.Remove(user);
            _libraryContext.SaveChanges();
        }

        public IList<User> GetAllUsers()
        {
            return _libraryContext.Users.ToList();
        }

        public User GetUserByEmail(string email)
        {
            return _libraryContext.Users.FirstOrDefault(u => u.Email == email);
        }

        public User GetUserById(int id)
        {
            return _libraryContext.Users.SingleOrDefault(u => u.Id == id);
        }

        public User UpdateUser(int id)
        {
            var user = GetUserById(id);
            _libraryContext.Users.Update(user);
            _libraryContext.SaveChanges();
            return user;
        }
    }
}

