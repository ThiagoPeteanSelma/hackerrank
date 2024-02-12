using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class PlusMinus
    {
        public static string plusMinus(List<int> arr)
        {
            int pos = 0, neg = 0, zero = 0, n = arr.Count();
            foreach (int i in arr)
            {
                if (i > 0)
                    pos++;
                else if (i < 0)
                    neg++;
                else
                    zero++;
            }
            var l = new List<string>() {  ((double)pos / (double)n).ToString("0.000000"),
                                          ((double)neg / (double)n).ToString("0.000000"),
                                          ((double)zero / (double)n).ToString("0.000000") };
            
            return String.Join(@"\r\n", l);
        }
    }
}
