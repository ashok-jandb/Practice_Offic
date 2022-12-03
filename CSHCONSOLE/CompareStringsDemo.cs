using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class CompareStringsDemo
    {
        public void Run()
        {
            string str1 = "SVS";
            string str2 = "Svs";
            var comparisonResult = str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(comparisonResult);
        }
    }
}
