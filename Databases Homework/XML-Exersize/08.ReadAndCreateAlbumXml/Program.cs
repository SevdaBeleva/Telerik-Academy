using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

public class Program
{
    static void Main(string[] args)
    {
        string fileLocation = "../../album.xml";
        Encoding encoding = Encoding.GetEncoding("windows-1251");

        using (XmlReader reader = XmlReader.Create("../../Catalogue.xml"))
        {
            using (XmlTextWriter writer = new XmlTextWriter(fileLocation, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("Albums");  // add root element
                writer.WriteAttributeString("name", "album");

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementString());
                        }

                        if (reader.Name == "artist")
                        {
                            writer.WriteElementString("artist", reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}

