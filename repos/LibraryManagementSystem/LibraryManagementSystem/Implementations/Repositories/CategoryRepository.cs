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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(LMSApplicationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetSelectedCategories(IList<int> ids)
        {
            return await _context.Categories
                .Where(c => ids.Contains(c.Id)).ToListAsync();
        }
    }
}
