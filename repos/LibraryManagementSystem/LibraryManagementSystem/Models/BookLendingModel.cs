using LibraryManagementSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{

    
        public class CheckOutBookRequestModel
        {
            public int UserId { get; set; }
            public int BookId { get; set; }

            public bool ReturnedBook = false;
        }

        public class ReturnBookRequestModel
        {
            public int UserId { get; set; }
            public int BookId { get; set; }
            public bool ReturnedBook = false;
        }

        public class BooklendingResponseModel : BaseResponse
        {
            public BookLendingDto Data { get; set; }
        }
    
}
