using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _3.ReadFileExceptions
{
    class ReadPrintFileExceptions
    {
        static string ReadFileAndPrintText(string filepath)
        {
            string content = File.ReadAllText(filepath);
            return content;
     
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the path of the file: ");
                string path = Console.ReadLine();
                string content = ReadFileAndPrintText(path);
                Console.WriteLine("The content of file is: {0}", content);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Path Cars");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Exceeded the system-defined maximum length of characters");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specific path is not found");
            }
            catch (IOException)
            {
                Console.WriteLine("An Input/Output error occurred while opnening the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("There might be some of the following errors: " + "\n" + "File is read-only" + "\n" +
                    "The operation is not supported on the current platform" + "\n" + "Path specified a directory" + "\n" +
                    "You don't have the required permission");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission");
            }

         
        }
    }
}
