using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public class Video : Multimedia
    {
        public Video(string title, string release, Carrier carrier, PGRaiting pgRaiting, 
            string barcode, byte units, bool isRentable) :
            base(title, release, carrier, pgRaiting, barcode, units, isRentable)
        {
            
        }

        public override string ToText()
        {
            StringBuilder videoInfoToText = new StringBuilder();
            
//            videoInfoToText.AppendFormat("\nVideo");
//            videoInfoToText.AppendFormat("\n---------------------");
            videoInfoToText.AppendFormat("{0}", base.ToText());
            
            return videoInfoToText.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}