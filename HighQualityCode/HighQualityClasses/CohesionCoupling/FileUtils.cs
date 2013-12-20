using System;

namespace CohesionCoupling
{
   public class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf('.');
            if (indexOfLastDot == -1)
            {
                return "No file";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf('.');
            if (indexOfLastDot == -1)
            {
                return "No file";
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
