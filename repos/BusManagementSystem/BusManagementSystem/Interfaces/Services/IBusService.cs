using BusManagementSystem.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Services
{
   public interface IBusService
   {

        public bool Register(CreateBusRequestModel model);

        public bool Update(string regNumber, UpdateBusRequestModel model);

        public bool ChangeTripStatus(string regNumber, bool tripStatus);

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus);

        public bool Delete(string regNumber);

        public IList<BusDto> List();

        public BusDto GetById(int id);

        public BusDto GetByRegNumber(string RegNumber);

    }
}
