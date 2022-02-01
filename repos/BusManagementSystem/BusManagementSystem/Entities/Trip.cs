using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Entities
{
  public  class Trip
  {
        public int Id { get; set; }

        public int BusId { get; set; }

        public Bus Bus { get; set; }

        public Location TakeOffPoint { get; set; }

        public Location LandingPoint { get; set; }

        public DateTime TakeOffTime { get; set; }

        public DateTime LandingTime { get; set; }

        public int DriverId { get; set; }

        public User Driver { get; set; }

        public decimal PricePerTrip { get; set; }


  }
}
