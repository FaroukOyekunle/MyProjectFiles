using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Entities
{
   public class Booking
   {
        public int Id { get; set; }

        public string BookingReference { get; set; }

        public int NumberOfPassenger { get; set; }

        public int CustomerId { get; set; }

        public User Customer { get; set; }

        public int TripId { get; set; }

        public Bus Bus { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public bool IsPaid { get; set; }


    }
}
