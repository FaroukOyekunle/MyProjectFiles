using OFBusTransportationManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Interfaces.Repositories
{
    interface IBusRepository
    {
        Bus Create(Bus bus);

        Bus Get(int id);

        List<Bus> GetAll();

        Bus GetByRegistrationNumber(string registrationNumber);

        List<Bus> GetAvailableBuses();

        Bus Update(Bus bus);

        void Delete(Bus bus);

        bool ExistById(int id);

        bool ExistByRegNumber(string regNum);
    }
}
