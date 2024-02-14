using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            _ = DateTime.Now;
            _ = DateTime.TryParse(s, out DateTime dt);

            return dt.ToString("HH:mm:ss");
        }
    }
}
