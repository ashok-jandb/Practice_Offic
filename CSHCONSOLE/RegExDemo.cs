using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class RegExDemo
    {
        public void Run()
        {
            string str = "EXT_FAILED";
            Regex regex = new Regex(@"(EXT_FAILED)$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
            Match match = regex.Match(str);
            if (match.Success)
                Console.WriteLine("Match Found");
            else
                Console.WriteLine("No Match Found");
        }
    }
}
