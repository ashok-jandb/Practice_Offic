using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    class SplitByTilde
    {
        public void Run()
        {
            var str = "One~Two~Three~Four~Five";
            List<string> list = str.Split('~').ToList();
        }
    }
}
