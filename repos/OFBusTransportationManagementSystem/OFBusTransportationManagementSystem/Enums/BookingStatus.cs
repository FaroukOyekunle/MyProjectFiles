using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Enums
{
   public enum BookingStatus
   {
        Active = 1,
        Inactive,
        Council,
        Rescheduled,
        Missed,
        Onboard
   }
}
