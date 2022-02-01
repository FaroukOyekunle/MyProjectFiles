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
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(LMSApplicationContext context)
        {
            _context = context;
        }
        public Task<Author> GetByAuthorNameAsync(string firstName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Author>> GetSelectedAuthors(IList<int> ids)
        {
            return await _context.Authors
                .Where(c => ids.Contains(c.Id)).ToListAsync();
        }
    }
}
