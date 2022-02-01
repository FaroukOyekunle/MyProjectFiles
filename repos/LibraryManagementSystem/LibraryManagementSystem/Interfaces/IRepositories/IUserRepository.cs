using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IRepositories
{
  public  interface IUserRepository: IRepository<User>
  {
    public Task<IEnumerable<Role>> GetSelectedRoles(IList<int> ids);
  }
}
