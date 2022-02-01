using OFBusTransportationManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Interfaces.Repositories
{
    interface IPassengerRepository
    {
        Passenger Create(Passenger passenger);
        void Delete(Passenger passenger);
        bool ExistById(int id);
        bool ExistByPassword(string password);
        List<Passenger> GetAll();
        Passenger Get(int id);
        Passenger Update(Passenger passenger);
    }
}
