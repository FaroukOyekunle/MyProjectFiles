using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
    public class AccountController: ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login(string returnUrl)
        {
           // ViewBag.ReturnUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : string.Empty;
            return Ok();
        }

        public IActionResult Index()
        {
            return Ok();
        }

        public IActionResult Register(string returnUrl)
        {
          //  ViewBag.ReturnUrl = Url.IsLocalUrl(returnUrl) ? returnUrl : string.Empty;
            return Ok();
        }

        public IActionResult ForgotPassword()
        {

            return Ok();

        }
        public IActionResult ChangePassword()
        {
            return Ok();
        }

        public IActionResult ResetPassword()
        {
            return Ok();
        }

        public IActionResult VerifyEmail()
        {
            return Ok();
        }

        [HttpGet("records/{userId}")]
        public IActionResult ViewUsers(Guid userId)
        {
           // ViewData["userId"] = userId;
            return Ok();
        }

        //[HttpGet("profile/{userId}")]
        public IActionResult ViewProfile()
        {
            //ViewData["userId"] = userId;
            return Ok();
        }

        public IActionResult Splash()
        {
            return Ok();
        }

        [HttpGet("record/{id}")]
        public IActionResult ViewUser([FromRoute] Guid id)
        {
           // ViewData["id"] = id;
            return Ok();
        }


        [HttpGet("edit/{id}")]
        public IActionResult EditUser([FromRoute] Guid id)
        {
           // ViewData["id"] = id;
            return Ok();
        }


        [HttpGet("change-password/{id}")]
        public IActionResult ChangePassword([FromRoute] Guid id)
        {
           // ViewData["id"] = id;
            return Ok();
        }
    }    
}
