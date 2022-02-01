using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Entities
{
   public class Driver : User
   {
        public string LicenseNumber { get; set; }

        public virtual List<Trip> Trips { get; set; } = new List<Trip>();
   }
}
