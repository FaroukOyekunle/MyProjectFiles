using BusManagementSystem.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Services
{
    interface ITripSevice
    {
        public bool Register(CreateTripRequestModel model);

        public bool Update(string regNumber, RescheduleTripRequestModel model);

        public bool ChangeTripStatus(string regNumber, bool tripStatus);

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus);

        public bool Delete(string regNumber);

        public IList<TripDto> List();

        public TripDto GetById(int id);

        public TripDto GetByRegNumber(string RegNumber);

    }
}
