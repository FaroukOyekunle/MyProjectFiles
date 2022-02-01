using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces.IRepositories;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.AuthorViewModel;

namespace LibraryManagementSystem.Implementations.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<BaseResponse> AddAuthor(CreateAuthorRequestModel model)
        {
            var author = new Author
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Biography = model.Biography
            };
            await _authorRepository.AddAsync(author);
            await _authorRepository.SaveChangesAsync();
            return new BaseResponse
            {
                Status = true,
                Message = "Successfully Added"
            };
        }

        public void DeleteAuthor(int id)
        {
           /* var author =  _authorRepository.GetAsync(id);
             _authorRepository.DeleteAsync(author);
            await _authorRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "Author Deleted Successfully"
            };*/
            var category = _authorRepository.DeleteAsync(id);
            _authorRepository.SaveChangesAsync();
        }

        public async Task<AuthorResponseModel> GetAuthor(int id)
        {
            var author = await _authorRepository.GetAsync(id);
            /*if (author == null) 
            {
                throw new NotFoundException("Role does not exist");
            }*/
            return new AuthorResponseModel
            {
                Data = new AuthorDto
                {
                    Id = id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Biography = author.Biography
                },
                Status = true,
                Message = "Successful"
            };

        }

        public async Task<AuthorsResponseModel> GetAuthors()
        {
            var authors = await _authorRepository.Query().Select(a => new AuthorDto
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Biography = a.Biography
            }).ToListAsync();

            return new AuthorsResponseModel
            {
                Data = authors,
                Status = true,
                Message = "Authors successfully retrieved"
            };

        }

        public async Task<BaseResponse> UpdateAuthor(int id, UpdateAuthorRequestModel model)
        {
            var author = await _authorRepository.GetAsync(id);
            author.Biography = model.Biography;
            await _authorRepository.UpdateAsync(author);
            await _authorRepository.SaveChangesAsync();
            return new BaseResponse
            {
                Status = true,
                Message = "Author successfully updated"
            };

        }
    }
}
