using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        string fileLocation = "../../person.txt";
        List<string> list = new List<string>();

        using (StreamReader reader = new StreamReader(fileLocation)) 
        {
            string line;
            while((line = reader.ReadLine())!= null)
            {
                list.Add(line);
            }
        }

        XElement personXml = new XElement("register", 
            new XElement("person", 
                new XElement("name", list[0]), 
                new XElement("address", list[1]), 
                new XElement("phoneNumber", list[2])
                )     
            );

        personXml.Save("../../person.xml");
    }
}

