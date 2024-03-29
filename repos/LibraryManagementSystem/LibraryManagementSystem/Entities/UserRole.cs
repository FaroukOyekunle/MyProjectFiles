﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class UserRole: BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
