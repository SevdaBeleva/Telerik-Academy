using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.GetArtistXPath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../Catalogue.xml");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string pathQuery = "catalogue/album";
            XmlNodeList nodeList = doc.SelectNodes(pathQuery);

            foreach (XmlNode node in nodeList)
            {
                string artist = node.SelectSingleNode("artist").InnerText;

                if (dictionary.ContainsKey(artist))
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
}
