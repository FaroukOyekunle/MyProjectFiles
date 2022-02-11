using System.Collections.Generic;
using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.DTOs;

namespace ChatRoomBackEnd.Interfaces.Services
{
    public interface IChatService
    {
        Task<BaseResponse<List<ChatDto>>> GetAllChats();
        Task<BaseResponse<ChatDto>> GetChatById(int id);
        Task<BaseResponse<ChatDto>> CreateChat(CreateChatDto chat);
        Task<BaseResponse<ChatDto>> UpdateChat(ChatDto chat);
    }
}