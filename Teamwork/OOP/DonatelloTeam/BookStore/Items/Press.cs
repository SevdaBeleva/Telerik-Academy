using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Items
{
    public abstract class Press : BookStoreItem
    {
        private string title;
        private DateTime dateOfIssue;
        private int issue;

        public Press(string title, string dateOfIssue, int issue, string barcode, byte units)
            : base(barcode, units, false)
        {
            this.Title = title;
            this.DateOfIssue = dateOfIssue;
            this.Issue = issue;
        }

        public string DateOfIssue
        {
            get { return this.dateOfIssue.ToShortDateString(); }
            private set
            {
                if (!DateTime.TryParseExact(value, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out this.dateOfIssue))
                {
                    throw new ArgumentException();
                }
                
            }
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
                this.title = value;
            }
        }

        public int Issue
        {
            get { return this.issue; }
            private set
            {
                this.issue = value;
                if (value < 0)
                {
                    throw new ArgumentException("Issue should not be a negative number!");
                }
            }
        }

        public override string ToText()
        {
            StringBuilder pressInfoToText = new StringBuilder();
            
            pressInfoToText.AppendFormat("Title: {0}", this.Title);
            pressInfoToText.AppendFormat("\r\nDate of issue: {0}", this.DateOfIssue);
            pressInfoToText.AppendFormat("\r\nIssue: {0}", this.Issue);
            pressInfoToText.AppendFormat("\r\n{0}", base.ToText());

            return pressInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder pressInfo = new StringBuilder();
            string separator = " ";

            pressInfo.AppendFormat(this.Title);
            pressInfo.Append(separator);
            pressInfo.Append(this.DateOfIssue);
            pressInfo.Append(separator);
            pressInfo.Append(this.Issue);
            pressInfo.Append(separator);
            pressInfo.Append(base.ToString());

            return pressInfo.ToString();
        }



    }
}
