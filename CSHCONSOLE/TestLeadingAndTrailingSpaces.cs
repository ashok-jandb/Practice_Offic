using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHCONSOLE
{
    class TestLeadingAndTrailingSpaces
    {
        public void Run()
        {
            var holdReasons = new List<string>();
            string holdReason = "    hold reason     ";
            holdReasons.Add(holdReason);
            int leadingWhitesCount = holdReason.Length - holdReason.TrimStart(' ').Length;
            int trailingWhilesCount = holdReason.Length - holdReason.TrimEnd(' ').Length;

            for (int i = 1; i <= leadingWhitesCount; i++)
            {
                holdReasons.Add(holdReason.Substring(1));
                holdReason = holdReason.Substring(1);
            }

            for (int i = 1; i <= trailingWhilesCount; i++)
            {
                holdReasons.Add(holdReason.Substring(0, holdReason.Length - 1));
                holdReason = holdReason.Substring(0, holdReason.Length - 1);
            }
            foreach (var item in holdReasons)
            {
                Console.WriteLine("'" + item + "'");
            }
        }
    }
}
