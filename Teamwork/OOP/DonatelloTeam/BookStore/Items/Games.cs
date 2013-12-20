using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Interfaces;

namespace BookStore.Items
{
    public class Games : Multimedia
    {
        private Platform platform;

        public Games(string title, string release, Carrier carrier, Platform platform, PGRaiting pgRaiting,
            string barcode, byte units, bool isRentable) :
            base(title, release, carrier, pgRaiting, barcode, units, isRentable)
        {
            this.Platform = platform;
        }

        public Platform Platform
        {
            get { return this.platform; }
            private set { this.platform = value; }
        }

        public override string ToText()
        {
            StringBuilder gamesInfoToText = new StringBuilder();
//            gamesInfoToText.AppendFormat("\nGames");
//            gamesInfoToText.AppendFormat("\n---------------------");
            gamesInfoToText.AppendFormat("{0}", base.ToText());
            gamesInfoToText.AppendFormat("\r\nPlatform: {0}", this.Platform);
            return gamesInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder gamesInfo = new StringBuilder();
            string separator = " ";

            gamesInfo.Append(base.ToString());
            gamesInfo.Append(separator);
            gamesInfo.Append(this.Platform);
            
            return gamesInfo.ToString();
        }
    }
}
