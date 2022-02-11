using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.DTOs;

namespace ChatRoomBackEnd.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> GetUserByUserName(string userName);
        
        Task<BaseResponse<UserDto>> RegisterUser(UserDto model);
        Task<BaseResponse<LoginUserResponseDto>> Login(UserDto model);
        
    }
}