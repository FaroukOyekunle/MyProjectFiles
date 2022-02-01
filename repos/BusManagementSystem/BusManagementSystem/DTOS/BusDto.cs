using BusManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.DTOS
{
    public class BusDto
    {
        public int Id { get; set; }

        public string BusModel { get; set; }

        public BusType BusType { get; set; }

        public string RegistrationNumber { get; set; }

        public string PlateNumber { get; set; }

        public int BusCapacity { get; set; }

        public bool AvailabilityStatus { get; set; }

        public bool TripStatus { get; set; }


        public override string ToString()
        {
            return $"{RegistrationNumber} , {AvailabilityStatus} , {TripStatus} , {BusCapacity}";
        }

    }

    public class CreateBusRequestModel
   {
        public string BusModel { get; set; }

        public BusType BusType { get; set; }

        public string PlateNumber { get; set; }

        public string RegistrationNumber { get; set; }

        public int BusCapacity { get; set; }


    }

    public  class UpdateBusRequestModel
  {
        public BusType BusType { get; set; }

        public string PlateNumber { get; set; }
  }
}
