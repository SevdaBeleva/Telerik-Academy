using System;
using System.Web;

class Program
{
    static void Main(string[] args)
    {
        Uri url = new Uri("http://www.devbg.org/forum/index.php");
        Console.WriteLine("[protocol] = \"{0}\"", url.Scheme);
        Console.WriteLine("[server] = \"{0}\"", url.Host);
        Console.WriteLine("[resourse] = \"{0}\"", url.AbsolutePath);
        
    }
}

