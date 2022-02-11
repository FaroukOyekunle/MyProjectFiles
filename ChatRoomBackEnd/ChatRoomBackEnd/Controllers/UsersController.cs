using System.Threading.Tasks;
using ChatRoomBackEnd.DTOs;
using ChatRoomBackEnd.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatRoomBackEnd.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
    
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserDto model)
        {
            var result = await _userService.RegisterUser(model);
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto model)
        {
            var result = await _userService.Login(model);
            if (result.IsSuccess) return Ok(result);
            return BadRequest(result);
        }
        
    }
}