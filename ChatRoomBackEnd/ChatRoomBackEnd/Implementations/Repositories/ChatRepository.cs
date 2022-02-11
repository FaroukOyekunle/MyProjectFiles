using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatRoomBackEnd.Data;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ChatRoomBackEnd.Implementations.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly ChatRoomDBContext _context;

        public ChatRepository(ChatRoomDBContext context)
        {
            _context = context;
        }

       

        public async Task<IEnumerable<Chat>> GetChats()
        {
            return await _context.Chats
                .OrderBy(c => c.CreatedAt)
                .ToListAsync();
        }

        public async Task<Chat> AddChat(Chat chat)
        {
            await _context.Chats.AddAsync(chat);
            await _context.SaveChangesAsync();
            return chat;
        }

        public async Task<Chat> UpdateChat(Chat chat)
        {
            _context.Chats.Update(chat);
            await _context.SaveChangesAsync();
            return chat;
        }

       

       
    }
}