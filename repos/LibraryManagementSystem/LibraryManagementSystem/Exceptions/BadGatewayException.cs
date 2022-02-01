using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Exceptions
{
    public class BadGatewayException : Exception
    {
        public BadGatewayException()
        {

        }
        public BadGatewayException(string message) : base(message)
        {

        }
        public BadGatewayException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
