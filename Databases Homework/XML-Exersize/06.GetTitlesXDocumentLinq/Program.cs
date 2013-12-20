using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        XDocument doc = XDocument.Load("../../Catalogue.xml");
        var titles =
            from song in doc.Descendants("song")
            select new
            {
                Title = song.Element("title").Value,

            };
        foreach (var title in titles)
        {
            Console.WriteLine("{0}", title.Title);
        }
    }
}

