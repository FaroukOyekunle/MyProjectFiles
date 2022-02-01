using BusManagementSystem.Context;
using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using BusManagementSystem.Interfaces;
using BusManagementSystem.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Repositories
{
   public class TripRepository: ITripRepositories
   {
        private readonly BusManagementSystemDbContext _context;
        public TripRepository()
        {
            _context = new BusManagementSystemDbContext();
        }

        public void CancelTrip(Trip trip)
        {
          
            {
                _context.TripsDto.AddRange(trip);
                _context.SaveChanges();
            }
        }

        public TripDto Create(Trip trip)
        {
            throw new NotImplementedException();
        }

        public List<Trip> CreateTrip(List<Trip> trip)
        {
            _context.TripsDto.AddRange(trip);
            _context.SaveChanges();
            return trip;
        }

        public void Delete(Trip trip)
        {
            throw new NotImplementedException();
        }

        public bool ExistById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistByRegNumber(string regNum)
        {
            throw new NotImplementedException();
        }

        public TripDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAvailableBuses()
        {
            throw new NotImplementedException();
        }

        public List<Trip> GetAvailableTrips()
        {
            throw new NotImplementedException();
        }

        public TripDto GetByRegistrationNumber(string registrationNumber)
        {
            throw new NotImplementedException();
        }

        public Trip GetTrip(int Id)
        {
            throw new NotImplementedException();
        }

        public Trip UpdatAndReschuduleTrip(Trip trip)
        {
            throw new NotImplementedException();
        }

        public TripDto Update(Trip trip)
        {
            throw new NotImplementedException();
        }
    }
}
