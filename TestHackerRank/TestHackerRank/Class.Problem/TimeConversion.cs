using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime dt = DateTime.Now;
            DateTime.TryParse(s, out dt);

            return dt.ToString("HH:mm:ss");
        }
    }
}
