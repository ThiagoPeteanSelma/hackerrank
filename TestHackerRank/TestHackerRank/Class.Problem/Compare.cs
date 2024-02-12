using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHackerRank.Class.Problem
{
    public class Compare
    {
        public static List<int> compare(List<int> a, List<int> b)
        {
            int point_a = 0, point_b = 0;
            List<int> ret = new List<int>();
            for (var i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    point_a++;
                else if (a[i] < b[i])
                    point_b++;
            }
            ret.Add(point_a);
            ret.Add(point_b);
            return ret;
        }
    }
}
