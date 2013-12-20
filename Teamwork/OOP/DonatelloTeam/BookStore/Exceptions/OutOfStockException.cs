using System;

namespace BookStore.Exceptions
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException()
            : this("Item out of stock, no copies left to rent") 
        { }

        public OutOfStockException(string message) 
            : base(message) 
        { }
    }
}
