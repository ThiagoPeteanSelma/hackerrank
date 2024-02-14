using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class MiniMaxSum
    {
        /// <summary>
        /// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        /// Example
        /// The minimum sum is  and the maximum sum is . The function prints
        /// 16 24
        /// </summary>
        /// <param name="arr">The function accepts INTEGER_ARRAY arr as parameter.</param>
        /// <returns>The function return a string with values min and max separated by space</returns>
        public static string miniMaxSum(List<int> arr)
        {
            Int64 sumMax = arr.OrderByDescending(x => x).Take(arr.Count - 1).Select(x => (Int64)x).Sum();
            Int64 sumMin = arr.OrderBy(x => x).Take(arr.Count - 1).Select(x => (Int64)x).Sum();

            return sumMin + " " + sumMax;
        }
    }
}
