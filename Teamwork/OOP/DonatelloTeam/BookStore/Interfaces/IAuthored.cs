using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interfaces
{
    public interface IAuthored
    {
        string Author { get; set; }
        //void searchByAuthor(string authorName);
    }
}
