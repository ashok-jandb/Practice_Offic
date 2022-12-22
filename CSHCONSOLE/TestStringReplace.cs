using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    public class TestStringReplace
    {
        public void Run()
        {
            int value = 0;
            var reason = "Waiting_for_response_4915";
            string newHoldReason = string.Empty;
            if (!string.IsNullOrEmpty(reason))
            {
                if (reason.ToLower().Contains("waiting"))
                {
                    reason = reason.Replace("~", string.Empty);
                    string[] split = reason.Split('_');
                    if (split.Length == 4)
                    {
                        if (!int.TryParse(split[3].Trim(), out value))
                        {
                            //continue;
                        }
                        else
                        {
                            newHoldReason = "~" + split[0] + "_" + split[1] + "_" + split[2] + "_~";
                            /*string replaceQuery = CreateSQLQuery.ReplaceHoldReason(hold.WorkorderID.ToString(), reason, newHoldReason);
                            ExecuteSQLQuery.ExecuteCommand(replaceQuery, con, transaction);
                            transaction.Commit();*/
                        }
                    }
                }
            }
        }
    }
}
