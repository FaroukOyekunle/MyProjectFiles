using JWTTest.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTest.Services.Interface
{
    public interface IUserService
    {

        public BaseResponse<UserDTO> Register(RegisterUserDTO model);

        public BaseResponse<UserDTO> Login(LoginUserDTO model);

        public BaseResponse<List<UserDTO>> GetUsers();
    }
}
