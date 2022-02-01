using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Entities
{
   public class Passenger : User
   {
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
        public int PassengerId { get; internal set; }
        public string RegistrationNumber { get; internal set; }
    }
}
