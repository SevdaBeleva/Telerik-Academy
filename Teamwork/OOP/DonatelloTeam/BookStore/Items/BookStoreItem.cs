using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Exceptions;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public abstract class BookStoreItem : IRentable
    {
//        private string title;
//        private string release;
        private string barcode;
//        private uint releaseNumber;
//        private uint ISSNNumber;
        private byte units;
        private byte availableUnits;
        private bool isRentable;

//        private DateTime releaseDate;

        protected BookStoreItem(string barcode, byte units) :
            this(barcode, units, false)
        {
        }

        protected BookStoreItem(string barcode, byte units, bool isRentable)
        {
            this.Barcode = barcode;
            this.Units = units;
            this.AvailableUnits = units;
            this.IsRentable = isRentable;
        }
        
        public string Barcode
        {
            get { return this.barcode; }
            private set { this.barcode = value; }
        }

        public byte Units
        {
            get { return this.units; }
            private set { this.units = value; }
        }

        public byte AvailableUnits
        {
            get { return this.availableUnits; }
            private set { this.availableUnits = value; }
        }


        public bool IsRentable
        {
            get { return this.isRentable; }
            private set { this.isRentable = value; }
        }

        public override string ToString()
        {
            return this.Barcode;
        }

        public virtual string ToText()
        {
            StringBuilder text = new StringBuilder();
            string separator = "\r\n";

            text.AppendFormat("Barcode: {0}", this.Barcode);
            text.Append(separator);
            text.AppendFormat("Available : {0}", this.AvailableUnits.ToString());

            return text.ToString();
        }

        private void DecreaseAvailability()
        {
            if (this.AvailableUnits < 1)
            {
                throw new OutOfStockException(String.Format("Item with barcode {0} is out of stock",this.Barcode));
            }
            
            this.AvailableUnits--;
        }

        private void IncreaseAvailability()
        {
            if (this.AvailableUnits == this.Units)
            {
                throw new MoreUnitsThanDefinedException(String.Format("Cannot have more units than defined for item with barcode {0}", this.Barcode));
            }

            this.AvailableUnits++;
        }
        
        public void Rent()
        {
            if(!this.IsRentable)
            {
                throw new NotRentableException(String.Format("Item with barcode {0} cannot be rented",this.Barcode));         
            }

            DecreaseAvailability();
        }

        public void Return()
        {
            IncreaseAvailability(); 
        }
    }
}
