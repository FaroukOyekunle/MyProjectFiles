using System.Threading.Tasks;
using ChatRoomBackEnd.DTOs;
using ChatRoomBackEnd.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatRoomBackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatsController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatsController(IChatService chatService)
        {
            _chatService = chatService;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var chats = await _chatService.GetAllChats();
            return Ok(chats);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var response = await _chatService.GetChatById(id);

            if(response.IsSuccess) return Ok(response);
            
            return BadRequest(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateChatDto chat)
        {
            var response = await _chatService.CreateChat(chat);

            if(response.IsSuccess) return Ok(response);
            
            return BadRequest(response);
        }
        
    }
}