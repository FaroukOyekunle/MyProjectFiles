using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTest.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }

    public class LoginResponseDto : UserDTO
    {
        public string Token { get; set; }
    }

    public class RegisterUserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }

    public class LoginUserDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
