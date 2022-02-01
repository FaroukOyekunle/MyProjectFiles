using OFBusTransportationManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Interfaces.Repositories
{
    interface IAdminRepository
    {
        Admin Create(Admin admin);
        Admin Get(int id);
        List<Admin> GetAll();
        bool GetAdminByPassword(string password);
        Admin Update(Admin admin);
        void Delete(Admin admin);
        bool ExistById(int id);
        bool ExistByPassword(string password);
    }
}
