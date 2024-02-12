using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class MiniMaxSum
    {
        public static string miniMaxSum(List<int> arr)
        {
            Int64 sumMax = arr.OrderByDescending(x => x).Take(arr.Count - 1).Select(x => (Int64)x).Sum();
            Int64 sumMin = arr.OrderBy(x => x).Take(arr.Count - 1).Select(x => (Int64)x).Sum();

            return sumMin + " " + sumMax;
        }
    }
}
