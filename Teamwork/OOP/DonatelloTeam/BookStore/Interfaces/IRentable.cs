using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Interfaces
{
    public interface IRentable
    {
        void Rent();
        void Return();
    }
}
