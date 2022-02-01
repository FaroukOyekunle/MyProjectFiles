using LibraryManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Publisher : BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public GenderType GenderType { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
