using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public struct Copyright
    {
        private string holder;
        private CopyrightTypes type;

        public CopyrightTypes Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Holder
        {
            get { return this.holder; }
            set { this.holder = value; }
        }
    }
}
