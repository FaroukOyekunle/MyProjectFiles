using LibraryManagementSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class AuthorViewModel
    {
        public class CreateAuthorRequestModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Biography { get; set; }
        }
        public class UpdateAuthorRequestModel
        {
            public string Biography { get; set; }
        }
        public class AuthorsResponseModel : BaseResponse
        {
            public IEnumerable<AuthorDto> Data { get; set; } = new List<AuthorDto>();
        }

        public class AuthorResponseModel : BaseResponse
        {
            public AuthorDto Data { get; set; }
        }
    }
}
