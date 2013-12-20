using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public abstract class Multimedia : BookStoreItem
    {
        private string title;
        private Carrier carrier;
        private PGRaiting pgRaiting;
        private string release;

        protected Multimedia(string title, string release, Carrier carrier, string barcode, 
            byte units, bool isRentable) 
            : this(title, release, carrier, 0, barcode, units, isRentable)
        {
        }

        protected Multimedia(string title, string release, Carrier carrier, PGRaiting pgraiting, 
            string barcode, byte units, bool isRentable) :
            base(barcode, units, isRentable)
        {
            this.Title = title;
            this.ItemCarrier = carrier;
            this.ItemPGRaiting = pgraiting;
            this.Release = release;
        }

        public PGRaiting ItemPGRaiting
        {
            get { return this.pgRaiting; }
            private set { this.pgRaiting = value; }
        }

        public string Title
        {
            get { return this.title; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title field should not be empty!");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public Carrier ItemCarrier
        {
            get { return this.carrier; }
            set { this.carrier = value; }
        }

        public string Release
        {
            get { return this.release; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Release cannot be empty");
                }
                else
                {
                    this.release = value;
                }
            }
        }

        public override string ToText()
        {
            StringBuilder multimediaInfoToText = new StringBuilder();
//            multimediaInfoToText.AppendFormat("\nTitle: {0} ", this.Title);
            multimediaInfoToText.AppendFormat("Title: {0} ", this.Title);
            multimediaInfoToText.AppendFormat("\r\nCarrier: {0} ", this.ItemCarrier);
            multimediaInfoToText.AppendFormat("\r\nPG Raiting: {0}", this.ItemPGRaiting);
            multimediaInfoToText.AppendFormat("\r\nRelease: {0}", this.Release);
            multimediaInfoToText.AppendFormat("\r\n{0}", base.ToText());
            return multimediaInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder multimediaInfo = new StringBuilder();
            string separator = " ";

            multimediaInfo.AppendFormat(this.Title);
            multimediaInfo.Append(separator);
            multimediaInfo.Append(this.ItemCarrier);
            multimediaInfo.Append(separator);
            multimediaInfo.Append(this.Release);
            multimediaInfo.Append(separator);
            multimediaInfo.Append(base.ToString());
            multimediaInfo.Append(separator);

            return multimediaInfo.ToString();            
        }

    }
}
