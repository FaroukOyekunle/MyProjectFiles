using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Exceptions
{
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions()
        { }

        public NotFoundExceptions(string message)
            : base(message)
        { }

        public NotFoundExceptions(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
