using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _4.DownloadFileExceptions
{
    class DownloadFileExceptions
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            try
            {
                
                webClient.DownloadFile("http://eurostipendii.mon.bg/Presentation-General_Information.pdf", @"C:\Users\Sevi\Desktop\euroStipendii.pdf");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Address parameter is null");
            }
            catch (WebException)
            {
                Console.WriteLine("There might be some of the following exceptions: " + "\n" + "The Uri formed by combining BaseAddress and address is invalid" + "\n" +
                    "File name is null or empty" + "\n" + "The file doesn't exist" + "\n" + "An error occurred while downloading data");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            finally
            {
                if (webClient != null)
                {
                    webClient.Dispose();
                }
            }

        }
    }
}
