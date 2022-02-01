using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequestModel model)
        {
            var response = await _categoryService.Addcategory(model);
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory([FromRoute] int id)
        {
            var response = await _categoryService.GetCategory(id);
            return Ok(response);
        }

        [HttpGet]

        public async Task<CategoriesResponseModel> GetCategories()
        {
            var response = await _categoryService.GetCategories();
            return response;
        }

        /* [HttpGet]
         public async Task<IActionResult> GetSelectedCategories(IList<int> ids)
         {
             var response = await _categoryService.GetSelectedCategories(ids);
             return Ok(response);
         }*/

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory([FromRoute] int id, UpdateCategoryRequestModel model)
        {
            var response = await _categoryService.UpdateCategory(id, model);
            return Ok(response);
        }
    }
}
