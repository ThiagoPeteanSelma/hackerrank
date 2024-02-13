using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class SockMerchant
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            return ar.GroupBy(x => x).Sum(x => x.Count() / 2);
        }
    }
}
