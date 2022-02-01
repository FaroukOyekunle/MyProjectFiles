using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Enums
{
    public enum BookAvailabilityStatus
    {
        AVAILABLE = 1,
        RESERVED,
        LOANED,
        LOST
    }
}
