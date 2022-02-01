using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
  public  interface ITripRepositories
  {
        TripDto Create(Trip trip);

        TripDto Get(int id);

        List<Trip> GetAll();

        List<Trip> GetAvailableBuses();

        TripDto Update(Trip trip);

        void Delete(Trip trip);

        bool ExistById(int id);

        bool ExistByRegNumber(string regNum);

    }
}
