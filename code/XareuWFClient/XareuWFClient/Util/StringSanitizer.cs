using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Util
{
    class StringSanitizer
    {
        /// <summary>
        /// Tests the string sanitization without blank.
        /// </summary>
        /// <param name="stringToSanitize">The string to sanitize.</param>
        /// <returns></returns>
        public static bool TestStringSanitizationWithoutBlank(string stringToSanitize)
        {
            foreach (char character in stringToSanitize)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Tests the string sanitization with blank.
        /// </summary>
        /// <param name="stringToSanitize">The string to sanitize.</param>
        /// <returns></returns>
        public static bool TestStringSanitizationWithBlank(string stringToSanitize)
        {
            foreach (char character in stringToSanitize)
            {
                if (!char.IsLetterOrDigit(character)||char.IsSeparator(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
