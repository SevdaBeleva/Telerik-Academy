using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public class Music : Multimedia, IAuthored
    {
        private string author;

        public Music(string title, string release, string author, Carrier carrier, 
            string barcode, byte units, bool isRentable) :
            base(title, release, carrier, barcode, units, isRentable)
        {
            this.Author = author;
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

        public override string ToText()
        {
            StringBuilder musicInfoToText = new StringBuilder();
            
//            musicInfoToText.AppendFormat("\nMusic");
//            musicInfoToText.AppendFormat("\n---------------------");
//            musicInfoToText.AppendFormat("\nAuthor: {0} ", this.Author);
            musicInfoToText.AppendFormat("Author: {0} ", this.Author);
            musicInfoToText.AppendFormat("\r\n{0}", base.ToText());
            
            return musicInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder musicInfo = new StringBuilder();
            string separator = " ";

            musicInfo.AppendFormat(this.Author);
            musicInfo.Append(separator);
            musicInfo.Append(base.ToString());

            return musicInfo.ToString();
        }
    }
}
