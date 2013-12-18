using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ConvertStringToUnicode
{
    static void Main(string[] args)
    {
        string text = "Hi!";
        StringBuilder sb = new StringBuilder();
        foreach (char c in text)
        {
            sb.Append(@"\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        Console.WriteLine(sb.ToString());
    }

}
