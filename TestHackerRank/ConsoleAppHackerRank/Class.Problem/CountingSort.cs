using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHackerRank.Class.Problem
{
    public class CountingSort
    {
        public static List<int> countingSort(List<int> arr)
        {
            var l = arr.GroupBy(x => x).Select(x => new { val = x.Key, qtd = x.Count() }).ToList();
            var lret = new int[100];

            foreach (var x in l)
                lret[x.val] = x.qtd;

            return lret.ToList<int>();
        }
    }
}
