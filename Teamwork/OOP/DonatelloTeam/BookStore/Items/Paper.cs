using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Items
{
    public class Paper : Press
    {
        private int sections;
        private int numberOfArticles;

        public Paper(string title, string dateOfIssue, int issue, byte units, string barcode,
            int sections, int numberOfArticles)
            : base(title, dateOfIssue, issue, barcode, units)
        {
            this.Sections = sections;
            this.NumberOfArticles = numberOfArticles;
        }

        public int Sections
        {
            get { return this.sections; }
            private set
            {
                this.sections = value;
                if (value < 0)
                {
                    throw new ArgumentException("Sections should not be a negative number!");
                }
            }
        }

        public int NumberOfArticles
        {
            get { return this.numberOfArticles; }
            private set
            {
                this.numberOfArticles = value;
                if (value < 0)
                {
                    throw new AccessViolationException("Number of articles should not be a negative number!");
                }
            }
        }

        public override string ToText()
        {
            StringBuilder paperInfoToText = new StringBuilder();
//            paperInfoToText.AppendFormat("\nNewspaper");
//            paperInfoToText.AppendFormat("\n---------------------");
            paperInfoToText.AppendFormat("{0}", base.ToText());
            paperInfoToText.AppendFormat("\r\nSubject: {0}", this.Sections);
            paperInfoToText.AppendFormat("\r\nNumber of articles: {0}", this.NumberOfArticles);
            return paperInfoToText.ToString();
        }

        public override string ToString()
        {
            StringBuilder paperInfo = new StringBuilder();
            string separator = " ";

            paperInfo.Append(base.ToString());
            paperInfo.Append(separator);
            paperInfo.Append(this.Sections);
            paperInfo.Append(separator);
            paperInfo.Append(this.NumberOfArticles);

            return paperInfo.ToString();
        }

    }
}
