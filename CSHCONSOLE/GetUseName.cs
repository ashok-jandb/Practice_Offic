using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    class GetUseName
    {
        public void Run()
        {
            string DomainName = System.Environment.UserDomainName;
            Console.WriteLine("Domain name: " + DomainName); //JANDBMEDICAL
            string AccountName = System.Environment.UserName.ToLower();
            Console.WriteLine("Account name: " + AccountName); //ashok.kottagundu
            SelectQuery query = new SelectQuery("select FullName from Win32_UserAccount where domain='" + DomainName + "' and name='" + AccountName + "'");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementBaseObject disk in searcher.Get())
            {
                Console.WriteLine("Full name: " + disk["FullName"].ToString()); //Ashok Kumar Kottagundu
            }
        }
    }
}
