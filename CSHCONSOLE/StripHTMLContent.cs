using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    class StripHTMLContent
    {
        public void GetStrippedContent()
        {
            string htmlContent = string.Empty;
            var objConn = new SqlConnection(@"Data Source=JBMAZSQL05;Initial Catalog=Reports;Persist Security Info=True;User ID=sqlappuser;Password=$Ql@pp1");
            var objCmd = new SqlCommand("select NoteText from HHSQLDB.dbo.tbl_Account_Note_History where id = 1180089", objConn);
            objConn.Open();
            htmlContent = Convert.ToString(objCmd.ExecuteScalar());
            objConn.Close();
            Console.WriteLine("Original string: \n" + htmlContent);
            var result = htmlContent.StripHTML().RemoveUntitled().ReplaceSpacesWithNewLine();
            Console.WriteLine("Result: \n" + result);
            //var strippedString = StripHTML(htmlContent);
            ////myString = myString.Replace(System.Environment.NewLine, "replacement text");
            //Console.WriteLine("strippedString:\n" + strippedString);
            //var untitledRemoved = strippedString.Remove(untitledPosition, untitledLength);
            //Console.WriteLine("untitledRemoved: " + untitledRemoved);
            //var spacesReplaced = untitledRemoved.Replace("&nbsp;", "\x0A");
            //Console.WriteLine("spacesReplaced:\n" + spacesReplaced);
            //var result = htmlContent
        }
    }
}
