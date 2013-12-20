using System;

namespace BookStore.Exceptions
{
    public class MoreUnitsThanDefinedException : Exception
    {
        public MoreUnitsThanDefinedException()
            : base("Cannot have more available units than defined")
        { }

        public MoreUnitsThanDefinedException(string message) 
            : base(message)
        { }
    }
}
