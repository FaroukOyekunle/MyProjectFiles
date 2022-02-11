using JWTTest.Auth;
using JWTTest.DTOs;
using JWTTest.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JWTTest.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;

        public UserController(IUserService userService, IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _userService = userService;
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterUserDTO model)
        {

            var response = _userService.Register(model);

            if (response.Success) return Ok(response);

            return BadRequest(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUserDTO model)
        {

            var response = _userService.Login(model);

            if (!response.Success) return BadRequest(response);

            var token = _jwtAuthenticationManager.GenerateToken(response.Data);

            var user = response.Data;

            var r = new LoginResponseDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Token = token
            };

            return Ok(r);
        }

        [HttpGet("users")]
        [Authorize]
        public IActionResult GetUsers()
        {
            Console.Write("User Request By" + User.FindFirst(ClaimTypes.NameIdentifier).Value);
            return Ok(_userService.GetUsers());
        }
    }
}
