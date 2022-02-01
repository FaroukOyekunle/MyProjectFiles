using OFBusTransportationManagementSystem.DTOS;
using OFBusTransportationManagementSystem.Entities;
using OFBusTransportationManagementSystem.Exceptions;
using OFBusTransportationManagementSystem.Implementations.Repositories;
using OFBusTransportationManagementSystem.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Implementations.Services
{
    public class BusService : IBusService
    {
        private readonly BusRepository _busRepository;

        public BusService()
        {
            _busRepository = new BusRepository();
        }

        public bool ChangeAvailabilityStatus(string regNumber, bool availabilityStatus)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if (bus == null)
            {
                throw new NotFoundException($"Bus with Registration Number {regNumber} does not exist");
            }
            bus.AvailabilityStatus = availabilityStatus;
            _busRepository.Update(bus);
            return true;

        }

        public bool ChangeTripStatus(string regNumber, bool tripStatus)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if (bus == null)
            {
                throw new NotFoundException($" the bus  with registrationnumber{regNumber} does not exits");

            }
            bus.TripStatus = tripStatus;
            _busRepository.Update(bus);
            return true;
        }

        public bool Delete(string regNumber)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if (bus == null)
            {
                throw new NotFoundException($"The registration entered{regNumber} does not exist");
            }
            _busRepository.Delete(bus);
            return true;
        }

        public BusDto GetById(int id)
        {
            var bus = _busRepository.Get(id);
            if (bus != null)
            {
                return new BusDto
                {
                    AvailabilityStatus = bus.AvailabilityStatus,
                    BusType = bus.BusType,
                    Capacity = bus.Capacity,
                    Model = bus.Model,
                    PlateNumber = bus.PlateNumber,
                    RegistrationNumber = bus.RegistrationNumber,
                    TripStatus = bus.TripStatus,
                };
            };
            return null;

        }

        public BusDto GetByRegNumber(string RegNumber)
        {
            var bus = _busRepository.GetByRegistrationNumber(RegNumber);
            if (bus == null)
            {
                throw new NotFoundException($"Bus with {RegNumber} not found");
            }
            BusDto busDto = new BusDto
            {
                AvailabilityStatus = bus.AvailabilityStatus,
                BusType = bus.BusType,
                Capacity = bus.Capacity,
                Model = bus.Model,
                PlateNumber = bus.PlateNumber,
                TripStatus = bus.TripStatus,
                Id = bus.BusId,
                RegistrationNumber = bus.RegistrationNumber

            };
            return busDto;
        }

        public IList<BusDto> List()
        {
            var buses = _busRepository.GetAll().Select(bus => new BusDto
            {
                AvailabilityStatus = bus.AvailabilityStatus,
                BusType = bus.BusType,
                Capacity = bus.Capacity,
                Model = bus.Model,
                PlateNumber = bus.PlateNumber,
                TripStatus = bus.TripStatus,
                Id = bus.BusId,
                RegistrationNumber = bus.RegistrationNumber
            }).ToList();
            return buses;
        }

        public bool Register(CreateBusRequestModel model)
        {
            var bus = new Bus
            {
                AvailabilityStatus = true,
                Capacity = model.Capacity,
                BusType = model.BusType,
                Model = model.Model,
                PlateNumber = model.PlateNumber,
                TripStatus = false,
                RegistrationNumber = Guid.NewGuid().ToString().Substring(0, 11).Replace("-", "").ToUpper(),
            };
            _busRepository.Create(bus);
            return true;
        }

        public bool Update(string regNumber, UpdateBusRequestModel model)
        {
            var bus = _busRepository.GetByRegistrationNumber(regNumber);
            if (bus == null)
            {
                throw new NotFoundException($"Bus with Registration Number {regNumber} does not exist");
            }
            bus.BusType = model.BusType;
            bus.PlateNumber = model.PlateNumber;
            _busRepository.Update(bus);
            return true;
        }
    }
}
