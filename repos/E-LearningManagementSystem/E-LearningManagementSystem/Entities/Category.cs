using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningManagementSystem.Entities
{
    public class Category: BaseEntity
    {
        public int Name { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; } = new List<BookCategory>();
    }
}
