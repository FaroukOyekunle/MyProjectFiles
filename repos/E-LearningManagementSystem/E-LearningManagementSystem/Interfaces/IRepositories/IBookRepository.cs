using E_LearningManagementSystem.Entities;
using E_LearningManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Interfaces.IRepositories
{
    public interface IBookRepository
    {
        public bool addBookItem(Book book);
        public bool blockMember(UserType userType);
        public bool unBlockMember(UserType userType);
        public Book AddBook(Book book);
        public Book UpdateBook(int id);
        public Book GetBookById(int id);
    }
}
