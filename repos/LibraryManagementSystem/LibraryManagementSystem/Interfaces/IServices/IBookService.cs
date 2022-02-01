using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IServices
{
    public interface IBookService
    {
        public Task<BaseResponse> AddBook(CreateBookRequestModel model);
        public Task<BaseResponse> UpdateBook(int id, UpdateBookRequestModel model);
        public Task<BaseResponse> DeleteBook(int id);
        public Task<BookResponseModel> GetBook(int id);
        public Task<BookResponseModel> GetBookByTitle(string title);
        public Task<BooksResponseModel> GetBooksByAuthor(int authorId);
        public Task<BooksResponseModel> GetBooksByCategory(int categoryId);
        public Task<BooksResponseModel> GetBooksByPublisher(string publisher);
        public Task<BooksResponseModel> GetBooksByPublicationDate(int publicationDate);
        public Task<BooksResponseModel> GetBooksByAvailabilityStatus(BookAvailabilityStatus availabilityStatus);
        public Task<BooksResponseModel> GetBooksByAccessibilityStatus(BookAccessibilityStatus accessibilityStatus);
        public Task<BooksResponseModel> GetBooks();
        public Task<BaseResponse> CheckOutBook(CheckOutBookRequestModel model);
        public Task<BaseResponse> ReturnBook(ReturnBookRequestModel model);
        int BooksBorrowed(int userId, bool bookReturned);
        public Task<BooksResponseModel> GetBooksBorrowed(int userId);
    }
}
