using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Implementations.Repositories;
using LibraryManagementSystem.Interfaces.IRepositories;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Implementations.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<BaseResponse> Addcategory(CreateCategoryRequestModel model)
        {
            var category = new Category
            {
                Name = model.Name
            };

            await _categoryRepository.AddAsync(category);
            await _categoryRepository.SaveChangesAsync();
            return new BaseResponse
            {
                Status = true,
                Message = "Category Added Successfully"
            };
        }

        public void DeleteCategory(int id)
        {
            var category = _categoryRepository.DeleteAsync(id);
            _categoryRepository.SaveChangesAsync();
        }

        public async Task<CategoriesResponseModel> GetCategories()
        {
            var categories = await _categoryRepository.Query().Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name

            }).ToListAsync();

            return new CategoriesResponseModel
            {
                Data = categories,
                Status = true,
                Message = "Categories retrieved successfully"
            };
        }

        public async Task<CategoryResponseModel> GetCategory(int id)
        {
            var category = await _categoryRepository.GetAsync(id);

            return new CategoryResponseModel
            {
                Data = new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name
                },

                Status = true,
                Message = "Category retrieved Successfully"

            };
        }

        public async Task<CategoriesResponseModel> GetSelectedCategories(IList<int> ids)
        {
            var categories = await _categoryRepository.GetAsync(ids);

            return new CategoriesResponseModel
            {

                Data = (IEnumerable<CategoryDto>)categories,
                Status = true,
                Message = "Categories retrieved successfully"
            };
        }

        public async Task<BaseResponse> UpdateCategory(int id, UpdateCategoryRequestModel model)
        {
            var category = await _categoryRepository.GetAsync(id);
            category.Name = model.Name;

            await _categoryRepository.UpdateAsync(category);
            await _categoryRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "Category Updated Successfully"
            };
        }
    }
}
