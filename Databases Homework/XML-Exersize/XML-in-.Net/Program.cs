using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("../../Catalogue.xml");
        Console.WriteLine("Document Loaded");

        XmlNode rootNode = doc.DocumentElement;
        Console.WriteLine("Root node is: {0}", rootNode.Name);

        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        foreach (XmlNode node in rootNode.ChildNodes)
        {
            string artist = node["artist"].InnerText;

            if (dictionary.Keys.Contains(artist))
            {
                dictionary[artist]++;
            }
            else
            {
                dictionary.Add(artist, 1);
            }
        }

        foreach (var artist in dictionary)
        {
            Console.WriteLine("{0} {1}", artist.Key, artist.Value);
        }
    }
}

