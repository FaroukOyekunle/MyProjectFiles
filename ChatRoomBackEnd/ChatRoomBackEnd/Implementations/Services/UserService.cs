using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.DTOs;
using ChatRoomBackEnd.Interfaces.Repositories;
using ChatRoomBackEnd.Interfaces.Services;

namespace ChatRoomBackEnd.Implementations.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            var user = await _userRepository.GetUserByUserNameAsync(userName);

            return user;
        }

        public async Task<BaseResponse<UserDto>> RegisterUser(UserDto model)
        {
            var user = await _userRepository.GetUserByUserNameAsync(model.Username);
            
            if (user != null)
            {
                return new BaseResponse<UserDto>
                {
                    IsSuccess = false,
                    Message = "User already exists"
                };
            }
            
            var newUser = new User
            {
                UserName = model.Username,
                Password = model.Password
            };
            
            await _userRepository.CreateUserAsync(newUser);
            
            return new BaseResponse<UserDto>
            {
                IsSuccess = true,
                Data = model,
                Message = "User created successfully"
            };
            
        }

        public async Task<BaseResponse<LoginUserResponseDto>> Login(UserDto model)
        {
            var user = await _userRepository.GetUserByUserNameAndPasswordAsync(model.Username, model.Password);


            if (user == null)
            {
                return new BaseResponse<LoginUserResponseDto>
                {
                    IsSuccess = false,
                    Message = "Invalid username or password"
                };
            }

            return new BaseResponse<LoginUserResponseDto>()
            {
                IsSuccess = true,
                Data = new LoginUserResponseDto()
                {
                    Username = user.UserName
                },
                Message = "Login Successful"
            };
        }
    }
}