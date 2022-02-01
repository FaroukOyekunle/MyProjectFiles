using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string BookSubject { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookPhoto { get; set; }
        public string BookPublisher { get; set; }
        public string CopyRightBook { get; set; }
        public int EditionNumber { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public int NumberOfCopies { get; set; }
        public int ShelfNo { get; set; }
        public ICollection<BookCategory> BookCategorys { get; set; } = new List<BookCategory>();
    }
}
