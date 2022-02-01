using OFBusTransportationManagementSystem.Context;
using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Implementations.Repositories
{
   public class AdminRepository : IAdminRepository
   {
        private readonly OfBusTransportationManagementSystemDbContext _context;

        public AdminRepository()
        {
            _context = new OfBusTransportationManagementSystemDbContext();
        }
        public Admin Create(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }
        public Admin Get(int id)
        {
            var admin = _context.Admins.Find(id);
            return admin;
        }
        public List<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }
        public bool GetAdminByPassword(string password)
        {
            return _context.Admins.Any(b => b.Password == password);
        }
        public Admin Update(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return admin;
        }
        public void Delete(Admin admin)
        {
            _context.Remove(admin);
            _context.SaveChanges();
        }
        public bool ExistById(int id)
        {
            return _context.Admins.Any(b => b.AdminId == id);
        }
        public bool ExistByPassword(string password)
        {
            return _context.Admins.Any(b => b.Password == password);
        }
   }
}
