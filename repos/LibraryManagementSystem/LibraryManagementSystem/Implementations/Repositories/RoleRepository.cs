using LibraryManagementSystem.Context;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Implementations.Repositories
{
    public class RoleRepository: BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(LMSApplicationContext context)
        {
            _context = context;
        }
    }
}
