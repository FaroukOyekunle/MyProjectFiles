using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IRepositories
{
   public  interface ICategoryRepository : IRepository<Category>
   {
        Task<IEnumerable<Category>> GetSelectedCategories(IList<int> ids);
   }
}
