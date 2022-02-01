using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
    interface IBusRepositories
    {

            BusDto Create(Bus bus);

            BusDto Get(int id);

            List<Bus> GetAll();

            BusDto GetByRegistrationNumber(string registrationNumber);

            List<Bus> GetAvailableBuses();

            BusDto Update(Bus bus);

            void Delete(Bus bus);

            bool ExistById(int id);

            bool ExistByRegNumber(string regNum);
        
    }
}
