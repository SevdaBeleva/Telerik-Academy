using System;
using System.IO;
using System.Text;

public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;
    
    public Event(DateTime date, string title, string location)
    {
        this.Date = date;
        this.Title = title;
        this.Location = location;
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Location
    {
        get { return location; }
        set { location = value; }
    }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int byDate = this.date.CompareTo(other.Date);
        int byTitle = this.title.CompareTo(other.Title);
        int byLocation = this.location.CompareTo(other.Location);

        if (byDate == 0)
        {
            if (byTitle == 0)
            {
                return byLocation;
            }
            else
            {
                return byTitle;
            }
        }
        else
        {
            return byDate;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append("|" + title);

        if ((this.Location != null) && (this.Location != " "))
        {
            toString.Append("|" + this.Location);
        }

        return toString.ToString();
    }
}