using System.Linq;
using System.Threading.Tasks;
using ChatRoomBackEnd.Data;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ChatRoomBackEnd.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ChatRoomDBContext _context;

        public UserRepository(ChatRoomDBContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            var user = await _context.Users
                .Include(u => u.Chats)
                .FirstOrDefaultAsync(u => u.UserName.ToLower() == userName.ToLower());

            return user;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserByUserNameAndPasswordAsync(string userName, string password)
        {
            var user = await _context.Users
                .Include(u => u.Chats)
                .FirstOrDefaultAsync(u => u.UserName.ToLower() == userName.ToLower() && u.Password == password);

            return user;
        }
    }
}