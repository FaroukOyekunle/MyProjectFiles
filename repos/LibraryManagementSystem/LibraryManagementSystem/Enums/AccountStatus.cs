using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Enums
{
    public enum AccountStatus
    {
        ACTIVE = 1,
        CLOSED,
        CANCELED,
        BLACKLISTED,
        NONE
    }
}
