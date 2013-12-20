using System;

namespace BookStore.Exceptions
{
	public class ExistingItemException : Exception
	{
		 public ExistingItemException()
            : base("Item already exists in collection")
        { }

		 public ExistingItemException(string message) 
            : base(message)
        { }
	}
}
