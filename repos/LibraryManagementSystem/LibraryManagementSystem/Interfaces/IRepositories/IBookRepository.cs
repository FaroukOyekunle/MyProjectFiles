using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IRepositories
{
   public interface IBookRepository : IRepository<Book>
   {
        Task<Book> GetBookByTitle(string title);
        Task<IList<BookDto>> GetBooksByPublicationDate(int publicationDate);
        Task<IList<BookDto>> GetBooksByPublisher(string publisher);
        Task<IList<BookDto>> GetBooksByCategory(int categoryId);
        Task<IList<BookDto>> GetBooksByAvailabilityStatus(BookAvailabilityStatus availabilityStatus);
        Task<IList<BookDto>> GetBooksByAccessibilityStatus(BookAccessibilityStatus accessibilityStatus);
        Task<BookLending> CheckoutBookItem(BookLending bookLending);
        BookLending ReturnBookItem(BookLending bookLending);
        int NumberOfBooksBorrowed(int userId, bool bookReturned);
        Task<IList<BookDto>> GetListOfBooks(int userId, bool bookReturned);
        Task<BookLending> GetBookBorrowed(int bookId, int userId, bool bookReturned);
        Task<BooksResponseModel> GetBooksByAuthor(int authorId);
   }
}
