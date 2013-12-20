namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains set of methods extending System.String class 
    /// <see cref="http://msdn.microsoft.com/en-us/library/system.string_methods.aspx"/>
    /// The XML documentation comments in the current file are made considering MSDN recommended tags
    /// <seealso cref="http://msdn.microsoft.com/en-us/library/5ast78ax.aspx"/>
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts string into MD5Hash. The MD5 Message-Digest Algorithm is a widely used cryptographic hash function
        /// <see cref="http://en.wikipedia.org/wiki/MD5"/>>
        /// </summary>
        /// <param name="input">string that will be converted into MD5Hash</param>
        /// <returns>128-bit (16-byte) hash value</returns>
        /// <example>
        /// Shows how to use ToMd5Hash method
        /// <code>
        /// class TestProgram 
        /// {
        ///     static void Main()
        ///     {
        ///         string input = "Convert this string";
        ///         Console.WriteLine(input.ToMd5Hash());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Check if the string value can be assigned to boolean type 
        /// </summary>
        /// <param name="input">string - to be checked</param>
        /// <returns>True or False</returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "да";
        ///         ConsoleWriteLine(value.ToBoolean());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts string value into short type
        /// </summary>
        /// <param name="input">string that will be converted into short type</param>
        /// <returns>short value or 0 </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "124";
        ///         ConsoleWriteLine(value.ToShort());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts string value into integer type
        /// </summary>
        /// <param name="input">string that will be converted into integer type</param>
        /// <returns>integer value or 0 </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "124567";
        ///         ConsoleWriteLine(value.ToInteger());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts string value into long type
        /// </summary>
        /// <param name="input">string that will be converted into long type</param>
        /// <returns>long value or 0 </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "1241256";
        ///         ConsoleWriteLine(value.ToLong());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts string value into DateTime type
        /// </summary>
        /// <param name="input">string that will be converted into DateTime type</param>
        /// <returns>DateTime value or 0 </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "12.11.2012";
        ///         ConsoleWriteLine(value.DateTime());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Converts the first letter to upper case
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>string beginning with capital letter </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "test";
        ///         ConsoleWriteLine(value.CapitalizeFirstLetter());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get the substring
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>substring </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "do some test";
        ///         ConsoleWriteLine(value.GetStringBetween());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts cyrillic to latin letters
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>string containing latin letters </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "тествай";
        ///         ConsoleWriteLine(value.ConvertCyrillicToLatinLetters());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts latin to cyrillic keyboard
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>string containing cyrillic keyboard </returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "test";
        ///         ConsoleWriteLine(value.ConvertLatinToCyrillicKeyboard());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts string into valid user name
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>user name</returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "some@email_email@abv.bg";
        ///         ConsoleWriteLine(value.ToValidUserName());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string ToValidUserName(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Convert string into file name
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>file name of latin letters</returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "do some test";
        ///         ConsoleWriteLine(value.ToValidLatinFileName());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Get first characters from a string value
        /// </summary>
        /// <param name="input">string value</param>
        /// <param name="charsCount">int value, shows how many characters will be taken</param>
        /// <returns>set of characters</returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "get some characters";
        ///         ConsoleWriteLine(value.GetFirstCharacters());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get the file extension. Check if the string is null or empty
        /// </summary>
        /// <param name="fileName">string value</param>
        /// <returns>file extension in string value</returns>
        /// <example>
        /// <code>
        /// class TestMethods
        /// {
        ///     static void Main()
        ///     {
        ///         string value = "getFileExtensions.cs";
        ///         ConsoleWriteLine(value.GetFileExtension());
        ///     }
        /// }
        /// </code>
        /// </example>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Get the content type of the specified file extension
        /// </summary>
        /// <param name="fileExtension">string value</param>
        /// <returns>content type</returns>
        /// <example>
        /// <code>
        /// class TestClass
        /// {
        /// static void Main()
        /// {
        /// string value = "png";
        /// Console.WriteLine(value.ToContentType());
        /// }
        /// }
        /// </code>
        /// </example>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Convert string into array of bytes
        /// </summary>
        /// <param name="input">string value</param>
        /// <returns>array of bytes containing characters</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
