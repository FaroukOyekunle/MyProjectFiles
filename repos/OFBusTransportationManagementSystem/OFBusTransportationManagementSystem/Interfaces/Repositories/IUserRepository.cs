using OFBusTransportationManagementSystem.DTOS;
using OFBusTransportationManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User Create(User user);

        User Get(int id);

        List<User> GetAll();

        User GetByUsername(string username);

        List<User> GetAllDrivers();

        List<User> GetAllPassengers();

        User Update(User user);

        void Delete(User user);

        bool ExistById(int id);

        bool ExistByUsername(string username);
    }
}
