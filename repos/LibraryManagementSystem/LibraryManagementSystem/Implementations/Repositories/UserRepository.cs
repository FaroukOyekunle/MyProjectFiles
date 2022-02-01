using LibraryManagementSystem.Context;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Implementations.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(LMSApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetSelectedRoles(IList<int> ids)
        {
            return await _context.Roles
                .Where(c => ids.Contains(c.Id)).ToListAsync();
        }
    }
}

