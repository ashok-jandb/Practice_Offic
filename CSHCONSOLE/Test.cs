using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class Test
    {
        public void Run()
        {
            string someVar = "";
            string[] someVarSplitted = someVar.Split(',');
            var count = someVarSplitted.Length;
            Console.WriteLine(count);
        }
    }
}
