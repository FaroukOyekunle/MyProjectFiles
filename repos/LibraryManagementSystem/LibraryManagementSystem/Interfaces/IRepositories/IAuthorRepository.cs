using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IRepositories
{
   public interface IAuthorRepository : IRepository<Author>
   {
     Task<Author> GetByAuthorNameAsync(string firstName);
     Task<IEnumerable<Author>> GetSelectedAuthors(IList<int> ids);
   }
}
