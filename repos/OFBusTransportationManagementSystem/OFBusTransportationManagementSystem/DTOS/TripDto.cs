using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.DTOS
{
   public class TripDto
   {
        public int Id { get; set; }

        public LocationType TakeOffPoint { get; set; }

        public LocationType LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public decimal Price { get; set; }

        public string TripReferenceNumber { get; set; }

        public TripStatus tripStatusType { get; set; }

        public string TripReference { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public int AvailableSeat { get; set; }

        public string BusModel { get; set; }

        public int BusId { get; set; }

        public string BusRegistrationNumber { get; set; }

        public string DriverFullName { get; set; }

        public virtual List<BookingDto> Bookings { get; set; } = new List<BookingDto>();
    }
    public class CreateTripRequestModel
    {
        public LocationType TakeOffPoint { get; set; }

        public LocationType LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public decimal Price { get; set; }

        public TripStatus tripStatusType { get; set; }

        public int DriverId { get; set; }
        
        public int BusId { get; set; }
    }
    public class UpdateTripRequestModel
    {
        public int BusId { get; set; }

        public LocationType TakeOffPoint { get; set; }

        public LocationType LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public decimal Price { get; set; }
    }
}
