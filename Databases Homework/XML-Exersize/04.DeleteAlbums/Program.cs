using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class Program
{
    static void Main(string[] args)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("../../catalogue.xml");
        XmlNode rootNode = doc.DocumentElement;

        foreach (XmlNode node in rootNode)
        {
            double price = double.Parse(node["price"].InnerText.Trim());

            if (price > 20)
            {
                rootNode.RemoveChild(node);
            }    
        }
        doc.Save(Console.Out);      
    }
}

