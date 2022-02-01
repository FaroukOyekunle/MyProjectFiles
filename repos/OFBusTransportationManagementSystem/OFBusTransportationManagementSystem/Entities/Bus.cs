using OFBusTransportationManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Entities
{
   public class Bus
   {
        public int BusId { get; set; }

        public string BusModel { get; set; }

        public BusType BusType { get; set; }

        public string RegistrationNumber { get; set; }

        public string PlateNumber { get; set; }

        public int Capacity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public bool TripStatus { get; set; }

        public virtual List<Trip> Trips { get; set; } = new List<Trip>();
        public string Model { get; internal set; }

        public override string ToString()
        {
            return $"{BusModel} , {PlateNumber} , {Capacity}";
        }
   }
}
