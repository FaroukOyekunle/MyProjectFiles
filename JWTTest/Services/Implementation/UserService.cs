using JWTTest.DTOs;
using JWTTest.Enitity;
using JWTTest.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTest.Services.Implementation
{
    public class UserService : IUserService
    {

        public static List<User> Users = new List<User>();

        public BaseResponse<List<UserDTO>> GetUsers()
        {
            return new BaseResponse<List<UserDTO>>
            {
                Success = true,
                Message = "User Retrieved",
                Data = Users.Select(user => new UserDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email

                }).ToList()
            };
        }

        public BaseResponse<UserDTO> Login(LoginUserDTO model)
        {
            var user = Users.FirstOrDefault(u => u.Email.Equals(model.Email, StringComparison.OrdinalIgnoreCase) && u.Password.Equals(model.Password));

            if (user == null) return new BaseResponse<UserDTO>
            {
                Message = "Invalid Email Or Password"
            };

            return new BaseResponse<UserDTO>
            {
                Success = true,
                Message = "Login Successful",
                Data = new UserDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email
                }
            };
        }

        public BaseResponse<UserDTO> Register(RegisterUserDTO model)
        {
            var isUserExist = Users.Exists(u => u.Email.Equals(model.Email, StringComparison.OrdinalIgnoreCase));

            if (isUserExist) return new BaseResponse<UserDTO>
            {
                Message = "User Already Exists"
            };

            User user = new User
            {
                Id = Users.Count == 0 ? 1 : Users.Last().Id + 1,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password
            };

            

            Users.Add(user);

            return new BaseResponse<UserDTO>
            {
                Success = true,
                Message = "User registered Successfully",
                Data = new UserDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email
                }
            };
        }
    }
}
