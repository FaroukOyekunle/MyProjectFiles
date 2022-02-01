using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Interfaces.IServices
{
    public interface ICategoryService
    {
        public Task<CategoryResponseModel> GetCategory(int id);
        public Task<CategoriesResponseModel> GetCategories();
        public Task<CategoriesResponseModel> GetSelectedCategories(IList<int> ids);
        public Task<BaseResponse> Addcategory(CreateCategoryRequestModel model);
        public Task<BaseResponse> UpdateCategory(int id, UpdateCategoryRequestModel model);
        public void DeleteCategory(int id);
    }
}
