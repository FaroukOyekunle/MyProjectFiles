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
    public class PassengerRepository : IPassengerRepository
    {
        private readonly OfBusTransportationManagementSystemDbContext _context;

        public PassengerRepository()
        {
            _context = new OfBusTransportationManagementSystemDbContext();
        }

        public Passenger Create(Passenger passenger)
        {
            _context.Passengers.Add(passenger);
            _context.SaveChanges();
            return passenger;
        }

        public void Delete(Passenger passenger)
        {
            _context.Passengers.Remove(passenger);
            _context.SaveChanges();
        }

        public bool ExistById(int id)
        {
            return _context.Passengers.Any(b => b.PassengerId == id);
        }

        public bool ExistByPassword(string password)
        {
            return _context.Passengers.Any(b => b.Password == password);
        }

        public List<Passenger> GetAll()
        {
            return _context.Passengers.ToList();
        }

        public Passenger Get(int id)
        {
            var passenger = _context.Passengers.Find(id);
            return passenger;
        }

        public Passenger Update(Passenger passenger)
        {
            _context.Passengers.Update(passenger);
            _context.SaveChanges();
            return passenger;
        }
    }

}
