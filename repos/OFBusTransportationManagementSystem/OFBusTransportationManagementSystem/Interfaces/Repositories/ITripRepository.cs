using OFBusTransportationManagementSystem.DTOS;
using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Interfaces.Repositories
{
    interface ITripRepository
    {
        Trip Create(Trip trip);

        Trip Get(int id);

        Trip GetByReference(string reference);

        List<Trip> GetAll();

        Trip Update(Trip trip);

        void DeleteTripReferenceNumber(string ReferenceNumber);

        bool ExistById(int id);

        public List<TripDto> GetTripsByDateAndLocation(LocationType from, LocationType to, DateTime date);

        public List<TripDto> GetAvailableTrips(LocationType from, LocationType to, DateTime date);

        public List<TripDto> GetTripsByDriver(int driverId);

        public List<TripDto> GetInitialisedTrips();
        public List<TripDto> GetTripsByBus(string registrationNumber);

        public List<TripDto> GetTripsByDate(DateTime date);

        public List<TripDto> GetCompletedTrips();

    }
}
