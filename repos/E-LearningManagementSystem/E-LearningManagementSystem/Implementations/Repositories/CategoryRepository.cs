using E_LearningManagementSystem.Context.ApplicationContext;
using E_LearningManagementSystem.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Implementations.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly LibraryContext _libraryContext;
        public CategoryRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
    }
}
