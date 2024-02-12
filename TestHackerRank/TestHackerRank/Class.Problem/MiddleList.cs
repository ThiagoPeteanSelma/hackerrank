using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    internal class MiddleList
    {
        public static int middleList(List<int> arr)
        {
            return arr.OrderBy(x => x).Skip(arr.Count / 2).Take(1).First();
        }
    }
}
