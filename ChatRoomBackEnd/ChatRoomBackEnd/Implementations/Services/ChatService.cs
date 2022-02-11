using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatRoomBackEnd.Data.Entities;
using ChatRoomBackEnd.DTOs;
using ChatRoomBackEnd.Interfaces.Repositories;
using ChatRoomBackEnd.Interfaces.Services;

namespace ChatRoomBackEnd.Implementations.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;
        private readonly IUserRepository _userRepository;

        public ChatService(IChatRepository chatRepository, IUserRepository userRepository)
        {
            _chatRepository = chatRepository;
            _userRepository = userRepository;
        }
        
        public async Task<BaseResponse<List<ChatDto>>> GetAllChats()
        {
            var chats = await _chatRepository.GetChats();
            
            return new BaseResponse<List<ChatDto>>
            {
                IsSuccess = true,
                Message = "Chats retrieved successfully",
                Data = chats.Select(c => new ChatDto()
                {
                    Id = c.Id,
                    UserName = c.UserName,
                    Message = c.Message,
                    DateSent = c.CreatedAt
                }).ToList()
            };
            
        }

        public async Task<BaseResponse<ChatDto>> GetChatById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BaseResponse<ChatDto>> CreateChat(CreateChatDto model)
        {
            
            var user = await _userRepository.GetUserByUserNameAsync(model.UserName);
            
            if (user == null)
            {
                return new BaseResponse<ChatDto>
                {
                    IsSuccess = false,
                    Message = "User does not exist"
                };
            }
            
            var chat = new Chat
            {
                Message = model.Message,
                UserName = model.UserName,
                CreatedAt = DateTime.Now
            };
            
            user.Chats.Add(chat);
            await _userRepository.UpdateUserAsync(user);


            var result = user.Chats.LastOrDefault(); 
            

            return new BaseResponse<ChatDto>()
            { 
                IsSuccess = true,
                Message = "Chat created successfully",
                Data = new ChatDto()
                {
                    Id = result.Id,
                    UserName = result.UserName,
                    Message = model.Message,
                    DateSent = result.CreatedAt
                }
            };
        }

        public async Task<BaseResponse<ChatDto>> UpdateChat(ChatDto chat)
        {
            throw new System.NotImplementedException();
        }
    }
}