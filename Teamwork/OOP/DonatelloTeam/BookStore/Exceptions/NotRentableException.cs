using System;

namespace BookStore.Exceptions
{
    public class NotRentableException : Exception
    {
        public NotRentableException() : 
            this("Can't rent an unrentable item")
        { }

        public NotRentableException(string message)
            : base(message)
        { }
    }
}
