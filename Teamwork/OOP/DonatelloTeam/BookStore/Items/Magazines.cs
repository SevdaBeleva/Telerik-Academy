using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Items
{
    public class Magazines : Press
    {
        private string subject;

        public Magazines(string title, string subject, string dateOfIssue, int issue, byte units, string barcode)
            : base(title, dateOfIssue, issue, barcode, units)
        {
            this.Subject = subject;
        }

        public string Subject
        {
            get { return this.subject; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Subject field should not be empty!");
                }
                this.subject = value;
            }
        }

        public override string ToText()
        {
            StringBuilder magazineInfoToText = new StringBuilder();
//            magazineInfoToText.AppendFormat("\nMagazine");
//            magazineInfoToText.AppendFormat("\n---------------------");
            magazineInfoToText.AppendFormat("{0}", base.ToText());
            magazineInfoToText.AppendFormat("\r\nSubject: {0}", this.Subject);
            return magazineInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder magazineInfo = new StringBuilder();
            string separator = " ";

            magazineInfo.Append(base.ToString());
            magazineInfo.Append(separator);
            magazineInfo.AppendFormat(this.Subject);
                        
            return magazineInfo.ToString();
        }
    }
}
