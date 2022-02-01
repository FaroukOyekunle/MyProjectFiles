using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.AuthorViewModel;

namespace LibraryManagementSystem.Interfaces.IServices
{
  public  interface IAuthorService
  {
        public Task<AuthorResponseModel> GetAuthor(int id);
        public Task<AuthorsResponseModel> GetAuthors();
        public Task<BaseResponse> UpdateAuthor(int id, UpdateAuthorRequestModel model);
        public Task<BaseResponse> AddAuthor(CreateAuthorRequestModel model);
        public void DeleteAuthor(int id);
  }
}
