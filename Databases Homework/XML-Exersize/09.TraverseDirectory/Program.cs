using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string fileLocation = @"..\..\catalogue.xml";
        XDocument xmlDoc = XDocument.Load(fileLocation);
        XName albumTitle = "name";
        int currentYear = DateTime.Now.Year;

        var albums =
           from album in xmlDoc.Descendants("album")
           where ((currentYear - int.Parse(album.Element("year").Value)) <= 5)
           select new
           {
               Title = album.Attribute(albumTitle).Value,
               Year = int.Parse(album.Element("year").Value)
           };

        foreach (var album in albums)
        {
            Console.WriteLine("{0},{1}", album.Title, album.Year);
        }
    }
}

