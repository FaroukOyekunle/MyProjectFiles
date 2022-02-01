using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Enums;

namespace OFBusTransportationManagementSystem.Entities
{
   public class Trip
   {
        public int Id { get; set; }

        public string TripReference { get; set; }

        public int BusId { get; set; }

        public Bus Bus { get; set; }

        public LocationType TakeOffPoint { get; set; }

        public LocationType LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public decimal Price { get; set; }

        public TripStatus tripStatusType { get; set; }

        public string TripReferenceNumber { get; set; }

        public int AvailableSeat { get; set; }

        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
        public object Status { get; internal set; }

        public object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
   }
}
