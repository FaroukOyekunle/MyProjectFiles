using OFBusTransportationManagementSystem.Implementations.Repositories;
using OFBusTransportationManagementSystem.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.Implementations.Services
{
   public class AdminService : IAdminService
   {
        private readonly AdminRepository _adminRepository;

        public AdminService()
        {
            _adminRepository = new AdminRepository();
        }

    }
}
