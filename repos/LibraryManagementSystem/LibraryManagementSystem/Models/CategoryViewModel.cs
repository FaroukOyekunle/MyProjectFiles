using LibraryManagementSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
        public class CreateCategoryRequestModel
        {
            public string Name { get; set; }
        }

        public class UpdateCategoryRequestModel
        {
            public string Name { get; set; }
        }

        public class CategoryResponseModel : BaseResponse
        {
            public CategoryDto Data { get; set; }
        }

        public class CategoriesResponseModel : BaseResponse
        {
            public IEnumerable<CategoryDto> Data { get; set; } = new List<CategoryDto>();
        }
    
}
