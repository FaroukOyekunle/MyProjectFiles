using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces.Identity;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly IIdentityService _identityService;
        private readonly IConfiguration _configuration;
        // private readonly IMailSender _mailSender;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IUserService userService, IIdentityService identityService, IConfiguration configuration, UserManager<User> userManager, ILogger<AuthController> logger)
        {
            _userService = userService;
            _userManager = userManager;
            _identityService = identityService;
            _configuration = configuration;
            _logger = logger;
            //_mailSender = mailSender;
        }

        //   [Authorize(Roles = "")]
        [HttpPost("register")]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        //[ProducesResponseType((int)HttpStatusCode.Unauthorized, Type = typeof(BaseResponse))]
        public async Task<IActionResult> Register([FromBody] CreateUserRequestModel model)
        {

            var response = await _userService.AddUser(model);
            return Ok(response);
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            var response = await _userService.GetUser(id);
            return Ok(response);
        }

        [HttpPost("token")]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(LoginResponseModel))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        public async Task<IActionResult> Token([FromBody] LoginRequestModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            //var user = await _userService.GetUserAsync(model.Email);
            if (user != null)
            {
                var isValidPassword = await _userManager.CheckPasswordAsync(user, $"{model.Password}{user.Email}");
                if (isValidPassword)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    var token = _identityService.GenerateToken(user, roles);
                    var tokenResponse = new LoginResponseModel
                    {
                        Message = "Login Successful",
                        Status = true,
                        Data = new LoginResponseData
                        {
                            Roles = roles,
                            Email = user.Email,
                            LibraryIdentificationNumber = user.LibraryIdentificationNumber,
                            LastName = user.LastName,
                            FirstName = user.FirstName,
                            UserId = user.Id
                        }
                    };
                    var expiry = DateTimeOffset.UtcNow.AddMinutes(Convert.ToInt32(_configuration.GetValue<string>("JwtTokenSettings:TokenExpiryPeriod")));
                    Response.Headers.Add("Token", token);
                    Response.Headers.Add("TokenExpiry", expiry.ToUnixTimeMilliseconds().ToString());
                    Response.Headers.Add("Access-Control-Expose-Headers", "Token,TokenExpiry");
                    return Ok(tokenResponse);
                }
            }
            var response = new BaseResponse
            {
                Message = "Invalid Credential",
                Status = false
            };
            return BadRequest(response);
        }


        /*[HttpPost("forgotpassword")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var baseResetLink = $"{_configuration.GetValue<string>("PasswordReset:BaseUrl")}/account/resetpassword";
                var passwordResetLink = $"{baseResetLink}?id={user.Id}&token={HttpUtility.UrlEncode(token)}";
                await _mailSender.SendForgotPasswordMail(user.Email, $"{user.FirstName} {user.LastName}", passwordResetLink);
                return Ok(new BaseResponse() { Status = true, Message = $"Reset password link has been sent to  {model.Email}" });
            }
            throw new NotFoundException($"The specified email {model.Email} is not recognized");
        }
        [HttpPost("resetpassword")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, model.Token, $"{model.Password + user.HashSalt}");
                var UserPassword = model.Password;
                if (result.Succeeded)
                {
                    await _mailSender.SendResetPasswordMail(user.Email, $"{user.FirstName} {user.LastName}", UserPassword);
                    return Ok(new BaseResponse() { Status = true, Message = $"Password successfully reset. Login with the new password sent to {user.Email}" });
                }
            }
            throw new NotFoundException("The user account does not exist");
        }
        [HttpPost("changepassword")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        public async Task<ActionResult> ChangePassword([FromBody] ChangePasswordViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            if (user != null)
            {
                var isValidPassword = await _userManager.CheckPasswordAsync(user, $"{model.CurrentPassword}{user.HashSalt}");
                if (isValidPassword)
                {
                    var result = await _userManager.ChangePasswordAsync(user, $"{model.CurrentPassword + user.HashSalt}", $"{model.NewPassword + user.HashSalt}");
                    var UserPassword = model.NewPassword;
                    if (result.Succeeded)
                    {
                        await _mailSender.SendChangePasswordMail(user.Email, $"{user.FirstName} {user.LastName}", UserPassword);
                        return Ok(new BaseResponse() { Status = true, Message = $"Password successfully changed. Login with the new password sent to {user.Email}" });
                    }
                    else
                    {
                        throw new NotFoundException("The new password is too weak. It should contain at least an upper case letter");
                    }
                }
                else
                {
                    throw new NotFoundException("The current password is invalid");
                }
            }
            throw new NotFoundException("The user account does not exist");
        }
        [HttpPost("verify")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        public async Task<IActionResult> VerifyEmail([FromBody] VerifyEmailViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, model.Token);
                if (result.Succeeded)
                {
                    await _mailSender.SendVerifyMail(user.Email, $"{user.FirstName} {user.LastName}");
                    return Ok(new BaseResponse() { Status = true, Message = "Email successfully verified." });
                }
            }
            throw new NotFoundException("The user account does not exist");
        }*/
    }
}
