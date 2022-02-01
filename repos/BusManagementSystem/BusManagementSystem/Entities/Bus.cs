using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Entities
{
   public class Bus
   {
        public int Id { get; set; }

        public string BusModel { get; set; }

        public BusType BusType { get; set; }

        public string RegistrationNumber { get; set; }

        public string PlateNumber { get; set; }

        public int BusCapacity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public bool TripStatus { get; set; }

        public virtual List<Trip> Trips { get; set; } = new List<Trip>();


   }
}
