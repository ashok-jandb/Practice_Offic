using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    class LoggedInUserNameDemo
    {
        public void Run()
        {
            var lun = @"JANDBMEDICAL\ashok.kottagundu";
            var loggedInUserNameWithoutDomainName = lun.Split('\\')[1];
            Console.WriteLine(loggedInUserNameWithoutDomainName);
        }
    }
}
