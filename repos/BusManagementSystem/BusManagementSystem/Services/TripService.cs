using BusManagementSystem.DTOS;
using BusManagementSystem.Interfaces.Services;
using BusManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Services
{
  public  class TripService: ITripSevice
  {
        private readonly TripRepository _tripRepository;
        public TripService()
        {
            _tripRepository = new TripRepository();
        }

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus)
        {
            throw new NotImplementedException();
        }

        public bool ChangeTripStatus(string regNumber, bool tripStatus)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string regNumber)
        {
            throw new NotImplementedException();
        }

        public TripDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TripDto GetByRegNumber(string RegNumber)
        {
            throw new NotImplementedException();
        }

        public IList<TripDto> List()
        {
            throw new NotImplementedException();
        }

        public bool Register(CreateTripRequestModel model)
        {
            throw new NotImplementedException();
        }

        public bool Update(string regNumber, RescheduleTripRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
