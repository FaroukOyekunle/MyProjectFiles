using OFBusTransportationManagementSystem.Context;
using OFBusTransportationManagementSystem.DTOS;
using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OfBusTransportationManagementSystemDbContext _context;

        public UserRepository()
        {
            _context = new OfBusTransportationManagementSystemDbContext();
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User Get(int id)
        {
            var user = _context.Users.Find(id);
            return user;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public bool GetUserByPassword(string password)
        {
            return _context.Admins.Any(b => b.Password == password);
        }
        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
        public void Delete(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }
        public bool ExistById(int id)
        {
            return _context.Users.Any(b => b.UserId == id);
        }
       
        public List<User> GetAllDrivers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetAllPassengers()
        {
            return _context.Users.ToList();
        }

        User IUserRepository.Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public bool ExistByUsername(string username)
        {
            return _context.Users.Any(b => b.FirstName == username);
        }

        public User GetByUsername(string username)
        {
            return _context.Users.(b => b.FirstName == username);
        }
    }
}
