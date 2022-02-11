using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningManagementSystem.Enums
{
    public enum EnumAndConstant
    {

    }
    public enum BookFormat
    {
        HARDCOVER = 1,
        AUDIO_BOOK,
        EBOOK,
        NEWSPAPER,
        MAGAZINE,
        JOURNAL
    }
    public enum BookStatus
    {
        AVAILABLE = 1,
        RESERVED,
        LOANED,
        LOST
    }
    public enum ReservationStatus
    {
        WAITING = 1,
        PENDING,
        CANCELED,
        NONE
    }
    public enum AccountStatus
    {
        ACTIVE = 1,
        CLOSED,
        CANCELED,
        BLACKLISTED,
        NONE
    }
    public class Address
    {
        private string streetAddress;
        private string city;
        private string state;
        private string zipCode;
        private string country;
    }
    public class Person
    {
        private string name;
        private Address address;
        private string email;
        private string phoneNumber;
    }
    public class Constants
    {
        public const int MAX_BOOKS_ISSUED_TO_A_USER = 5;
        public const int MAX_LENDING_DAYS = 10;
    }
}


