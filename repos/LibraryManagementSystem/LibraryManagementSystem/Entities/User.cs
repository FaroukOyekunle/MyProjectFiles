using LibraryManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string University { get; set; }
        public string LibraryIdentificationNumber { get; set; }
        public string LibrarianIdentificationNumber { get; set; }
        public AccountStatus Status { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public GenderType GenderType { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
