using LibraryManagementSystem.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.AuthorViewModel;

namespace LibraryManagementSystem.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class AuthorController : ControllerBase
        {
            private readonly IAuthorService _authorService;

            public AuthorController(IAuthorService authorService)
            {
                _authorService = authorService;

            }

            //[Authorize]
            [HttpPost]
            public async Task<IActionResult> Create([FromBody] CreateAuthorRequestModel model)
            {
                var response = await _authorService.AddAuthor(model);
                return Ok(response);
            }

            //[Authorize]
            [HttpGet("{id}")]
            public async Task<IActionResult> GetAuthor([FromRoute] int id)
            {
                var response = await _authorService.GetAuthor(id);
                return Ok(response);
            }

            [HttpGet]
            public async Task<IActionResult> GetAuthors()
            {
                var response = await _authorService.GetAuthors();
                return Ok(response);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateAuthor([FromRoute] int id, UpdateAuthorRequestModel model)
            {
                var response = await _authorService.UpdateAuthor(id, model);
                return Ok(response);
            }

        }
}

