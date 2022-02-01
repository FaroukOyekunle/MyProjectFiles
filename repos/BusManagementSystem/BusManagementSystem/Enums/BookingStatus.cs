using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Enums
{
    public enum BookingStatus
    {
        Acive = 1,
        InActive, 
        Cancel,
        Rescheduled,
        MissedTrip,
        OnBoard
    }
}
