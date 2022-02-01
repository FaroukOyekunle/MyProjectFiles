using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFBusTransportationManagementSystem.DTOS
{
   public class PassengerDto
   {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        List<BookingDto> Bookings { get; set; }
   }
    public class CreatePassengerRequestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
    public class UpdatePassengerRequestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string LicenseNumber { get; set; }
    }
    public class LoginPassengerRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
