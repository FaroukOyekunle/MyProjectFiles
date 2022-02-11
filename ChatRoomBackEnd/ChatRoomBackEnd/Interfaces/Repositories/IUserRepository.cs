using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;

namespace ChatRoomBackEnd.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserNameAsync(string userName);
        
        Task<User> CreateUserAsync(User user);
        
        Task<User> UpdateUserAsync(User user);

        Task<User> GetUserByUserNameAndPasswordAsync(string userName, string password);
    }
}