using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class CreateUserRequestModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string University { get; set; }

        //public string LibraryIdentificationNumber { get; set; }

        // public string LibrarianIdentificationNumber { get; set; }

        //public AccountStatus Status { get; set; }

        public string Password { get; set; }

        // public string HashSalt { get; set; }

        public UserType UserType { get; set; }
        public IList<int> Roles { get; set; } = new List<int>();
    }
    public class UpgradeLibraryUserRequestModel
    {
        public UserType UserType { get; set; }
    }

    public class UpdateUserStatusRequestModel
    {
        public AccountStatus Status { get; set; }
    }

    public class UserResponseModel : BaseResponse
    {
        public UserDto Data { get; set; }
    }

    public class UsersResponseModel : BaseResponse
    {
        public IEnumerable<UserDto> Data { get; set; } = new List<UserDto>();
    }

    public class LoginRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class LoginResponseModel : BaseResponse
    {
        public LoginResponseData Data { get; set; }
    }

    public class LoginResponseData
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LibraryIdentificationNumber { get; set; }

        public IEnumerable<string> Roles { get; set; } = new List<string>();

    }

    public class ChangeUserPasswordRequestModel
    {
        [Required]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Token { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public int Id { get; set; }

        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }


    public class VerifyEmailViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Token { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

