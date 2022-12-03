using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public static class StringOperations
    {
        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        public static string RemoveUntitled(this string input)
        {
            var untitledPosition = input.IndexOf("Untitled");
            var untitledLength = "Untitled".Length;
            return input.Remove(untitledPosition, untitledLength);
        }

        public static string ReplaceSpacesWithNewLine(this string input)
        {
            return input.Replace("&nbsp;", "\x0A");
        }
    }
}
