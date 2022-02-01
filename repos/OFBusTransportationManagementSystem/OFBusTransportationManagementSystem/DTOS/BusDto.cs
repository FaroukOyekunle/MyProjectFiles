using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.DTOS
{
  public  class BusDto
  {
        public int Id { get; set; }

        public string Model { get; set; }

        public BusType BusType { get; set; }

        public string RegistrationNumber { get; set; }

        public string PlateNumber { get; set; }

        public int Capacity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public bool TripStatus { get; set; }

        public List<Trip> Trips { get; set; } = new List<Trip>();

        public override string ToString()
        {
            return $"{Model} , {PlateNumber} , {Capacity}";
        }
  }
  
    public class CreateBusRequestModel
    {
        public string Model { get; set; }

        public BusType BusType { get; set; }

        public string PlateNumber { get; set; }

        public int Capacity { get; set; }

        public UserType userType { get; set; }
    }
    public class UpdateBusRequestModel
    {
        public BusType BusType { get; set; }

        public string PlateNumber { get; set; }
    }
}
