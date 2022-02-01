using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Enums
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class Constants
    {
        public const int MAX_BOOKS_ISSUED_TO_A_USER = 5;
        public const int MAX_LENDING_DAYS = 10;
    }
}

