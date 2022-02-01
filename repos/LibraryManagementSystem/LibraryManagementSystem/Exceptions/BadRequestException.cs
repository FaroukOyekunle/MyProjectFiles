using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {

        }
        public BadRequestException(string message) : base(message)
        {

        }
        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
