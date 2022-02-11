using System.Collections.Generic;
using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;

namespace ChatRoomBackEnd.Interfaces.Repositories
{
    public interface IChatRepository
    {
        Task<IEnumerable<Chat>> GetChats();
        Task<Chat> AddChat(Chat chat);
        Task<Chat> UpdateChat(Chat chat);
    }
}