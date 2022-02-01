using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Entities
{
    public class BookCategory
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
