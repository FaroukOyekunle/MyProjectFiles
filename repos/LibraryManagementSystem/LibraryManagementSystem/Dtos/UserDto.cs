using LibraryManagementSystem.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
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
        public IEnumerable<RoleDto> Roles { get; set; } = new List<RoleDto>();
    }
}