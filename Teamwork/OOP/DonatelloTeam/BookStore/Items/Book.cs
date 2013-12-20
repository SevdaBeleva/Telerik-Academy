using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
	public class Book : BookStoreItem, IAuthored
	{
		private string author;
		private string title;

		public Book(string title, string author, string barcode, byte units, bool isRentable = true)
			: base(barcode, units, isRentable)
		{
			this.Author = author;
			this.Title = title;
		}

		public string Author
		{
			get { return this.author; }
			set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author cannot be empty.");
                }
                else
                {
                    this.author = value;
                }
            }
		}

		public string Title
		{
			get { return this.title; }
			set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                else
                {
                    this.title = value;
                }
            }
		}

        public override string ToText()
        {
            StringBuilder bookInfoToText = new StringBuilder();
//            bookInfoToText.AppendFormat("\r\nBook");
//            bookInfoToText.AppendFormat("\r\n---------------------");
//            bookInfoToText.AppendFormat("\r\nTitle: {0} ", this.Title);
            bookInfoToText.AppendFormat("Title: {0} ", this.Title);
            bookInfoToText.AppendFormat("\r\nAuthor: {0} ", this.Author);
            bookInfoToText.AppendFormat("\r\nAvailable Units: {0}", this.AvailableUnits);
            bookInfoToText.AppendFormat("\r\n{0}", base.ToText());
            return bookInfoToText.ToString();
        }

		public override string ToString()
		{
            StringBuilder literatureInfo = new StringBuilder();
            string separator = " ";

            literatureInfo.AppendFormat(this.Title);
            literatureInfo.Append(separator);
            literatureInfo.Append(this.Author);
            literatureInfo.Append(separator);
//            literatureInfo.Append(this.AvailableUnits);
//            literatureInfo.Append(separator);
            literatureInfo.Append(base.ToString());
            literatureInfo.Append(separator);

            return literatureInfo.ToString();  
		}
	}
}