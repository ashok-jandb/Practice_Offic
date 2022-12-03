using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class OutputParamExample
    {
        public void Run()
        {
            int x = 0;
            OutputParamTest(out x);
            Console.WriteLine(x);
        }

        private void OutputParamTest(out int i)
        {
            i = 10;
        }
    }
}
