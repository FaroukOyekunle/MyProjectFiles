using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.DTOS
{
    public class BookingDto
    {
        public int Id { get; set; }

        public string BookingReference { get; set; }

        public int NumberOfPassenger { get; set; }

        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public int TripId { get; set; }

        public Trip Trip { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public bool IsPaid { get; set; }

    }
}
