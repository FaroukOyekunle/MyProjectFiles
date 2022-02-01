using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace LibraryManagementSystem.Controller
{
        [Route("api/[controller]")]
        [ApiController]
        public class BookController : ControllerBase
        {
            private readonly IBookService _bookService;

            public BookController(IBookService bookService)
            {
                _bookService = bookService;
            }

            [Route("AddBook")]
            [HttpPost]
            public async Task<IActionResult> AddBook([FromBody] CreateBookRequestModel model)
            {
                var response = await _bookService.AddBook(model);
                return Ok(response);
            }

            [Route("CheckOutBook")]
            [HttpPost]
            public async Task<IActionResult> CheckOutBook([FromBody] CheckOutBookRequestModel model)
            {
                var response = await _bookService.CheckOutBook(model);
                return Ok(response);
            }

            [Route("ReturnBook")]
            [HttpPut]
            public async Task<IActionResult> ReturnBook([FromBody] ReturnBookRequestModel model)
            {
                var response = await _bookService.ReturnBook(model);
                return Ok(response);
            }

            /*[Route("updatebook/{id, model}")]*/
            /*[Route("{id}")]
            [HttpPut]
            public async Task<IActionResult> UpdateBook([FromQuery] int id, UpdateBookRequestModel model)
            {
                var response = await _bookService.UpdateBook(id, model);
                return Ok(response);
            }*/


            [Route("{id}")]
            [HttpPut]
            public async Task<IActionResult> DeleteBook([FromRoute] int id)
            {
                var response = await _bookService.DeleteBook(id);
                return Ok(response);
            }

            [Route("{id}")]
            [HttpGet]
            public async Task<IActionResult> GetBookById([FromRoute] int id)
            {
                var response = await _bookService.GetBook(id);
                return Ok(response);
            }

            [Route("GetAllBooks")]
            [HttpGet]
            public async Task<IActionResult> GetBooks()
            {
                var response = await _bookService.GetBooks();
                return Ok(response);
            }

            [Route("booktitle/{title}")]
            [HttpGet]
            public async Task<IActionResult> GetBookByTitle([FromRoute] string title)
            {
                var response = await _bookService.GetBookByTitle(title);
                return Ok(response);
            }

            [Route("pubdate/{publicationDate}")]
            [HttpGet]
            public async Task<IActionResult> GetBookByPublicationDate([FromRoute] int publicationDate)
            {
                var response = await _bookService.GetBooksByPublicationDate(publicationDate);
                return Ok(response);
            }

            [Route("category/{categoryId}")]
            [HttpGet]
            public async Task<IActionResult> GetBooksByCategory([FromRoute] int categoryId)
            {
                var response = await _bookService.GetBooksByCategory(categoryId);
                return Ok(response);
            }

            [Route("bookpublisher/{publisher}")]
            [HttpGet]
            public async Task<IActionResult> GetBookByPublisher([FromRoute] string publisher)
            {
                var response = await _bookService.GetBooksByPublisher(publisher);
                return Ok(response);
            }



            [Route("author/{authorId}")]
            [HttpGet]
            public async Task<IActionResult> GetBooksByAuthor([FromRoute] int authorId)
            {
                var response = await _bookService.GetBooksByAuthor(authorId);
                return Ok(response);
            }

            [Route("user/{userId}")]
            [HttpGet]
            public async Task<IActionResult> GetBooksBorrowed([FromRoute] int userId)
            {
                var response = await _bookService.GetBooksBorrowed(userId);
                return Ok(response);
            }

            /*[HttpGet]
            public async Task<IActionResult> GetBookByAvailabilityStatus([FromBody] BookAvailabilityStatus availabilityStatus)
            {
                var response = await _bookService.GetBooksByAvailabilityStatus(availabilityStatus);
                return Ok(response);
            }
            [HttpGet]
            public async Task<IActionResult> GetBooksByAccessibilityStatus([FromBody] BookAccessibilityStatus accessibilityStatus)
            {
                var response = await _bookService.GetBooksByAccessibilityStatus(accessibilityStatus);
                return Ok(response);
            }*/
        }
    
}